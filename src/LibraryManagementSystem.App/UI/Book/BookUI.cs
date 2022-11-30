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

namespace LibraryManagementSystem.App.UI.Book
{
    public partial class BookUI : UserControl
    {
        private readonly IMediator _mediator;
        private readonly TabPage _pageMain;

        public BookUI()
        {
            InitializeComponent();
        }
        
        public BookUI(IMediator mediator, TabPage pageMain)
        {
            InitializeComponent();
            this._mediator = mediator;
            this._pageMain = pageMain;
        }
    }
}
