using LibraryManagementSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class BorrowBookDetail : Entity
    {
        public Guid BookId { get; set; }
        public bool IsReturnBook { get; set; }
        public Guid BorrowBookId{ get; set; }
        public DateTimeOffset? ReturnDate { get; set; }

        private BorrowBookDetail()
        {
        }

        public BorrowBookDetail(Guid bookId, DateTimeOffset? returnDate, bool isReturnBook, Guid borrowBookId)
        {
            this.BookId = bookId;
            this.ReturnDate = returnDate;
            this.IsReturnBook = isReturnBook;
            this.BorrowBookId = borrowBookId;
        }

        public BorrowBookDetail(Guid id, Guid bookId, DateTimeOffset? returnDate, bool isReturnBook, Guid borrowBookId)
            : base(id)
        {
            this.BookId = bookId;
            this.ReturnDate = returnDate;
            this.IsReturnBook = isReturnBook;
            this.BorrowBookId = borrowBookId;
        }

        private Book? _book;
        private BorrowBook? _borrowBook;

        public Book Book
        {
            set => _book = value;
            get => _book
                   ?? throw new InvalidOperationException("Uninitialized property: " + nameof(Book));
        }
        
        public BorrowBook BorrowBook
        {
            set => _borrowBook = value;
            get => _borrowBook
                   ?? throw new InvalidOperationException("Uninitialized property: " + nameof(BorrowBook));
        } 
    }
}
