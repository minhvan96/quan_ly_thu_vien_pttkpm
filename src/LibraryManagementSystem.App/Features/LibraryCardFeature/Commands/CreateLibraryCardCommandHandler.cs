using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;

namespace LibraryManagementSystem.App.Features.LibraryCardFeature.Commands;

public class CreateLibraryCardCommandHandler : IRequestHandler<CreateLibraryCardCommand, CreateLibraryCardResult>
{
    private readonly LibraryDbContext _context;

    public CreateLibraryCardCommandHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<CreateLibraryCardResult> Handle(CreateLibraryCardCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var newReader = new LibraryCard(
                request.Name,
                request.Address,
                request.Email,
                request.TypeOfReader,
                request.CreationDate,
                request.BirthDay
                );

            var libraryCard = await _context.AddAsync(newReader, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return new CreateLibraryCardResult(newReader, true);
        }
        catch (Exception ex)
        {
            return new CreateLibraryCardResult(null, false);
        }
    }
}