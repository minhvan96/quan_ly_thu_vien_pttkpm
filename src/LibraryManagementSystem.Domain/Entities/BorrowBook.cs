using LibraryManagementSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class BorrowBook : Entity
    {
        public Guid ReaderId { get; set; }
        public Guid BookId { get; set; }
        public DateTimeOffset BorrowDate { get; set; }
        public bool IsReturnBook { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        private BorrowBook()
        {
        }

        public BorrowBook(Guid readerId, Guid bookId, DateTimeOffset borrowDate, DateTimeOffset createDate, bool isReturnBook)
        {
            this.ReaderId = readerId;
            this.BookId = bookId;
            this.BorrowDate = borrowDate;
            this.CreatedDate = createDate;
            this.IsReturnBook = isReturnBook;
        }

        public BorrowBook(Guid id, Guid readerId, Guid bookId, DateTimeOffset borrowDate, DateTimeOffset createDate, bool isReturnBook)
            : base(id)
        {
            this.ReaderId = readerId;
            this.BookId = bookId;
            this.BorrowDate = borrowDate;
            this.CreatedDate = createDate;
            this.IsReturnBook = isReturnBook;
        }

        private Book? _book;
        private Reader? _reader;

        public Book Book
        {
            set => _book = value;
            get => _book
                   ?? throw new InvalidOperationException("Uninitialized property: " + nameof(Book));
        }
        
        public Reader Reader
        {
            set => _reader = value;
            get => _reader
                   ?? throw new InvalidOperationException("Uninitialized property: " + nameof(Reader));
        }
    }
}
