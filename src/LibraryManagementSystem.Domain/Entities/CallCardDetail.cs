namespace LibraryManagementSystem.Domain.Entities;

internal class CallCardDetail
{
    public CallCardDetail(Guid calLCardId, Guid bookId)
    {
        CalLCardId = calLCardId;
        BookId = bookId;
    }

    public CallCard? CallCard { get; private set; }
    public Guid CalLCardId { get; }
    public Book? Book { get; private set; }
    public Guid BookId { get; }
}