using LibraryManagementSystem.App.Features.BookFeature.Commands;
using LibraryManagementSystem.App.Features.BookFeature.Queries;
using LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Commands;
using LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Queries;
using LibraryManagementSystem.App.UI.Book;
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
            var myUserControl = new MakeBorrowVoucher(_mediator);
            myUserControl.Dock = DockStyle.Fill;
            MakeBorrow.Controls.Clear();
            MakeBorrow.Controls.Add(myUserControl);
        }
        else if (tabPage.Name == "BorrowBookList")
        {
            // show UI make borrow voucher
            var myUserControl = new BorrowVoucherList(_mediator, BorrowBookList);
            myUserControl.Dock = DockStyle.Fill;
            BorrowBookList.Controls.Clear();
            BorrowBookList.Controls.Add(myUserControl);
        }
        else if (tabPage.Name == "STC_BookTP")
        {
            // show UI make borrow voucher
            var myUserControl = new BookUI(_mediator, BorrowBookList);
            myUserControl.Dock = DockStyle.Fill;
            STC_BookTP.Controls.Clear();
            STC_BookTP.Controls.Add(myUserControl);
        }
    }

    private void LibraryManagementSystemUI_Load(object sender, EventArgs e)
    {
    }

    private async void LibraryConfigurationSearchButton_Click(object sender, EventArgs e)
    {
        var searchOptions = SearchConfigurationOptions.None;
        if (SearchConfigurationByCodeCheckBox.Checked)
            searchOptions |= SearchConfigurationOptions.ConfigurationCode;
        if (SearchConfigurationByNameCheckBox.Checked)
            searchOptions |= SearchConfigurationOptions.ConfigurationName;
        var listLibraryConfigurationsQuery = new ListLibraryConfigurationsQuery
        {
            SearchCriteria = SearchConfigurationSearchCriteriaTextBox.Text,
            SearchOption = searchOptions
        };
        var configurations = await _mediator.Send(listLibraryConfigurationsQuery);

        LibraryConfigurationDataGridView.Rows.Clear();
        foreach (var configuration in configurations.Items)
        {
            var configurationGridViewRow = new DataGridViewRow();
            configurationGridViewRow.CreateCells(LibraryConfigurationDataGridView);
            configurationGridViewRow.Cells[0].Value = configuration.Code;
            configurationGridViewRow.Cells[1].Value = configuration.Name;
            configurationGridViewRow.Cells[2].Value = configuration.Value;
            LibraryConfigurationDataGridView.Rows.Add(configurationGridViewRow);
        }
    }

    private async void LibraryConfigurationDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            if (e.RowIndex == -1)
                return;
            var name = string.Empty;
            int? value = null;
            switch (e.ColumnIndex)
            {
                case 1:
                    name = LibraryConfigurationDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    break;
                case 2:
                    value = int.Parse(LibraryConfigurationDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value
                        .ToString() ?? string.Empty);
                    break;
            }

            var updateLibraryConfigurationCommand = new UpdateLibraryConfigurationCommand
            {
                Code = (string)LibraryConfigurationDataGridView.Rows[e.RowIndex].Cells[0].Value,
                Name = name,
                Value = value
            };
            var result = await _mediator.Send(updateLibraryConfigurationCommand);
            const string title = "UPDATE STATUS";
            var message = "Update Data Successfully";
            if (!result.Success) message = "Update data has failed";

            MessageBox.Show(message, title);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error");
        }
    }
}