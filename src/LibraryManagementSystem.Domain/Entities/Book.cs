using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities;

/// <summary>
///     Sách
/// </summary>
public class Book : Entity
{
    private Author? _author;
    private BookType? _bookType;
    private Publisher? _publisher;

    private Book()
    {
        Name = string.Empty;
    }

    public Book(Guid id,
        string name,
        Guid bookTypeId,
        Guid authorId,
        Guid publisherId,
        int inStock,
        int publishYear,
        DateTimeOffset? entryDate = null)
        : base(id)
    {
        BookTypeId = bookTypeId;
        Name = name;
        AuthorId = authorId;
        EntryDate = entryDate;
        PublisherId = publisherId;
        InStock = inStock;
        PublishYear = publishYear;
    }

    public Book(string name,
        Guid bookTypeId,
        Guid authorId,
        Guid publisherId,
        DateTimeOffset? entryDate = null)
    {
        BookTypeId = bookTypeId;
        Name = name;
        AuthorId = authorId;
        EntryDate = entryDate;
        PublisherId = publisherId;
    }

    public Book(string name,
        Guid bookTypeId,
        Guid authorId,
        Guid publisherId,
        int inStock,
        DateTimeOffset? entryDate = null)
    {
        BookTypeId = bookTypeId;
        Name = name;
        AuthorId = authorId;
        EntryDate = entryDate;
        PublisherId = publisherId;
        InStock = inStock;
    }

    public Book(string name,
        Guid bookTypeId,
        Guid authorId,
        Guid publisherId,
        int inStock,
        int publishYear,
        DateTimeOffset? entryDate = null)
    {
        BookTypeId = bookTypeId;
        Name = name;
        AuthorId = authorId;
        EntryDate = entryDate;
        PublisherId = publisherId;
        InStock = inStock;
        PublishYear = publishYear;
    }

    public string Name { get; set; }
    public DateTimeOffset? EntryDate { get; set; }
    public Guid PublisherId { get; set; }
    public Guid BookTypeId { get; set; }
    public Guid AuthorId { get; set; }
    public int InStock { get; set; }
    public int PublishYear { get; set; }

    public BookType BookType
    {
        set => _bookType = value;
        get => _bookType
               ?? throw new InvalidOperationException("Uninitialized property: " + nameof(BookType));
    }


    public Author Author
    {
        set => _author = value;
        get => _author
               ?? throw new InvalidOperationException("Uninitialized property: " + nameof(Author));
    }

    public Publisher Publisher
    {
        set => _publisher = value;
        get => _publisher
               ?? throw new InvalidOperationException("Uninitialized property: " + nameof(Publisher));
    }
}