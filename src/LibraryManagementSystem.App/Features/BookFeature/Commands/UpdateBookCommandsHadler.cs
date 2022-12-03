using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.App.Features.BookFeature.Commands;

internal class UpdateBookCommandsHadler : IRequestHandler<UpdateBookCommand, UpdateBookResult>
{
    private readonly LibraryDbContext _context;

    public UpdateBookCommandsHadler(LibraryDbContext context)
    {
        _context = context;
    }

    public async Task<UpdateBookResult> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            book.Name = request.Name;
            book.AuthorId = request.AuthorId;
            book.InStock = request.quantily;
            book.BookTypeId = request.TypeId;
            book.PublisherId = request.PublisherId;
            book.Published = request.Published;

            await _context.SaveChangesAsync(cancellationToken);
            return new UpdateBookResult(true);
        }catch (Exception ex)
        {
            return new UpdateBookResult(false);
        }
    }
}