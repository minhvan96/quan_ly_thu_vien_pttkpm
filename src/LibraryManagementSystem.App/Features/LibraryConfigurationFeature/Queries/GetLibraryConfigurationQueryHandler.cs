using LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Dtos;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Queries;

public class
    GetLibraryConfigurationQueryHandler : IRequestHandler<GetLibraryConfigurationQuery, LibraryConfigurationDto>
{
    private readonly LibraryDbContext _context;

    public GetLibraryConfigurationQueryHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<LibraryConfigurationDto> Handle(GetLibraryConfigurationQuery request,
        CancellationToken cancellationToken)
    {
        var configuration = await _context.LibraryConfigurations
            .Select(configuration => new LibraryConfigurationDto
            {
                Id = configuration.Id,
                Name = configuration.Name,
                Code = configuration.Code,
                Value = configuration.Value
            })
            .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        return configuration ?? new LibraryConfigurationDto();
    }
}