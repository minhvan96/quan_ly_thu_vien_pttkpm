using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.CallCardFeature.Dtos;
using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Infrastructure.Data;
using LibraryManagementSystem.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Queries;

public class CallCardListQueryHandler : IListQueryHandler<CallCardListQuery, CallCardDto>
{
    private readonly LibraryDbContext _context;

    public CallCardListQueryHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<IPagedList<CallCardDto>> Handle(CallCardListQuery request, CancellationToken cancellationToken)
    {
        var result = await _context.CallCards
            .Include(x => x.CallCardDetails)
            .Include(x => x.LibraryCard)
            .Select(x => new CallCardDto
            {
                Id = x.Id,
                BorrowDate = x.BorrowDate,
                LibraryCard = x.LibraryCard,
                CallCardDetails = x.CallCardDetails.ToList(),
                BookCount = x.CallCardDetails.Count,
                //Status = x.CallCardDetails.Count > 0? "
            })
            .ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
        return result;
    }
}

