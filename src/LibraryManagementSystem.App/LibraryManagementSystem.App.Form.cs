using LibraryManagementSystem.App.Features.BookFeature.Commands;
using LibraryManagementSystem.App.Features.BookFeature.Queries;
using LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Queries;
using MediatR;

namespace LibraryManagementSystem.App;

public partial class LibraryManagementSystemUI : Form
{
    private readonly IMediator _mediator;

    public LibraryManagementSystemUI(IMediator mediator)
    {
        InitializeComponent();
        _mediator = mediator;
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        //var cmd = new GetBookQuery()
        //{
        //    Id = new Guid("D533958E-328A-4F4D-A71E-84B8A7F6DEC7")
        //};
        //var result = await _mediator.Send(cmd);

        //var cmd = new UpdateBookCommand()
        //{
        //    Id =  new Guid("E9018D7A-21E1-4341-90AF-EC48360112E3"),
        //    Name = "sach updated",
        //    AuthorId = new Guid("c614726e-6236-4479-bcc0-0aa74e50ebf7"),
        //    Code = "nghiadx",
        //    PublisherId = new Guid("8cec176e-0d57-4078-8d93-949b479786ea"),
        //    TypeId = new Guid("fa8a6295-e371-42b8-b20b-1511b632eccf")
        //};
        //var result = await _mediator.Send(cmd);

        // DELETE 
        var cmd = new DeleteBookCommand
        {
            Id = new Guid("E9018D7A-21E1-4341-90AF-EC48360112E3")
        };
        var result = await _mediator.Send(cmd);

        //var cmd = new ListBooksQuery()
        //{
        //    SearchOption = SearchBookOptions.BookName | SearchBookOptions.AuthorName,
        //    SearchCriteria = "Sapiens"
        //};

        //var result = await _mediator.Send(cmd);
        //txtTest.Text = result.Name;


        //var cmdBook = new CreateBookCommand()
        //{
        //    Name = "sach",
        //    AuthorId = new Guid("c614726e-6236-4479-bcc0-0aa74e50ebf7"),
        //    Code = "nghiadx",
        //    PublisherId = new Guid("8cec176e-0d57-4078-8d93-949b479786ea"),
        //    TypeId = new Guid("fa8a6295-e371-42b8-b20b-1511b632eccf")
        //};

        //await _mediator.Send(cmdBook);
    }

    private void SystemMainTabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        //switch(tabPage)
    }

    private void SystemMainTabControl_Selected(object sender, TabControlEventArgs e)
    {
        var tabControl = (TabControl)sender;
        var tabPage = tabControl.SelectedTab;
        if (tabPage.Name == "MakeBorrow")
        {
            // show UI make borrow voucher
            var myUserControl = new MakeBorrowVoucher();
            //myUserControl.Dock = DockStyle.Fill;
            MakeBorrow.Controls.Add(myUserControl);
        }
    }

    private void LibraryManagementSystemUI_Load(object sender, EventArgs e)
    {
    }

    private async void LibraryConfigurationSearchButton_Click(object sender, EventArgs e)
    {
        var listLibraryConfigurationsQuery = new ListLibraryConfigurationsQuery
        {

        };
        var configurations = await _mediator.Send(listLibraryConfigurationsQuery);

        LibraryConfigurationDataGridView.Rows.Clear();
        foreach(var configuration in configurations.Items)
        {

            var configurationGridViewRow = new DataGridViewRow();
            configurationGridViewRow.CreateCells(LibraryConfigurationDataGridView);
            configurationGridViewRow.Cells[0].Value = configuration.Code;
            configurationGridViewRow.Cells[1].Value = configuration.Name;
            configurationGridViewRow.Cells[2].Value = configuration.Value;
            LibraryConfigurationDataGridView.Rows.Add(configurationGridViewRow);
        }
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
            configurationGridViewRow.Cells[2].Value = book.Type;
            configurationGridViewRow.Cells[3].Value = book.Author;
            configurationGridViewRow.Cells[4].Value = "tinh trang";
            BookPageDataGridView.Rows.Add(configurationGridViewRow);

            index++;
        }
    }
}