using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities;

/// <summary>
///     Sách
/// </summary>
public class Book : Entity
{
    private Author? _author;

    private BookType? _bookType;

    public string Code { get; }
    public string Name { get; }
    public Author? Author { get; }
    public int Published { get; }
    public DateTime CreateDate { get;  }
    public Publisher? _publisher { get; }
    public Guid PublisherId { get }
    public string Code { get; }
    public Guid TypeId { get; }
    public Guid AuthorId { get; }

    public Book(Guid id,
        string name,
        string code,
        Guid typeId,
        Guid authorId,
        int published,
        DateTime creationDate,
        Guid publisherId)
        : base(id)
    {
        Code = code;
        TypeId = typeId;
        Name = name;
        AuthorId = authorId;
        Published = published;
        CreateDate= creationDate;
        PublisherId = publisherId;
    }

    public Book(string name,
        string code,
        Guid typeId,
        Guid authorId
        int published,
        DateTime creationDate,
        Guid publisherId)
    {
        Code = code;
        TypeId = typeId;
        Name = name;
        AuthorId = authorId;
        Published = published;
        CreateDate= creationDate;
        PublisherId = publisherId;
    }

    public BookType Type
    {
        set => _bookType = value;
        get => _bookType
               ?? throw new InvalidOperationException("Uninitialized property: " + nameof(Type));
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
        get => _author
               ?? throw new InvalidOperationException("Uninitialized property: " + nameof(Publisher));
    }
}