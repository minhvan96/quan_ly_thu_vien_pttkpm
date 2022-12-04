using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.LibraryCardFeature.Dtos;

namespace LibraryManagementSystem.App.Features.LibraryCardFeature.Queries;
public class LibraryCardQuery : ListQuery<LibraryCardDto>
{
    public SearchLibaryCardOptions SearchOption { get; init; }

    public string SearchCriteria { get; init; } = string.Empty; // text
}

[Flags]
public enum SearchLibaryCardOptions
{
    None = 0,
    Name = 1,
    Email = 2,
    Address = 4,
    All = Name | Email | Address
}