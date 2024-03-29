﻿using LibraryManagementSystem.Domain.Constants;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Commands;

public class CallCardCommandHandler : IRequestHandler<CallCardCommand, CallCardResult>
{
    private readonly LibraryDbContext _context;

    public CallCardCommandHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<CallCardResult> Handle(CallCardCommand request, CancellationToken cancellationToken)
    {
        // validate 
        // check library card expiration
        var today = DateTime.Now;
        var configuation = await _context.LibraryConfigurations
            .Where(x => x.Code == LibraryConfigurationConstants.THGTT || x.Code == LibraryConfigurationConstants.SLNMTD
            || x.Code == LibraryConfigurationConstants.SLSMTD)
            .ToListAsync();

        var configTHGTT = configuation.FirstOrDefault(x => x.Code == LibraryConfigurationConstants.THGTT).Value;
        var checkExpirationCard = await _context.LibraryCards
            .Where(x => x.Id == request.LibraryCardId && x.CreationDate.Value.AddMonths(configTHGTT) >= today)
            .FirstOrDefaultAsync();
        if (checkExpirationCard == null) return new CallCardResult(false, "Thẻ đã hết hạn!");

        // check library how many library card (reader) borrowed books in 4 days?
        var configSLNMTD = configuation.FirstOrDefault(x => x.Code == LibraryConfigurationConstants.SLNMTD).Value;
        var configSLSMTD = configuation.FirstOrDefault(x => x.Code == LibraryConfigurationConstants.SLSMTD).Value;

        var bookBorrowed = await _context.CallCards
            .Include(x => x.CallCardDetails)
            .Where(x => x.LibraryCardId == request.LibraryCardId && !x.IsReturnBook 
                && x.BorrowDateTime <= today
                && x.BorrowDateTime.AddDays(configSLNMTD) >= today)
            .ToListAsync();

        var checkBookCanBorrow = bookBorrowed.Sum(x => x.CallCardDetails.Count());
        if (checkBookCanBorrow >= configSLSMTD || checkBookCanBorrow + request.BookIds.Count > configSLSMTD)
            return new CallCardResult(false, $"Trong {configSLNMTD} ngày chỉ được mượn {configSLSMTD} quyển sách. Đọc giả này đã đến giới hạn mượn sách!");

        // in stock -1
        var books = await _context.Books.Where(x => request.BookIds.Any(b => b.Equals(x.Id))).ToListAsync(cancellationToken);
        if (books != null && books.Count > 0)
            foreach (var book in books)
                book.InStock -= 1;

        var callCard = new CallCard(request.LibraryCardId, request.BorrowDate, false);
        await _context.AddAsync(callCard, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        // save borrow book table
        foreach (var bookId in request.BookIds)
        {
            var callCardDetail = new CallCardDetail(callCard.Id, bookId);
            await _context.AddAsync(callCardDetail, cancellationToken);
        }
        await _context.SaveChangesAsync(cancellationToken);

        return new CallCardResult(true, "");
    }
}