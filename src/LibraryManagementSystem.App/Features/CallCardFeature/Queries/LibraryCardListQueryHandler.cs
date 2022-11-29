using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.CallCardFeature.Dtos;
using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Infrastructure.Data;
using LibraryManagementSystem.Infrastructure.Database;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Queries;

public class LibraryCardListQueryHandler : IListQueryHandler<LibraryCardListQuery, LibraryCardDto>
{
    private readonly LibraryDbContext _context;

    public LibraryCardListQueryHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<IPagedList<LibraryCardDto>> Handle(LibraryCardListQuery request, CancellationToken cancellationToken)
    {
        var result = await _context.LibraryCards
            .Select(x => new LibraryCardDto
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                BirthDay = x.BirthDay,
                Email = x.Email,
                TypeOfReader = x.TypeOfReader,
            })
            .ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
        return result;
    }
}
