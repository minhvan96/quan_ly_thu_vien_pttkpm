using LibraryManagementSystem.App.Features.BookFeature.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.App
{
    public partial class BorrowVoucherEdit : UserControl
    {
        private readonly IMediator _mediator;
        private List<BookDto> bookList;
        //private List<BorrowBookListSelectedDto> bookSelectedList;
        private readonly TabPage _page;
        private readonly Guid _borrowBookId;

        public BorrowVoucherEdit(IMediator mediator, TabPage page, Guid borrowBookId)
        {
            InitializeComponent();
            this._mediator = mediator;
            this._page = page;
            this._borrowBookId = borrowBookId;
            dtg_bookListSelected.AutoGenerateColumns = false;
            dtg_BookList.AutoGenerateColumns = false;
            bookList = new List<BookDto>();
            //bookSelectedList = new List<BorrowBookListSelectedDto>();
        }

        private async void BorrowVoucherEdit_Load(object sender, EventArgs e)
        {
            //// get borrow book by Id
            //var borrowBookListCmd = new BookVoucherQuery()
            //{
            //    Id = _borrowBookId
            //};
            //var borrowBook = await _mediator.Send(borrowBookListCmd);

            //// load book list with quantity > 0
            //var bookListCmd = new ListBooksQuery();
            //var books = await _mediator.Send(bookListCmd);
            //bookList = books.Items.ToList();
            //dtg_BookList.DataSource = books.Items;

            //// load current date time
            //datepk_borrowDate.Text = borrowBook.BorrowDate.ToString();

            //// load reader list
            //var readerListCmd = new ListReaderQuery();
            //var readers = await _mediator.Send(readerListCmd);
            //if (readers != null && readers.Items.Count > 0)
            //{
            //    cbb_Reader.DataSource = readers.Items;
            //    cbb_Reader.DisplayMember = "Name";
            //    cbb_Reader.ValueMember = "Id";
            //    cbb_Reader.SelectedValue = borrowBook.ReaderId;
            //}

            //// load book selected list 
            //bookSelectedList = borrowBook.BorrowBookDetails.Select(x => new BorrowBookListSelectedDto()
            //{
            //    BookId = x.BookId,
            //    BookName = x.Book.Name,
            //    Author = x.Book.Author.Name,
            //    BookType = x.Book.BookType.Name
            //}).ToList();
            //dtg_bookListSelected.DataSource = new BindingSource(bookSelectedList, "");
        }

        private void dtg_BookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var bookSelectedRow = dtg_BookList.SelectedRows[0];
            //if ((int)bookSelectedRow.Cells["InStock"].Value == 0)
            //{
            //    MessageBox.Show("Sách đã hết!");
            //    return;
            //}

            //var bookSelected = new BorrowBookListSelectedDto()
            //{
            //    Author = bookSelectedRow.Cells["Author"].Value.ToString(),
            //    BookId = new Guid(bookSelectedRow.Cells["Id"].Value.ToString()),
            //    BookName = bookSelectedRow.Cells["Name"].Value.ToString(),
            //    BookType = bookSelectedRow.Cells["TypeName"].Value.ToString()
            //};
            //var checkExists = bookSelectedList.Any(x => x.BookId == bookSelected.BookId);
            //if (!checkExists)
            //{
            //    bookSelectedList.Add(bookSelected);
            //    dtg_bookListSelected.DataSource = new BindingSource(bookSelectedList, "");

            //    // instock - 1
            //    var bookFindInd = bookList.FindIndex(x => x.Id == bookSelected.BookId);
            //    if (bookList[bookFindInd].InStock > 1)
            //    {
            //        bookList[bookFindInd].InStock -= 1;
            //    }
            //    else
            //    {
            //        bookList.RemoveAt(bookFindInd);
            //    }

            //    dtg_BookList.DataSource = new BindingSource(bookList, "");
            //}
            //else
            //{
            //    MessageBox.Show("Bạn đã chọn sách này!");
            //}
        }

        private void dtg_bookListSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var bookSelectedRow = dtg_bookListSelected.SelectedRows[0];
            //var bookId = new Guid(bookSelectedRow.Cells["BookId"].Value.ToString());
            //var bookFindInd = bookList.FindIndex(x => x.Id == bookId);
            //bookList[bookFindInd].InStock += 1;

            //// remove in selected table
            //var bookSelectedFindInd = bookSelectedList.FindIndex(x => x.BookId == bookId);
            //bookSelectedList.RemoveAt(bookSelectedFindInd);

            //dtg_BookList.DataSource = new BindingSource(bookList, "");
            //dtg_bookListSelected.DataSource = new BindingSource(bookSelectedList, "");
        }
    }
}
