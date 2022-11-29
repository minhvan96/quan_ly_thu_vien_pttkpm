using LibraryManagementSystem.App.Features.BookFeature.Dtos;
using LibraryManagementSystem.App.Features.BookFeature.Queries;
using LibraryManagementSystem.App.Features.CallCardFeature.Commands;
using LibraryManagementSystem.App.Features.CallCardFeature.Dtos;
using LibraryManagementSystem.App.Features.CallCardFeature.Queries;
using MediatR;

namespace LibraryManagementSystem.App;

public partial class MakeBorrowVoucher : UserControl
{
    private readonly IMediator _mediator;
    private List<BookDto> bookList;
    private List<BorrowBookListSelectedDto> bookSelectedList;

    public MakeBorrowVoucher(IMediator mediator)
    {
        InitializeComponent();
        this._mediator = mediator;
        dtg_bookListSelected.AutoGenerateColumns = false;
        dtg_BookList.AutoGenerateColumns = false;
        bookList = new List<BookDto>();
        bookSelectedList = new List<BorrowBookListSelectedDto>();
    }

    private async void Loaded(object sender, EventArgs e)
    {
        // load book list with quantity > 0
        var bookListCmd = new ListBooksQuery();
        var books = await _mediator.Send(bookListCmd);
        bookList = books.Items.ToList();
        dtg_BookList.DataSource = books.Items;

        // load current date time
        datepk_borrowDate.Text = DateTime.Now.ToString();

        // load reader list
        var readerListCmd = new LibraryCardListQuery();
        var readers = await _mediator.Send(readerListCmd);
        if (readers != null && readers.Items.Count > 0)
        {
            cbb_Reader.DataSource = readers.Items;
            cbb_Reader.DisplayMember = "Name";
            cbb_Reader.ValueMember = "Id";
        }

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

    private void dtg_bookListSelected_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        var bookSelectedRow = dtg_bookListSelected.SelectedRows[0];
        var bookId = new Guid(bookSelectedRow.Cells["BookId"].Value.ToString());
        var bookFindInd = bookList.FindIndex(x => x.Id == bookId);
        bookList[bookFindInd].InStock += 1;

        // remove in selected table
        var bookSelectedFindInd = bookSelectedList.FindIndex(x => x.BookId == bookId);
        bookSelectedList.RemoveAt(bookSelectedFindInd);

        dtg_BookList.DataSource = new BindingSource(bookList, "");
        dtg_bookListSelected.DataSource = new BindingSource(bookSelectedList, "");
    }

    private async void btn_submit_Click(object sender, EventArgs e)
    {
        var checkBookSelected = dtg_bookListSelected.Rows.Count > 0;
        if (!checkBookSelected)
        {
            MessageBox.Show("Vui lòng chọn sách!");
            return;
        }

        var libraryCardId = cbb_Reader.SelectedValue.ToString();
        var borrowDate = datepk_borrowDate.Text;
        var bookIdSelectedList = dtg_bookListSelected.Rows.OfType<DataGridViewRow>()
            .Select(x => new Guid(x.Cells["BookId"].Value.ToString()))
            .ToList<Guid>();

        var callCard = new CallCardCommand()
        {
            BookIds = bookIdSelectedList,
            BorrowDate = DateTime.Parse(borrowDate),
            LibraryCardId = new Guid(libraryCardId),
        };
        try
        {
            await _mediator.Send(callCard);
            MessageBox.Show("Cho mượn sách thành công");

            bookSelectedList.Clear();
            dtg_bookListSelected.DataSource = new BindingSource(bookSelectedList, "");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!");
        }
    }
}