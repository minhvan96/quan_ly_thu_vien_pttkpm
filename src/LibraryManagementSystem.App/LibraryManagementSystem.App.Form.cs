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

    private void SystemMainTabControl_Selected(object sender, TabControlEventArgs e)
    {
        var tabControl = (TabControl)sender;
        var tabPage = tabControl.SelectedTab;
        switch (tabPage.Name)
        {
            case "MakeBorrow":
            {
                // show UI make borrow voucher
                var myUserControl = new MakeBorrowVoucher(_mediator);
                myUserControl.Dock = DockStyle.Fill;
                MakeBorrow.Controls.Clear();
                MakeBorrow.Controls.Add(myUserControl);
                break;
            }
            case "BorrowBookList":
            {
                // show UI borrow book list
                var myUserControl = new BorrowVoucherList(_mediator, BorrowBookList);
                myUserControl.Dock = DockStyle.Fill;
                BorrowBookList.Controls.Clear();
                BorrowBookList.Controls.Add(myUserControl);
                break;
            }
            case "STC_BookTP":
            {
                // show UI book management page
                var myUserControl = new BookUI(_mediator, BorrowBookList);
                myUserControl.Dock = DockStyle.Fill;
                STC_BookTP.Controls.Clear();
                STC_BookTP.Controls.Add(myUserControl);
                break;
            }
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