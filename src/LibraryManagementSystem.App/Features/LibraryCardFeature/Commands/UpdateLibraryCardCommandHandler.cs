using LibraryManagementSystem.App.Features.BookFeature.Commands;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.App.Features.LibraryCardFeature.Commands;

public class UpdateLibraryCardCommandHandler : IRequestHandler<UpdateLibraryCardCommand, UpdateLibraryCardResult>
{
    private readonly LibraryDbContext _context;

    public UpdateLibraryCardCommandHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<UpdateLibraryCardResult> Handle(UpdateLibraryCardCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var reader = await _context.LibraryCards.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            reader.Name = request.Name;
            reader.Address = request.Address;
            reader.Email = request.Email;
            reader.TypeOfReader = request.TypeOfReader;
            reader.CreationDate = request.CreationDate;
            reader.BirthDay = request.BirthDay;


            await _context.SaveChangesAsync(cancellationToken);
            return new UpdateLibraryCardResult(true);
        }
        catch (Exception ex)
        {
            return new UpdateLibraryCardResult(false);
        }
    }
}