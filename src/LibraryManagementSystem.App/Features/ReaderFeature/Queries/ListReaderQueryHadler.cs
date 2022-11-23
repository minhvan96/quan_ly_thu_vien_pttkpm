using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.ReaderFeature.Dtos;
using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Infrastructure.Data;
using LibraryManagementSystem.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.ReaderFeature.Queries;

//internal class ListReaderQueryHadler
//{
//}


public class ListReaderQueryHadler : IListQueryHandler<ListReaderQuery, ReaderDto>
{
    private readonly LibraryDbContext _context;

    public ListReaderQueryHadler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<IPagedList<ReaderDto>> Handle(ListReaderQuery request, CancellationToken cancellationToken)
    {
        var reader = await _context.Readers
            //.Where(x => x)
            .Select(x => new ReaderDto
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                DOB = x.Dob,
                Email = x.Email,
                ReaderType = x.ReaderType
            })
            .ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
        return reader;
    }
}
