using LibraryManagementSystem.App.Features.CallCardFeature.Dtos;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Queries;

public class CallCardQueryHandler : IRequestHandler<CallCardQuery, CallCardDto?>
{
    private readonly LibraryDbContext _context;

    public CallCardQueryHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<CallCardDto?> Handle(CallCardQuery request, CancellationToken cancellationToken)
    {
        var book = await _context.CallCards
           .Include(x => x.CallCardDetails)
           .Include(x => x.LibraryCard)
           .Select(x => new CallCardDto
           {
               Id = x.Id,
               BorrowDate = x.BorrowDateTime,
               LibraryCard = x.LibraryCard,
               LibraryName = x.LibraryCard.Name,
               CallCardDetails = x.CallCardDetails.ToList(),
               BookCount = x.CallCardDetails.Count,
               Status = x.IsReturnBook ? "Đã trả" : "Chưa trả"
           })
            .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        return book;
    }
}