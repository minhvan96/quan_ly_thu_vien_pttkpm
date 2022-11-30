using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.ReaderFeature.Dtos;

namespace LibraryManagementSystem.App.Features.ReaderFeature.Queries;
public class ListReaderQuery : ListQuery<ReaderDto>
{
    public SearchBookOptions SearchOption { get; init; }

    public string SearchCriteria { get; init; } = string.Empty; // text
}

[Flags]
public enum SearchBookOptions
{
    None = 0,
    ReaderName = 1,
    TypeName = 2,
    Email = 4,
    Address = 8,
    All = ReaderName | TypeName | Email | Address
}