using LibraryManagementSystem.App.Features.BookFeature.Queries;
using MediatR;

namespace LibraryManagementSystem.App;

public partial class MakeBorrowVoucher : UserControl
{
    private readonly IMediator _mediator;

    public MakeBorrowVoucher(IMediator mediator)
    {
        InitializeComponent();
        this._mediator = mediator;
    }

    private async void Loaded(object sender, EventArgs e)
    {
        // load book list with quantity > 0
        var bookListCmd = new ListBooksQuery();
        var bookList = await _mediator.Send(bookListCmd);
        dtg_BookList.AutoGenerateColumns = false;
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
}