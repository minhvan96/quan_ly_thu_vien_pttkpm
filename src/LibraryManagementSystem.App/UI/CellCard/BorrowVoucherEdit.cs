using LibraryManagementSystem.App.Features.BookFeature.Dtos;
using LibraryManagementSystem.App.Features.BookFeature.Queries;
using LibraryManagementSystem.App.Features.CallCardFeature.Commands;
using LibraryManagementSystem.App.Features.CallCardFeature.Dtos;
using LibraryManagementSystem.App.Features.CallCardFeature.Queries;
using MediatR;

namespace LibraryManagementSystem.App
{
    public partial class BorrowVoucherEdit : UserControl
    {
        private readonly IMediator _mediator;
        private List<BookDto> bookList;
        private List<BorrowBookListSelectedDto> bookSelectedList;
        private readonly TabPage _page;
        private readonly Guid _callCardId;

        private List<BorrowBookListSelectedDto> bookSelectedListLoaded;
        private List<BorrowBookListSelectedDto> bookSelectedListNeedDelete;
        private List<BorrowBookListSelectedDto> bookSelectedListNeedAdd;

        public BorrowVoucherEdit(IMediator mediator, TabPage page, Guid callCardId)
        {
            InitializeComponent();
            this._mediator = mediator;
            this._page = page;
            this._callCardId = callCardId;
            dtg_bookListSelected.AutoGenerateColumns = false;
            dtg_BookList.AutoGenerateColumns = false;
            bookList = new List<BookDto>();
            bookSelectedList = new List<BorrowBookListSelectedDto>();
        }

        private async void BorrowVoucherEdit_Load(object sender, EventArgs e)
        {
            // get borrow book by Id
            var callCardCmd = new CallCardQuery()
            {
                Id = _callCardId
            };
            var callCard = await _mediator.Send(callCardCmd);

            // load book list with quantity > 0
            var bookListCmd = new ListBooksQuery();
            var books = await _mediator.Send(bookListCmd);
            bookList = books.Items.ToList();
            dtg_BookList.DataSource = books.Items;

            // load current date time
            datepk_borrowDate.Text = callCard.BorrowDate.ToString();

            // load reader list
            var readerListCmd = new LibraryCardListQuery();
            var readers = await _mediator.Send(readerListCmd);
            if (readers != null && readers.Items.Count > 0)
            {
                cbb_Reader.DataSource = readers.Items;
                cbb_Reader.DisplayMember = "Name";
                cbb_Reader.ValueMember = "Id";
                cbb_Reader.SelectedValue = callCard.LibraryCard.Id;
            }

            // load book selected list 
            var booksSelectedLoad = books.Items.Where(b => callCard.CallCardDetails.Any(c => c.BookId == b.Id))
                .Select(x => new BorrowBookListSelectedDto()
                {
                    BookId = x.Id,
                    BookName = x.Name,
                    Author = x.Author,
                    BookType = x.TypeName
                }).ToList();
            bookSelectedList = booksSelectedLoad;
            bookSelectedListLoaded = new List<BorrowBookListSelectedDto>(booksSelectedLoad);
            dtg_bookListSelected.DataSource = new BindingSource(bookSelectedList, "");
        }

        private void dtg_bookListSelected_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var bookSelectedRow = dtg_bookListSelected.SelectedRows[0];
            var bookId = new Guid(bookSelectedRow.Cells["BookId"].Value.ToString());
            var bookFindInd = bookList.FindIndex(x => x.Id == bookId);
            if (bookFindInd > -1)
            {
                bookList[bookFindInd].InStock += 1;
            }
            else
            {
                var bookDto = new BookDto()
                {
                    Id = new Guid(bookSelectedRow.Cells["BookId"].Value.ToString()),
                    Name = bookSelectedRow.Cells["BookName"].Value.ToString(),
                    TypeName = bookSelectedRow.Cells[3].Value.ToString(),
                    Author = bookSelectedRow.Cells[2].Value.ToString(),
                    InStock = 1
                };
                bookList.Add(bookDto);
            }

            // remove in selected table
            var bookSelectedFindInd = bookSelectedList.FindIndex(x => x.BookId == bookId);
            bookSelectedList.RemoveAt(bookSelectedFindInd);

            dtg_BookList.DataSource = new BindingSource(bookList, "");
            dtg_bookListSelected.DataSource = new BindingSource(bookSelectedList, "");
        }

        private void dtg_BookList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var bookSelectedRow = dtg_BookList.SelectedRows[0];
            if ((int)bookSelectedRow.Cells["InStock"].Value == 0)
            {
                MessageBox.Show("Sách đã hết!");
                return;
            }

            var bookSelected = new BorrowBookListSelectedDto()
            {
                Author = bookSelectedRow.Cells["Author"].Value.ToString(),
                BookId = new Guid(bookSelectedRow.Cells["Id"].Value.ToString()),
                BookName = bookSelectedRow.Cells["Name"].Value.ToString(),
                BookType = bookSelectedRow.Cells["TypeName"].Value.ToString()
            };
            var checkExists = bookSelectedList.Any(x => x.BookId == bookSelected.BookId);
            if (!checkExists)
            {
                bookSelectedList.Add(bookSelected);
                dtg_bookListSelected.DataSource = new BindingSource(bookSelectedList, "");

                // instock - 1
                var bookFindInd = bookList.FindIndex(x => x.Id == bookSelected.BookId);
                if (bookList[bookFindInd].InStock > 1)
                {
                    bookList[bookFindInd].InStock -= 1;
                }
                else
                {
                    bookList.RemoveAt(bookFindInd);
                }

                dtg_BookList.DataSource = new BindingSource(bookList, "");
            }
            else
            {
                MessageBox.Show("Bạn đã chọn sách này!");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            ReturnCallCardListView();
        }

        private async void btn_update_callCard_Click(object sender, EventArgs e)
        {
            bookSelectedListNeedDelete = bookSelectedListLoaded.Where(l => !bookSelectedList.Any(s => s.BookId == l.BookId)).ToList();
            bookSelectedListNeedAdd = bookSelectedList.Where(l => !bookSelectedListLoaded.Any(s => s.BookId == l.BookId)).ToList();
            var libraryCardId = cbb_Reader.SelectedValue.ToString();
            var borrowDate = datepk_borrowDate.Text;

            var callCard = new CallCardUpdateCommand()
            {
                booksNeedAdd = bookSelectedListNeedAdd,
                booksNeedDelete = bookSelectedListNeedDelete,
                BorrowDate = DateTime.Parse(borrowDate),
                CallCardId = _callCardId,
                LibraryCardId = new Guid(libraryCardId)
            };
            try
            {
                var borrow = await _mediator.Send(callCard);
                if (!borrow.Success)
                {
                    MessageBox.Show(borrow.Message);
                    return;
                }
                MessageBox.Show("Cập nhật thành công!");

                // return call card list view
                ReturnCallCardListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!");
            }
        }

        private void ReturnCallCardListView()
        {
            var myUserControl = new BorrowVoucherList(_mediator, _page);
            myUserControl.Dock = DockStyle.Fill;
            _page.Controls.Clear();
            _page.Controls.Add(myUserControl);
        }
    }
}
