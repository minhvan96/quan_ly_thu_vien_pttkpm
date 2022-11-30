namespace LibraryManagementSystem.App.Features.BookTypeFeature.Dtos;

public record BookTypeDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
}