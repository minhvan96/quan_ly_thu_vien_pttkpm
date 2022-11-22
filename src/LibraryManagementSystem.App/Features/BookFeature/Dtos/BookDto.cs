namespace LibraryManagementSystem.App.Features.BookFeature.Dtos;

public record BookDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Code { get; init; } = string.Empty;
    public string TypeName { get; init; } = string.Empty;
    public string Author { get; init; } = string.Empty;
}