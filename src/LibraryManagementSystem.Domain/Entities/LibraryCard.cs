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

    public LibraryCard(Guid id, string name, DateTime birthDay, string address, string email, string typeOfReader,
        DateTime creationDate) : base(id)
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

    public string Name { get; set; }
    public DateTime BirthDay { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public DateTime CreationDate { get; set; }

    //because readers only have 2 types and no reader type creation function,
    //so I think we don't need to create type of reader entity
    public string TypeOfReader { get; set; }
}