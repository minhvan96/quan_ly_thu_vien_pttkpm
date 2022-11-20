namespace LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Dtos;

public record LibraryConfigurationDto
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Code { get; init; }
    public int Value { get; init; }
}