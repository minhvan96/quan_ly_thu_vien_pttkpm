using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.BookTypeFeature.Dtos;
using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Infrastructure.Data;
using LibraryManagementSystem.Infrastructure.Database;

namespace LibraryManagementSystem.App.Features.BookTypeFeature.Queries;

public class ListBookTypesQueryHandler : IListQueryHandler<ListBookTypesQuery,BookTypeDto>
{
    private readonly LibraryDbContext _context;

    public ListBookTypesQueryHandler(LibraryDbContext context)
    {
        _context = context;
    }
    /// <inheritdoc />
    public async Task<IPagedList<BookTypeDto>> Handle(ListBookTypesQuery request, CancellationToken cancellationToken)
    {
        var bookTypes = await _context.BookTypes
            .Select(bookType => new BookTypeDto
            {
                Id = bookType.Id,
                Name = bookType.Name
            }).ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
        return bookTypes;
    }
}