using LibraryManagementSystem.App.Features.AuthorFeature.Commands;
using LibraryManagementSystem.App.Features.AuthorFeature.Dtos;
using LibraryManagementSystem.App.Features.AuthorFeature.Queries;
using LibraryManagementSystem.App.Features.BookFeature.Commands;
using LibraryManagementSystem.App.Features.BookFeature.Queries;
using LibraryManagementSystem.App.Features.BookTypeFeature.Queries;
using LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Dtos;
using LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Queries;
using LibraryManagementSystem.App.Features.PubblisherFeature.Commands;
using LibraryManagementSystem.App.Features.PubblisherFeature.Dtos;
using LibraryManagementSystem.App.Features.PubblisherFeature.Queries;
using MediatR;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace LibraryManagementSystem.App.UI.Book
{
    public partial class BookUI : UserControl
    {
        private static Random random = new Random();
        private readonly IMediator _mediator;
        private readonly TabPage _pageMain;
        
        public BookUI(IMediator mediator, TabPage pageMain)
        {
            InitializeComponent();
            this._mediator = mediator;
            this._pageMain = pageMain;
        }

        private async void BookPageSearchBooksButton_Click(object sender, EventArgs e)
        {
            var searchOptions = SearchBookOptions.None;
            if (SearchBookByNameCheckBox.Checked)
                searchOptions |= SearchBookOptions.BookName;
            if (SearchBookByTypeCheckBox.Checked)
                searchOptions |= SearchBookOptions.TypeName;
            if (SearchBookByAuthorCheckBox.Checked)
                searchOptions |= SearchBookOptions.AuthorName;
            if (SearchBookByStatusCheckBox.Checked)
                searchOptions |= SearchBookOptions.StatusName;
            var listBooksQuery = new ListBooksQuery
            {
                SearchCriteria = SearchBookSearchCriteriaTextBox.Text,
                SearchOption = searchOptions
            };
            var books = await _mediator.Send(listBooksQuery);

            BookPageDataGridView.Rows.Clear();
            var index = 1;
            foreach (var book in books.Items)
            {
                var configurationGridViewRow = new DataGridViewRow();
                configurationGridViewRow.CreateCells(BookPageDataGridView);
                configurationGridViewRow.Cells[0].Value = index;
                configurationGridViewRow.Cells[1].Value = book.Name;
                configurationGridViewRow.Cells[2].Value = book.TypeName;
                configurationGridViewRow.Cells[3].Value = book.Author;
                configurationGridViewRow.Cells[4].Value = "tinh trang";
                BookPageDataGridView.Rows.Add(configurationGridViewRow);

                index++;
            }
        }

        private async void BookMenu_ManageBookPage_Enter(object sender, EventArgs e)
        {
            #region LOAD BOOK TYPES

            var bookTypes = await _mediator.Send(new ListBookTypesQuery());
            var bookTypesDataTable = new DataTable();
            var bookTypeIdColumn = new DataColumn("Id", typeof(Guid));
            var bookTypeNameColumn = new DataColumn("Name", typeof(string));
            var bookTypesDataTableAllTypes = bookTypesDataTable;

            bookTypesDataTable.Columns.Add(bookTypeIdColumn);
            bookTypesDataTable.Columns.Add(bookTypeNameColumn);
            bookTypesDataTableAllTypes.Rows.Add(Guid.Empty, "Tất cả thể loại");
            foreach (var bookType in bookTypes.Items)
            {
                bookTypesDataTable.Rows.Add(bookType.Id, bookType.Name);
            }
            BookManager_BookTypeCbb.DataSource = bookTypesDataTableAllTypes;
            BookManager_BookTypeCbb.DisplayMember = "Name";
            BookManager_BookTypeCbb.ValueMember = "Id";

            #endregion LOAD BOOK TYPES

            this.loadTable();
        }

        private async void loadTable()
        {

            var books = await _mediator.Send(new ListBooksQuery());

            BM_ManageBookDGV.Rows.Clear();
            BM_ManageBookDGV.Refresh();
            BM_ManageBookDGV.DataSource = null;
            foreach (var book in books.Items)
            {
                var configurationGridViewRow = new DataGridViewRow();
                configurationGridViewRow.CreateCells(BM_ManageBookDGV);
                configurationGridViewRow.Cells[0].Value = book.Id;
                configurationGridViewRow.Cells[1].Value = book.Name;
                configurationGridViewRow.Cells[2].Value = book.Author;
                configurationGridViewRow.Cells[3].Value = book.Publisher;
                configurationGridViewRow.Cells[4].Value = book.TypeName;
                configurationGridViewRow.Cells[5].Value = book.publishedYear;
                configurationGridViewRow.Cells[6].Value = book.InStock;
                configurationGridViewRow.Cells[7].Value = book.EntryDate;
                configurationGridViewRow.Cells[8].Value = "Xóa";
                BM_ManageBookDGV.Rows.Add(configurationGridViewRow);
            }
            txtPublishYear.Value = DateTime.Now.Year;
        }

        //kiem tra author ton tại chưa, nếu chưa thì thêm author
        private async Task<AuthorDto> getAuthor(string name)
        {
            CreateAuthorCommand cmdAuthor;

            var queryAuthor = new GetAuthorQuery()
            {
                Name = txbAuthor.Text
            };
            AuthorDto Author = await _mediator.Send(queryAuthor);

            if (Author == null)
            {
                cmdAuthor = new CreateAuthorCommand()
                {
                    Name = txbAuthor.Text
                };

                Author = await _mediator.Send(cmdAuthor);
            }

            return Author;
        }

        //Kiem tra publiser tồn tại chưa nếu chưa thì thêm publisher
        private async Task<PublisherDto> getPubliserResult(string name)
        {
            CreatePubliserCommand cmdPublisher;
            var queryPubliser = new GetPublisherQuery()
            {
                Name = txbPublisher.Text
            };

            PublisherDto Publiser = await _mediator.Send(queryPubliser);
            if (Publiser == null)
            {
                cmdPublisher = new CreatePubliserCommand()
                {
                    Name = txbPublisher.Text
                };

                Publiser = await _mediator.Send(cmdPublisher);
            }
            return Publiser;
        }


        private async Task<Boolean> IsValid()
        {
            Guid typeId = BookManager_BookTypeCbb.SelectedValue == null ? Guid.Empty : (Guid)BookManager_BookTypeCbb.SelectedValue;
            if (typeId == Guid.Empty)
            {
                MessageBox.Show("Không thể bỏ trống thể loại sách.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(txbName.Text == string.Empty)
            {
                MessageBox.Show("Không thể bỏ trống tên sách.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(txbAuthor.Text == string.Empty)
            {
                MessageBox.Show("Không thể bỏ trống tên tác giả.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(txbPublisher.Text == string.Empty)
            {
                MessageBox.Show("Không thể bỏ trống nhà xuất bản sách.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            var cmdCofnig = new GetLibraryConfigurationQuery()
            {
                Id = new Guid("b7eef645-ef23-4cb2-8927-f9a8c817b4b7")
            };
            var year = await _mediator.Send(cmdCofnig);
            if ((DateTime.Now.Year - Convert.ToInt32(dtpEntryDate.Value.Year)) > year.Value)
            {
                MessageBox.Show("Năm xuất bản không thể quá " + year.Value + " năm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async void BookManager_AddBookButton_Click(object sender, EventArgs e)
        {

            if (await this.IsValid() == false)
            {
                return;
            }

            AuthorDto resultAuthor = await getAuthor(txbAuthor.Text);
            PublisherDto resultPubliser = await getPubliserResult(txbPublisher.Text);

           

            var cmdBook = new CreateBookCommand()
            {
                Name = txbName.Text,
                AuthorId = resultAuthor.Id,
                PublisherId = resultPubliser.Id,
                TypeId = (Guid)BookManager_BookTypeCbb.SelectedValue,
                EntryDate = dtpEntryDate.Value,
                quantily = Convert.ToInt32(txbQuantily.Value),
                PublishedYear = Convert.ToInt32(txtPublishYear.Value)

            };

            CreateBookResult result =  await _mediator.Send(cmdBook);
            if (result.Success)
            {
                MessageBox.Show("Thêm sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbId.Text = result.Id.ToString();
                this.loadTable();
            }
            else
            {
                MessageBox.Show("Thêm sách không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BM_ManageBookDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            txbId.Text = BM_ManageBookDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbName.Text = BM_ManageBookDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbAuthor.Text = BM_ManageBookDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            txbPublisher.Text = BM_ManageBookDGV.Rows[e.RowIndex].Cells[3].Value.ToString();

            BookManager_BookTypeCbb.SelectedIndex = BookManager_BookTypeCbb.FindString(BM_ManageBookDGV.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtPublishYear.Value = int.Parse(BM_ManageBookDGV.Rows[e.RowIndex].Cells[5].Value.ToString());

            txbQuantily.Value = int.Parse(BM_ManageBookDGV.Rows[e.RowIndex].Cells[6].Value.ToString());
            dtpEntryDate.Value = Convert.ToDateTime(BM_ManageBookDGV.Rows[e.RowIndex].Cells[7].Value.ToString());

        }

        private async void BookManager_UpdateBookButton_Click(object sender, EventArgs e)
        {
            if (await this.IsValid() == false)
            {
                return;
            }

            AuthorDto resultAuthor = await getAuthor(txbAuthor.Text);
            PublisherDto resultPubliser = await getPubliserResult(txbPublisher.Text);

            var cmd = new UpdateBookCommand()
            {
                Id = new Guid(txbId.Text),
                Name = txbName.Text,
                AuthorId = resultAuthor.Id,
                PublisherId = resultPubliser.Id,
                TypeId = (Guid)BookManager_BookTypeCbb.SelectedValue,
                quantily = Convert.ToInt32(txbQuantily.Value),
                Published = dtpEntryDate.Value,
                publishedYear = Convert.ToInt32(txtPublishYear.Value)
            };
            UpdateBookResult result = await _mediator.Send(cmd);
            if (result.Success)
            {
                MessageBox.Show("Cập nhật sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.loadTable();
            }
            else
            {
                MessageBox.Show("Cập nhật sách không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void BM_ManageBookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                DialogResult isDelete = MessageBox.Show("Cảnh báo thao tác này sẽ không thể quay lại, bạn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                String id = txbId.Text == "" ? BM_ManageBookDGV.Rows[e.RowIndex].Cells[0].Value.ToString() : txbId.Text;
                if (isDelete == DialogResult.OK)
                {
                    var cmd = new DeleteBookCommand
                    {
                        Id = new Guid(id)
                    };
                    var result = await _mediator.Send(cmd);
                    if (result.Success)
                    {
                        MessageBox.Show("Xóa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.loadTable();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sách không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbId.Text = "";
            txbAuthor.Text = "";
            txbName.Text = "";
            txbPublisher.Text = "";
            txbQuantily.Value = 1;
            dtpEntryDate.Value = DateTime.Now;
            txtPublishYear.Value = DateTime.Now.Year;
            BookManager_BookTypeCbb.SelectedIndex = 0;
        }

       
    }
}
