using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities;

/// <summary>
///     Quy định
/// </summary>
public class LibraryConfiguration : Entity
{
    public LibraryConfiguration()
    {
        Name = string.Empty;
        Value = 10;
    }

    public LibraryConfiguration(string name, int value)
    {
        Name = name;
        Value = value;
    }

    public string Name { get; }
    public int Value { get; }
}