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
        Code = string.Empty;
        Value = 10;
    }
    public LibraryConfiguration(Guid id,
        string name,
        string code,
        int value)
        :base(id)
    {
        Name = name;
        Code = code;
        Value = value;
    }
    public LibraryConfiguration(string name,
        string code,
        int value)
    {
        Name = name;
        Code = code;
        Value = value;
    }

    public string Code { get;  }
    public string Name { get; }
    public int Value { get; }
}