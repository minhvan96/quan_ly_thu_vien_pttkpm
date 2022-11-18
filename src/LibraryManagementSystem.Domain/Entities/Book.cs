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
        Code = string.Empty;
    }
    
    public Book(Guid id,
        string name,
        string code,
        Guid bookTypeId,
        Guid authorId,
        Guid publisherId,
        int published)
        : base(id)
    {
        Code = code;
        BookTypeId = bookTypeId;
        Name = name;
        AuthorId = authorId;
        Published = published;
        PublisherId = publisherId;
    }

    public Book(string name,
        string code,
        Guid bookTypeId,
        Guid authorId,
        Guid publisherId,
        int published)
    {
        Code = code;
        BookTypeId = bookTypeId;
        Name = name;
        AuthorId = authorId;
        Published = published;
        PublisherId = publisherId;
    }

    public string Name { get; set; }
    public int Published { get; set; }
    public string Code { get; set; }
    public Guid PublisherId { get; set; }
    public Guid BookTypeId { get; set; }
    public Guid AuthorId { get; set; }

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