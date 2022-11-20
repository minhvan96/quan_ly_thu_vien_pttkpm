using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Dtos;
using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Infrastructure.Data;
using LibraryManagementSystem.Infrastructure.Database;

namespace LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Queries;

public class ListLibraryConfigurationsQueryHandler : IListQueryHandler<ListLibraryConfigurationsQuery,LibraryConfigurationDto>
{
    private readonly LibraryDbContext _context;

    public ListLibraryConfigurationsQueryHandler(LibraryDbContext context)
    {
        _context = context;
    }
    /// <inheritdoc />
    public async Task<IPagedList<LibraryConfigurationDto>> Handle(ListLibraryConfigurationsQuery request, CancellationToken cancellationToken)
    {
        var configurations = await _context.LibraryConfigurations
            .Select(configuration => new LibraryConfigurationDto
            {
                Id = configuration.Id,
                Name = configuration.Name,
                Code = configuration.Code,
                Value = configuration.Value
            })
            .ToPagedListAsync(request.PageIndex, request.PageSize,1, cancellationToken);
        return configurations;
    }
}