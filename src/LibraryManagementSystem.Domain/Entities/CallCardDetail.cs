using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities;

public class CallCardDetail : Entity
{
    public CallCardDetail(Guid calLCardId, Guid bookId)
    {
        CalLCardId = calLCardId;
        BookId = bookId;
    }

    public CallCard? CallCard { get; set; }
    public Guid CalLCardId { get; set; }
    public Book? Book { get; set; }
    public Guid BookId { get; set; }

    public CallCardDetail(Guid id, Guid calLCardId, Guid bookId) : base(id)
    {
        CalLCardId = calLCardId;
        BookId = bookId;
    }
}