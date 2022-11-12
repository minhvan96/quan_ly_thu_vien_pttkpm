using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities;

/// <summary>
///     Quy định
/// </summary>
public class LibraryConfiguration : Entity
{
    public string Name { get; private set; }
    public int Value { get; private set; }
    public LibraryConfiguration() { 
        Name = string.Empty;
        Value = 10;
    }

    public LibraryConfiguration(string name, int value)
    {
        Name = name;
        Value = value;
    }
}