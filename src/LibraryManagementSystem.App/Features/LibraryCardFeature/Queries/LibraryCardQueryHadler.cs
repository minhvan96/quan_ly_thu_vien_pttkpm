using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.LibraryCardFeature.Dtos;
using LibraryManagementSystem.App.Features.LibraryCardFeature.Queries;
using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Infrastructure.Data;
using LibraryManagementSystem.Infrastructure.Database;

namespace LibraryManagementSystem.App.Features.ReaderFeature.Queries;

//internal class ListReaderQueryHadler
//{
//}


public class LibraryCardQueryHadler : IListQueryHandler<LibraryCardQuery, LibraryCardDto>
{
    private readonly LibraryDbContext _context;

    public LibraryCardQueryHadler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<IPagedList<LibraryCardDto>> Handle(LibraryCardQuery request, CancellationToken cancellationToken)
    {
        var reader = await _context.LibraryCards
            //.Where(x => x)
            .Select(x => new LibraryCardDto
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                BirthDay = x.BirthDay,
                Email = x.Email,
                TypeOfReader = x.TypeOfReader
            })
            .ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
        return reader;
    }
}
