using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.BookFeature.Queries;
using LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Dtos;
using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Infrastructure.Data;
using LibraryManagementSystem.Infrastructure.Database;
using LinqKit;
using System.Linq.Expressions;

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
        Expression<Func<LibraryConfiguration, bool>> searchPredicate = PredicateBuilder.New<LibraryConfiguration>(true);
        if (!string.IsNullOrWhiteSpace(request.SearchCriteria))
        {
            Expression<Func<LibraryConfiguration, bool>> searchByConfigurationCodePredicate =
                configuration => configuration.Code.Contains(request.SearchCriteria);
            Expression<Func<LibraryConfiguration, bool>> searchByConfigurationNamePredicate 
                = configuration => configuration.Name.Contains(request.SearchCriteria);
            if ((request.SearchOption & SearchConfigurationOptions.All) == SearchConfigurationOptions.All)
            {
                searchPredicate = searchPredicate.BuildSearchPredicate(searchByConfigurationNamePredicate,
                    searchByConfigurationCodePredicate);
            }
            else
            {
                if ((request.SearchOption & SearchConfigurationOptions.ConfigurationCode) ==
                    SearchConfigurationOptions.ConfigurationCode)
                    searchPredicate = searchPredicate.BuildSearchPredicate(searchByConfigurationCodePredicate);
                if ((request.SearchOption & SearchConfigurationOptions.ConfigurationName) ==
                    SearchConfigurationOptions.ConfigurationName)
                    searchPredicate = searchPredicate.BuildSearchPredicate(searchByConfigurationNamePredicate);
            }
        }
        var configurations = await _context.LibraryConfigurations
            .Where(searchPredicate)
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