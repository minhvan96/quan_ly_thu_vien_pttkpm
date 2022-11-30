using LibraryManagementSystem.App.Features.CallCardFeature.Queries;
using MediatR;

namespace LibraryManagementSystem.App
{
    public partial class BorrowVoucherList : UserControl
    {
        private readonly IMediator _mediator;
        private readonly TabPage _pageMain;
        public BorrowVoucherList(IMediator mediator, TabPage pageMain)
        {
            InitializeComponent();
            this._mediator = mediator;
            this._pageMain = pageMain;
        }

        private async void BorrowVoucherList_Load(object sender, EventArgs e)
        {
            var callCardListCmd = new CallCardListQuery();
            var callCards = await _mediator.Send(callCardListCmd);

            dtg_BorrowBookList.AutoGenerateColumns = false;
            dtg_BorrowBookList.DataSource = callCards.Items.ToList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dtg_BorrowBookList.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn!.");
                return;
            }

            var bookSelectedRow = dtg_BorrowBookList.SelectedRows[0];
            var borrowBookId = new Guid(bookSelectedRow.Cells["Id"].Value.ToString());
            var myUserControl = new BorrowVoucherEdit(_mediator, _pageMain, borrowBookId);
            myUserControl.Dock = DockStyle.Fill;
            _pageMain.Controls.Clear();
            _pageMain.Controls.Add(myUserControl);
        }
    }
}
