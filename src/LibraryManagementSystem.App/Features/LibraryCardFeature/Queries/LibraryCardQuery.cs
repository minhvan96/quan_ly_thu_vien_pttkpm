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
    ReaderName = 1,
    TypeName = 2,
    Email = 4,
    Address = 8,
    All = ReaderName | TypeName | Email | Address
}