using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.BookFeature.Dtos;

namespace LibraryManagementSystem.App.Features.BookFeature.Queries;

public class ListBooksQuery : ListQuery<BookDto>
{
    public SearchBookOptions SearchOption { get; init; }

    public string SearchCriteria { get; init; } = string.Empty; // text
}

[Flags]
public enum SearchBookOptions
{
    None = 0,
    BookName = 1,
    TypeName = 2,
    AuthorName = 4,
    All = BookName | TypeName | AuthorName
}