using LibraryManagementSystem.App.Features.BookFeature.Queries;
using MediatR;

namespace LibraryManagementSystem.App.UI.Book
{
    public partial class BookUI : UserControl
    {
        private readonly IMediator _mediator;
        private readonly TabPage _pageMain;
        
        public BookUI(IMediator mediator, TabPage pageMain)
        {
            InitializeComponent();
            this._mediator = mediator;
            this._pageMain = pageMain;
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
                configurationGridViewRow.Cells[2].Value = book.TypeName;
                configurationGridViewRow.Cells[3].Value = book.Author;
                configurationGridViewRow.Cells[4].Value = "tinh trang";
                BookPageDataGridView.Rows.Add(configurationGridViewRow);

                index++;
            }
        }
    }
}
