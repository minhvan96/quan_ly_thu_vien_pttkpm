using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.BorrowBookListFeature.Dtos;
using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Infrastructure.Data;
using LibraryManagementSystem.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
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
        //var booksOfBorrow
        var borrowBooks = await _context.BorrowBooks
            .Include(x => x.Reader)
            .Include(x => x.BorrowBookDetails)
            .Select(x => new BorrowBookListDto
            {
                Id = x.Id,
                ReaderName = x.Reader.Name,
                BorrowDate = x.BorrowDate,
                BookCount = x.BorrowBookDetails.Count,
                Status = x.BorrowBookDetails.Any(b => b.IsReturnBook == false) ? "Chưa Trả Hết" : "Đã Trả Hết"
            })
            .ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
        return borrowBooks;
    }
}
