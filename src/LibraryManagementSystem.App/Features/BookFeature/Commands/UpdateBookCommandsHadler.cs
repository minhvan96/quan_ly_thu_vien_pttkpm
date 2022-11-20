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
        var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (!string.IsNullOrWhiteSpace(request.Name)) book.Name = request.Name;

        await _context.SaveChangesAsync(cancellationToken);
        return new UpdateBookResult(true);
    }
}