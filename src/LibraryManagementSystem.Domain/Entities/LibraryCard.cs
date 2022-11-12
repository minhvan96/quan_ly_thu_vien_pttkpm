using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities;

/// <summary>
///     Thẻ độc giả
/// </summary>
public class LibraryCard : Entity
{
    public LibraryCard(string name, DateTime birthDay, string address, string email, string typeOfReader,
        DateTime creationDate)
    {
        Name = name;
        BirthDay = birthDay;
        Address = address;
        Email = email;
        TypeOfReader = typeOfReader;
        CreationDate = creationDate;
    }

    private LibraryCard()
    {
        Name = string.Empty;
        Address = string.Empty;
        Email = string.Empty;
        CreationDate = DateTime.Now;
        TypeOfReader = string.Empty;
    }

    public string Name { get; }
    public DateTime BirthDay { get; }
    public string Address { get; }
    public string Email { get; }
    public DateTime CreationDate { get; }

    //because readers only have 2 types and no reader type creation function,
    //so I think we don't need to create type of reader entity
    public string TypeOfReader { get; }
}