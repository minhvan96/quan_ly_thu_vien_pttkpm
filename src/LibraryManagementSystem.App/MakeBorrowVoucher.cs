using LibraryManagementSystem.App.Features.BookFeature.Queries;
using LibraryManagementSystem.App.Features.MakeBorrowVoucherFeature.Dtos;
using MediatR;

namespace LibraryManagementSystem.App;

public partial class MakeBorrowVoucher : UserControl
{
    private readonly IMediator _mediator;

    public MakeBorrowVoucher(IMediator mediator)
    {
        InitializeComponent();
        this._mediator = mediator;
        dtg_bookListSelected.AutoGenerateColumns = false;
        dtg_BookList.AutoGenerateColumns = false;
    }

    private async void Loaded(object sender, EventArgs e)
    {
        // load book list with quantity > 0
        var bookListCmd = new ListBooksQuery();
        var bookList = await _mediator.Send(bookListCmd);
        dtg_BookList.DataSource = bookList.Items;

        // load current date time


        // load reader list
        if (bookList != null && bookList.Items.Count > 0)
        {
            //cbb_Reader.DataSource = bookList.Items;
            //cbb_Reader.DisplayMember = "Name";
            //cbb_Reader.ValueMember = "Id";
        }

    }

    private void dtg_BookList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        var bookSelected = dtg_BookList.Rows.OfType<DataGridViewRow>()
                 .Select(x => new BorrowBookListSelectedDto()
                 {
                     Author = x.Cells["Author"].Value.ToString(),
                     BookId = new Guid(x.Cells["Id"].Value.ToString()),
                     BookName = x.Cells["Name"].Value.ToString(),
                     BookType = x.Cells["TypeName"].Value.ToString()
                 })
                 .ToList<BorrowBookListSelectedDto>()[0]


        var t = dtg_BookList.Rows
    .OfType<DataGridViewRow>().Select(x =>x)
     .ToList<DataGridViewRow>()[0]
     .Selected = true;
        dtg_bookListSelected.DataSource = bookSelected;
    }
}