using LibraryManagementSystem.App.Features.BookFeature.Queries;
using LibraryManagementSystem.App.Features.BookTypeFeature.Queries;
using MediatR;
using System.Data;

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

        private async void BookMenu_ManageBookPage_Enter(object sender, EventArgs e)
        {
            #region LOAD BOOK TYPES

            var bookTypes = await _mediator.Send(new ListBookTypesQuery());
            var bookTypesDataTable = new DataTable();
            var bookTypeIdColumn = new DataColumn("Id", typeof(Guid));
            var bookTypeNameColumn = new DataColumn("Name", typeof(string));
            var bookTypesDataTableAllTypes = bookTypesDataTable;

            bookTypesDataTable.Columns.Add(bookTypeIdColumn);
            bookTypesDataTable.Columns.Add(bookTypeNameColumn);
            bookTypesDataTableAllTypes.Rows.Add(Guid.Empty, "Tất cả thể loại");
            foreach (var bookType in bookTypes.Items)
            {
                bookTypesDataTable.Rows.Add(bookType.Id, bookType.Name);
            }
            BookManager_BookTypeCbb.DataSource = bookTypesDataTableAllTypes;
            BookManager_BookTypeCbb.DisplayMember = "Name";
            BookManager_BookTypeCbb.ValueMember = "Id";

            #endregion LOAD BOOK TYPES
        }

        private void BookManager_AddBookButton_Click(object sender, EventArgs e)
        {

        }
    }
}
