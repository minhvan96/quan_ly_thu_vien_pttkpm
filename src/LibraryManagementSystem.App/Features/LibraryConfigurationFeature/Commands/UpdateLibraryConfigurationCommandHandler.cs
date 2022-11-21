using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Commands;

public class UpdateLibraryConfigurationCommandHandler : IRequestHandler<UpdateLibraryConfigurationCommand, UpdateLibraryConfigurationRequest>
{
    private readonly LibraryDbContext _context;

    public UpdateLibraryConfigurationCommandHandler(LibraryDbContext context)
    {
        _context = context;
    }
    /// <inheritdoc />
    public async Task<UpdateLibraryConfigurationRequest> Handle(UpdateLibraryConfigurationCommand request, CancellationToken cancellationToken)
    {
        var configuration = await _context.LibraryConfigurations
            .FirstOrDefaultAsync(x => x.Code == request.Code, cancellationToken);

        if (configuration is null)
            return new UpdateLibraryConfigurationRequest(false);
        
        if (!string.IsNullOrWhiteSpace(request.Name))
            configuration.Name = request.Name;
        if (request.Value is not null)
            configuration.Value = (int)request.Value;

        await _context.SaveChangesAsync(cancellationToken);
        return new UpdateLibraryConfigurationRequest(true);
    }
}