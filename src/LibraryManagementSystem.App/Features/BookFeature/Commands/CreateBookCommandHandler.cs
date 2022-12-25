using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;

namespace LibraryManagementSystem.App.Features.BookFeature.Commands;

public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, CreateBookResult>
{
    private readonly LibraryDbContext _context;

    public CreateBookCommandHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<CreateBookResult> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var newBook = new Book(request.Name,
                request.Code,
                request.TypeId,
                request.AuthorId,
                request.PublisherId,
                request.quantily,
                request.PublishedYear,
                request.EntryDate
                );

            var book = await _context.AddAsync(newBook, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return new CreateBookResult(book.Entity, true);
        }catch(Exception ex)
        {
            return new CreateBookResult(null, false);
        }
    }
}