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

    public Publisher(string name)
    {
        Name = name;
    }

    public string Name { get; }
}