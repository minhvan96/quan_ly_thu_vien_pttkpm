namespace LibraryManagementSystem.App.Features.CallCardFeature.Dtos;

public class LibraryCardDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTimeOffset? BirthDay { get; set; }
    public DateTimeOffset? CreationDate { get; set; }
public string Address { get; set; }
    public string Email { get; set; }
    public string TypeOfReader { get; set; }
}
