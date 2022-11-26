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
        public DateTimeOffset BorrowDate { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        private BorrowBook()
        {
        }

        public BorrowBook(Guid readerId, DateTimeOffset borrowDate, DateTimeOffset createDate)
        {
            this.ReaderId = readerId; 
            this.BorrowDate = borrowDate;
            this.CreatedDate = createDate; 
        }

        public BorrowBook(Guid id, Guid readerId, DateTimeOffset borrowDate, DateTimeOffset createDate)
            : base(id)
        {
            this.ReaderId = readerId; 
            this.BorrowDate = borrowDate;
            this.CreatedDate = createDate; 
        } 

        private Reader? _reader; 
        
        public Reader Reader
        {
            set => _reader = value;
            get => _reader
                   ?? throw new InvalidOperationException("Uninitialized property: " + nameof(Reader));
        }
    }
}
