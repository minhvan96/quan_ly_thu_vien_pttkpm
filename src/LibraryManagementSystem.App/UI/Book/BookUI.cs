using LibraryManagementSystem.App.Features.BookFeature.Queries;
using LibraryManagementSystem.App.Features.BookTypeFeature.Queries;
using LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Queries;
using MediatR;
using System.Data;
using System.Globalization;

namespace LibraryManagementSystem.App.UI.Book
{
    public partial class BookUI : UserControl
    {
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
            foreach (var book in books.Items)
            {
                var configurationGridViewRow = new DataGridViewRow();
                configurationGridViewRow.CreateCells(BM_ManageBookDGV);
                configurationGridViewRow.Cells[0].Value = book.Id;
                configurationGridViewRow.Cells[1].Value = book.Name;
                configurationGridViewRow.Cells[2].Value = book.Author;
                configurationGridViewRow.Cells[3].Value = book.Publisher;
                configurationGridViewRow.Cells[4].Value = book.TypeName;
                configurationGridViewRow.Cells[5].Value = book.PublishedDate;
                configurationGridViewRow.Cells[6].Value = "Xóa";
                BM_ManageBookDGV.Rows.Add(configurationGridViewRow);
            }
        }

        private void BookManager_AddBookButton_Click(object sender, EventArgs e)
        {

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

            dtpPushlsh.Value = Convert.ToDateTime(BM_ManageBookDGV.Rows[e.RowIndex].Cells[5].Value.ToString());
        }
    }
}
