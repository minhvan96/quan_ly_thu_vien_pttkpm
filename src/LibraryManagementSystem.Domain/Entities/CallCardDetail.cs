using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    internal class CallCardDetail
    {
        public CallCard? CallCard { get; private set; }
        public Guid CalLCardId { get; private set; }
        public Book? Book { get; private set; }
        public Guid BookId { get; private set; }

        public CallCardDetail(Guid calLCardId, Guid bookId)
        {
            CalLCardId = calLCardId;
            BookId = bookId;
        }
    }
}
