using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities;

/// <summary>
///     Sách
/// </summary>
public class Book : Entity
{
    private Author? _author;

    private BookType? _bookType;

    private Book()
    {
        Name = string.Empty;
        Code = string.Empty;
    }

    public Book(string name,
        string code,
        Guid typeId,
        Guid authorId)
    {
        Code = code;
        TypeId = typeId;
        Name = name;
        AuthorId = authorId;
    }

    public BookType Type
    {
        set => _bookType = value;
        get => _bookType
               ?? throw new InvalidOperationException("Uninitialized property: " + nameof(Type));
    }

    public string Code { get; }
    public string Name { get; }
    public Guid TypeId { get; }

    public Author Author
    {
        set => _author = value;
        get => _author
               ?? throw new InvalidOperationException("Uninitialized property: " + nameof(Author));
    }

    public Guid AuthorId { get; }
}