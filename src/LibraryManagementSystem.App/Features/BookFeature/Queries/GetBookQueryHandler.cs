using LibraryManagementSystem.App.Features.BookFeature.Dtos;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.App.Features.BookFeature.Queries;

public class GetBookQueryHandler : IRequestHandler<GetBookQuery, BookDto?>
{
    private readonly LibraryDbContext _context;

    public GetBookQueryHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<BookDto?> Handle(GetBookQuery request, CancellationToken cancellationToken)
    {
        var book = await _context.Books
            .Include(x => x.BookType)
            .Include(x => x.Author)
            .Select(x => new BookDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Author = x.Author.Name,
                Type = x.BookType.Name
            })
            .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        return book;
    }
}