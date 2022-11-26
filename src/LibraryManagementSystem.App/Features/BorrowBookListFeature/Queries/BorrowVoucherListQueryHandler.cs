using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.BorrowBookListFeature.Dtos;
using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.BorrowBookListFeature.Queries;

public class BorrowVoucherListQueryHandler : IListQueryHandler<BorrowVoucherListQuery, BorrowBookListDto>
{
    private readonly LibraryDbContext _context;

    public BorrowVoucherListQueryHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<IPagedList<BorrowBookListDto>> Handle(BorrowVoucherListQuery request, CancellationToken cancellationToken)
    {
        //var books = await _context.BorrowBooks
        //    .GroupBy(x => new { Reader = x.Reader, BookFeature = x.Book, BorrowDate = x.BorrowDate})
        //    .Select( x => x.Key.)
        //    .Select(x => new Books
        //    {
        //        Id = x.Id,
        //        Reader = x.Reader,
        //        Books = 
        //    })
        //    .ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
        return null;
    }
}
