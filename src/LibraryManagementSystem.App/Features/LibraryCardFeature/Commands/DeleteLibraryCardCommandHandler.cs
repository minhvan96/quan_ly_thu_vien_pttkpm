using LibraryManagementSystem.App.Features.LibraryCardFeature.Commands;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.App.Features.BookFeature.Commands;

internal class DeleteLibraryCardCommandsHadler : IRequestHandler<DeleteLibraryCardCommand, DeleteLibraryCardResult>
{
    private readonly LibraryDbContext _context;

    public DeleteLibraryCardCommandsHadler(LibraryDbContext context)
    {
        _context = context;
    }

    public async Task<DeleteLibraryCardResult> Handle(DeleteLibraryCardCommand request, CancellationToken cancellationToken)
    {
        var reader = await _context.LibraryCards.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (reader != null) //return new DeleteLibraryCardResult(true); ;
            _context.Remove(reader);

        await _context.SaveChangesAsync(cancellationToken);
        return new DeleteLibraryCardResult(true);
    }
}