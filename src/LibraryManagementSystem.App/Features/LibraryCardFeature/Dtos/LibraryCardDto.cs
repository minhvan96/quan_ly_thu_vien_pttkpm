namespace LibraryManagementSystem.App.Features.LibraryCardFeature.Dtos
{
    public class LibraryCardDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime CreationDate { get; set; }
        public string TypeOfReader { get; set; }
    }
}

