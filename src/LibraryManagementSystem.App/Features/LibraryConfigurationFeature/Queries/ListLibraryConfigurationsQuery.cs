using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Dtos;

namespace LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Queries;

public class ListLibraryConfigurationsQuery : ListQuery<LibraryConfigurationDto>
{
    public SearchConfigurationOptions SearchOption { get; init; }

    public string SearchCriteria { get; init; } = string.Empty; // text
}

[Flags]
public enum SearchConfigurationOptions
{
    None = 0,
    ConfigurationCode = 1,
    ConfigurationName = 2,
    All = ConfigurationCode | ConfigurationName
}