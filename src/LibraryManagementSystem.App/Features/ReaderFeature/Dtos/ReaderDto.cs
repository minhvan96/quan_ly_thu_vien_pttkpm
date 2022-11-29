namespace LibraryManagementSystem.App.Features.ReaderFeature.Dtos
{
    public class ReaderDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTimeOffset DOB { get; set; }
        public string ReaderType { get; set; }
    }
}
