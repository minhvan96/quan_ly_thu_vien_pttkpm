using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities;

/// <summary>
///     Thẻ độc giả
/// </summary>
public class LibraryCard : Entity
{
    private LibraryCard()
    {
        Name = string.Empty;
        Address = string.Empty;
        Email = string.Empty;
        TypeOfReader = string.Empty;
    }
    public LibraryCard(string name, string address, string email, string typeOfReader,  DateTimeOffset? birthDay = null,
         DateTimeOffset? creationDate = null)
    {
        Name = name;
        Address = address;
        Email = email;
        BirthDay = birthDay;
        CreationDate = creationDate;
        TypeOfReader = typeOfReader;
    }

    public LibraryCard(Guid id, string name, DateTimeOffset? birthDay, string address, string email, string typeOfReader,
        DateTimeOffset? creationDate) : base(id)
    {
        Name = name;
        Address = address;
        Email = email;
        BirthDay = birthDay;
        CreationDate = creationDate;
        TypeOfReader = typeOfReader;
    }



    public string Name { get; set; }
    public DateTimeOffset? BirthDay { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public DateTimeOffset? CreationDate { get; set; }

    //because readers only have 2 types and no reader type creation function,
    //so I think we don't need to create type of reader entity
    public string TypeOfReader { get; set; }
}