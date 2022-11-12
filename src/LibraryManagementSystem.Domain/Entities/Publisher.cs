using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities;

/// <summary>
///     Nhà xuất bản
/// </summary>
public class Publisher : Entity
{
    private Publisher()
    {
        Name = string.Empty;
    }

    public Publisher(Guid id,
        string name)
        : base(id)
    {
        Name = name;
    }

    public string Name { get; }
}