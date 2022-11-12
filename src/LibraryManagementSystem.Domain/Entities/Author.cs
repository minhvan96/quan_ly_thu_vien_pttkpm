using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities;

/// <summary>
///     Tác giả
/// </summary>
public class Author : Entity
{
    private Author()
    {
        Name = string.Empty;
    }

    public Author(string name)
    {
        Name = name;
    }

    public Author(Guid id, string name)
        : base(id)
    {
        Name = name;
    }

    public string Name { get; }
}