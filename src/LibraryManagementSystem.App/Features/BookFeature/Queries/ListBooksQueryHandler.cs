using System.Linq.Expressions;
using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.BookFeature.Dtos;
using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Infrastructure.Data;
using LibraryManagementSystem.Infrastructure.Database;
using LinqKit;

namespace LibraryManagementSystem.App.Features.BookFeature.Queries;

public class ListBooksQueryHandler : IListQueryHandler<ListBooksQuery, BookDto>
{
    private readonly LibraryDbContext _context;

    public ListBooksQueryHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<IPagedList<BookDto>> Handle(ListBooksQuery request, CancellationToken cancellationToken)
    {
        Expression<Func<Book, bool>> searchPredicate = PredicateBuilder.New<Book>(true);
        if (!string.IsNullOrWhiteSpace(request.SearchCriteria))
        {
            Expression<Func<Book, bool>> searchByBookNamePredicate = book => book.Name.Contains(request.SearchCriteria);
            Expression<Func<Book, bool>> searchByAuthorNamePredicate =
                book => book.Author.Name.Contains(request.SearchCriteria);
            Expression<Func<Book, bool>> searchByTypeNamePredicate =
                book => book.BookType.Name.Contains(request.SearchCriteria);
            if ((request.SearchOption & SearchBookOptions.All) == SearchBookOptions.All)
            {
                searchPredicate = searchPredicate.BuildSearchPredicate(searchByBookNamePredicate,
                    searchByAuthorNamePredicate,
                    searchByTypeNamePredicate);
            }
            else
            {
                if ((request.SearchOption & SearchBookOptions.BookName) ==
                    SearchBookOptions.BookName)
                    searchPredicate = searchPredicate.BuildSearchPredicate(searchByBookNamePredicate);
                if ((request.SearchOption & SearchBookOptions.AuthorName) ==
                    SearchBookOptions.AuthorName)
                    searchPredicate = searchPredicate.BuildSearchPredicate(searchByAuthorNamePredicate);
                if ((request.SearchOption & SearchBookOptions.TypeName) ==
                    SearchBookOptions.TypeName)
                    searchPredicate = searchPredicate.BuildSearchPredicate(searchByTypeNamePredicate);
            }
        }

        var books = await _context.Books.Where(searchPredicate)
            .Select(x => new BookDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Author = x.Author.Name,
                Type = x.BookType.Name
            })
            .ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
        return books;
    }
}