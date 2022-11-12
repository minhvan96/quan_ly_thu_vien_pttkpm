using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities;

/// <summary>
///     Loại sách, thể loại
/// </summary>
public class BookType : Entity
{
    private BookType()
    {
        Name = string.Empty;
    }

    public BookType(Guid id, string name)
        : base(id)
    {
        Name = name;
    }

    public BookType(string name)
    {
        Name = name;
    }

    public string Name { get; }
}