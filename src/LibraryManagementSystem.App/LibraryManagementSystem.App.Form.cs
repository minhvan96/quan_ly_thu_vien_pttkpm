using LibraryManagementSystem.App.Features.AuthorFeature.Dtos;
using LibraryManagementSystem.App.Features.BookFeature.Commands;
using LibraryManagementSystem.App.Features.BookFeature.Dtos;
using LibraryManagementSystem.App.Features.BookFeature.Queries;
using LibraryManagementSystem.App.Features.CallCardFeature.Dtos;
using LibraryManagementSystem.App.Features.LibraryCardFeature.Commands;
using LibraryManagementSystem.App.Features.LibraryCardFeature.Queries;
using LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Commands;
using LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Queries;
using LibraryManagementSystem.App.Features.PubblisherFeature.Dtos;
using LibraryManagementSystem.App.UI.Book;
using MediatR;
using Microsoft.VisualBasic;
using System.Net;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem.App;

public partial class LibraryManagementSystemUI : Form
{
    private readonly IMediator _mediator;
    private List<LibraryCardDto> listReaders;
    private TabPage? pageMain;
    private readonly TabPage _pageMain;

    public LibraryManagementSystemUI(IMediator mediator)
    {
        InitializeComponent();
        _mediator = mediator;
        this._pageMain = pageMain;
        listReaders = new List<LibraryCardDto>();
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
            case "Reader":
            {
                 loadTableReader();
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

    private bool isvalid()
    {
        if (textBoxReaderNameInfo.Text == string.Empty)
        {
            MessageBox.Show("Tên đọc giả đang rỗng");
            return false;
        }

        if (textBoxReaderEmailInfo.Text.Trim() == string.Empty)
        {
            MessageBox.Show("Email không được rỗng");
            return false;
        }

        if (textBoxReaderAddressInfo.Text == string.Empty)
        {
            MessageBox.Show("Địa chỉ đang rỗng");
            return false;
        }



        if (comboBoxReaderType.Text == string.Empty)
        {
            MessageBox.Show("Vui lòng chon loại đọc giả");
            return false;
        }
        return true;
    }

    private async void loadTableReader()
    {
        var listReadersQuery = new LibraryCardQuery
        {
            SearchOption = SearchLibaryCardOptions.None
        };
        var readers = await _mediator.Send(listReadersQuery);

        dataGridViewReader.Rows.Clear();
        dataGridViewReader.Refresh();
        dataGridViewReader.DataSource = null;
        foreach (var reader in readers.Items)
        {
            var configurationGridViewRow = new DataGridViewRow();
            configurationGridViewRow.CreateCells(dataGridViewReader);
            configurationGridViewRow.Cells[0].Value = reader.Id;
            configurationGridViewRow.Cells[1].Value = reader.Name;
            configurationGridViewRow.Cells[2].Value = reader.Address;
            configurationGridViewRow.Cells[3].Value = reader.TypeOfReader;
            configurationGridViewRow.Cells[4].Value = reader.Email;
            configurationGridViewRow.Cells[5].Value = reader.BirthDay;
            configurationGridViewRow.Cells[6].Value = reader.CreationDate;

            dataGridViewReader.Rows.Add(configurationGridViewRow);
        }
    }

    private async void RefreshReader()
    {
        textBoxReaderIdInfo.Text = "";
        textBoxReaderNameInfo.Text = "";
        textBoxReaderAddressInfo.Text = "";
        textBoxReaderEmailInfo.Text = "";
        comboBoxReaderType.Text = "";
        dtpReaderBodInfo.Value = DateTime.Today;
        dtpReaderCreateDate.Value = DateTime.Today;
    }
    private async void buttonReaderAdd_Click(object sender, EventArgs e)
    {
        if (!this.isvalid())
        {
            return;
        }

        var cmdReader = new CreateLibraryCardCommand()
        {
            Name = textBoxReaderNameInfo.Text.Trim(),
            Address = textBoxReaderAddressInfo.Text.Trim(),
            Email = textBoxReaderEmailInfo.Text.ToLower().Trim(),
            TypeOfReader = comboBoxReaderType.Text.Trim(),
            BirthDay = dtpReaderBodInfo.Value,
            CreationDate = dtpReaderCreateDate.Value,
        };

        CreateLibraryCardResult result = await _mediator.Send(cmdReader);
        if (result.Success)
        {
            MessageBox.Show("Thêm đọc giả thành công");
            this.loadTableReader();
        }
        else
        {
            MessageBox.Show("Thêm đọc giả không thành công");
        }
    }

    private async void buttonReaderEdit_Click(object sender, EventArgs e)
    {
        if (!this.isvalid())
        {
            return;
        }
        var cmdReader = new UpdateLibraryCardCommand()
        {
            Id = new Guid(textBoxReaderIdInfo.Text),
            Name = textBoxReaderNameInfo.Text.Trim(),
            Address = textBoxReaderAddressInfo.Text.Trim(),
            Email = textBoxReaderEmailInfo.Text.ToLower().Trim(),
            TypeOfReader = comboBoxReaderType.Text.Trim(),
            BirthDay = dtpReaderBodInfo.Value,
            CreationDate = dtpReaderCreateDate.Value,
        };


        UpdateLibraryCardResult result = await _mediator.Send(cmdReader);
        if (result.Success)
        {
            MessageBox.Show("Edit đọc giả thành công");
            this.loadTableReader();
        }
        else
        {
            MessageBox.Show("Edit đọc giả không thành công");
        }
    }

    private void dataGridViewReader_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1)
            return;

        textBoxReaderIdInfo.Text = dataGridViewReader.Rows[e.RowIndex].Cells[0].Value.ToString();
        textBoxReaderNameInfo.Text = dataGridViewReader.Rows[e.RowIndex].Cells[1].Value.ToString();
        textBoxReaderAddressInfo.Text = dataGridViewReader.Rows[e.RowIndex].Cells[2].Value.ToString();
        comboBoxReaderType.Text = dataGridViewReader.Rows[e.RowIndex].Cells[3].Value.ToString();
        textBoxReaderEmailInfo.Text = dataGridViewReader.Rows[e.RowIndex].Cells[4].Value.ToString();
        dtpReaderBodInfo.Value =  Convert.ToDateTime(dataGridViewReader.Rows[e.RowIndex].Cells[5].Value.ToString());
        dtpReaderCreateDate.Value = Convert.ToDateTime(dataGridViewReader.Rows[e.RowIndex].Cells[6].Value.ToString()); ;
    }

    private void buttonReaderRefresh_Click(object sender, EventArgs e)
    {
        RefreshReader();
    }

    private async void buttonReaderDelete_Click(object sender, EventArgs e)
    {
        DialogResult isDelete = MessageBox.Show("Cảnh báo thao tác này sẽ không thể quay lại, bạn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel);

        if (isDelete == DialogResult.OK)
        {
            var cmd = new DeleteLibraryCardCommand
            {
                Id = new Guid(textBoxReaderIdInfo.Text.Trim())
            };
            var result = await _mediator.Send(cmd);
            if (result.Success)
            {
                MessageBox.Show("Xóa đọc giả thành công");
                this.loadTableReader();
            }
            else
            {
                MessageBox.Show("Xóa đọc giả không thành công");
            }
        }
    }

    private async void buttonReaderSearch_Click(object sender, EventArgs e)
    {
        var searchOptions = SearchLibaryCardOptions.Name;
        //if (textBoxSearchReader.Text != "")
         //   searchOptions = SearchLibaryCardOptions.Name;
        var listLibraryCardQuery = new LibraryCardQuery
        {
            SearchCriteria = textBoxSearchReader.Text,
            SearchOption = searchOptions
        };
        var configurations = await _mediator.Send(listLibraryCardQuery);

        dataGridViewReader.Rows.Clear();
        foreach (var configuration in configurations.Items)
        {
            var configurationGridViewRow = new DataGridViewRow();
            configurationGridViewRow.CreateCells(dataGridViewReader);
            configurationGridViewRow.Cells[0].Value = configuration.Id;
            configurationGridViewRow.Cells[1].Value = configuration.Name;
            configurationGridViewRow.Cells[2].Value = configuration.Address;
            configurationGridViewRow.Cells[3].Value = configuration.TypeOfReader;
            configurationGridViewRow.Cells[4].Value = configuration.Email;
            configurationGridViewRow.Cells[5].Value = configuration.BirthDay;
            configurationGridViewRow.Cells[6].Value = configuration.CreationDate;

            dataGridViewReader.Rows.Add(configurationGridViewRow);


        }
    }
}