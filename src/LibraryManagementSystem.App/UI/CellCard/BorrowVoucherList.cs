using LibraryManagementSystem.App.Features.CallCardFeature.Commands;
using LibraryManagementSystem.App.Features.CallCardFeature.Dtos;
using LibraryManagementSystem.App.Features.CallCardFeature.Queries;
using MediatR;

namespace LibraryManagementSystem.App
{
    public partial class BorrowVoucherList : UserControl
    {
        private readonly IMediator _mediator;
        private readonly TabPage _pageMain;
        private List<CallCardDto> _callCardList;

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
            _callCardList = callCards.Items.ToList();
            dtg_BorrowBookList.DataSource = _callCardList;
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

        private async void btn_DeleteCallCard_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu mượn này không!", "Xác nhận xóa", MessageBoxButtons.YesNo);
            var bookSelectedRow = dtg_BorrowBookList.SelectedRows[0];
            var borrowBookId = new Guid(bookSelectedRow.Cells["Id"].Value.ToString());

            if (confirmDelete == DialogResult.Yes)
            {
                var callCard = new CallCardDeleteCommand()
                {
                    CallCardId = borrowBookId
                };
                try
                {
                    await _mediator.Send(callCard);
                    MessageBox.Show("Xóa thành công!");

                    var callCardDeletedInd = _callCardList.FindIndex(x => x.Id == borrowBookId);
                    _callCardList.RemoveAt(callCardDeletedInd);
                    dtg_BorrowBookList.DataSource = new BindingSource(_callCardList, "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!");
                }
            }
            else
            {
                return;
            }
        }

        private async void btn_returnBook_Click(object sender, EventArgs e)
        {
            var confirmReturn = MessageBox.Show("Xác nhận trả sách!", "Xác nhận", MessageBoxButtons.YesNo);
            var bookSelectedRow = dtg_BorrowBookList.SelectedRows[0];
            var borrowBookId = new Guid(bookSelectedRow.Cells["Id"].Value.ToString());

            if (confirmReturn == DialogResult.Yes)
            {
                var callCard = new ReturnBookCommand()
                {
                    CallCardId = borrowBookId
                };
                try
                {
                    await _mediator.Send(callCard);
                    MessageBox.Show("Trả sách thành công!");

                    var callCardDeletedInd = _callCardList.Where(x => x.Id == borrowBookId).FirstOrDefault();
                    callCardDeletedInd.Status = "Đã trả";

                    dtg_BorrowBookList.DataSource = new BindingSource(_callCardList, "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!");
                }
            }
            else
            {
                return;
            }
        }
    }
}
