using LibraryManagementSystem.App.Features.BorrowBookListFeature.Queries;
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
        public BorrowVoucherList(IMediator mediator)
        {
            InitializeComponent();
            this._mediator = mediator;
        }

        private async void BorrowVoucherList_Load(object sender, EventArgs e)
        {
            var bookListCmd = new BorrowVoucherListQuery();
            var books = await _mediator.Send(bookListCmd);
        }
    }
}
