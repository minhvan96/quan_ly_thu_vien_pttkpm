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
            //var bookListCmd = new BorrowVoucherQuery();
            //var books = await _mediator.Send(bookListCmd);

            //dtg_BorrowBookList.AutoGenerateColumns = false;
            //dtg_BorrowBookList.DataSource = books.Items.ToList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(dtg_BorrowBookList.SelectedRows.Count < 1)
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
