using LibraryManagementSystem.Domain.Constants;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Commands;

public class CallCardUpdateCommandHandler : IRequestHandler<CallCardUpdateCommand, CallCardUpdateResult>
{
    private readonly LibraryDbContext _context;

    public CallCardUpdateCommandHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<CallCardUpdateResult> Handle(CallCardUpdateCommand request, CancellationToken cancellationToken)
    {
        // find callcard need update
        var callCard = _context.CallCards.FirstOrDefault(x => x.Id == request.CallCardId);
        if (callCard == null) return new CallCardUpdateResult(false, "Phiếu mượn không tồn tại!");
        //var borrowCount = callCard.CallCardDetails.Count + request.booksNeedAdd.Count - request.booksNeedDelete.Count;

        // validate 
        // check library card expiration
        var today = DateTime.Now;
        var configuation = await _context.LibraryConfigurations
            .Where(x => x.Code == LibraryConfigurationConstants.SLNMTD
            || x.Code == LibraryConfigurationConstants.SLSMTD)
            .ToListAsync();

        // check library how many library card (reader) borrowed books in 4 days?
        var configSLNMTD = configuation.FirstOrDefault(x => x.Code == LibraryConfigurationConstants.SLNMTD).Value;
        var configSLSMTD = configuation.FirstOrDefault(x => x.Code == LibraryConfigurationConstants.SLSMTD).Value;

        var bookBorrowed = await _context.CallCards
            .Include(x => x.CallCardDetails)
            .Where(x => x.LibraryCardId == request.LibraryCardId && !x.IsReturnBook
                && x.BorrowDateTime <= today
                && x.BorrowDateTime.AddDays(configSLNMTD) >= today)
            .ToListAsync();

        var checkBookCanBorrow = bookBorrowed.Sum(x => x.CallCardDetails.Count()) + request.booksNeedAdd.Count - request.booksNeedDelete.Count;
        if (checkBookCanBorrow > configSLSMTD)
            return new CallCardUpdateResult(false, $"Trong {configSLNMTD} ngày chỉ được mượn {configSLSMTD} quyển sách. Đọc giả này đã đến giới hạn mượn sách!");

        // update libraryId and borrowDate
        callCard.BorrowDateTime = request.BorrowDate;
        callCard.LibraryCardId = request.LibraryCardId;
        await _context.SaveChangesAsync(cancellationToken);

        // if books update exists -> update
        if (request.booksNeedDelete != null && request.booksNeedAdd != null)
        {
            if (request.booksNeedDelete.Count > 0)
            {
                foreach (var book in request.booksNeedDelete)
                {
                    var callCardDetail = _context.CallCardDetails.Where(x => x.CalLCardId == request.CallCardId && x.BookId == book.BookId).FirstOrDefault();
                    if (callCardDetail == null) continue;
                    _context.CallCardDetails.Remove(callCardDetail);

                    // increase instock book
                    var bookquery = _context.Books.Where(x => x.Id == callCardDetail.BookId).FirstOrDefault();
                    if (bookquery == null) continue;
                    bookquery.InStock += 1;

                    await _context.SaveChangesAsync(cancellationToken);
                }
            }

            if(request.booksNeedAdd.Count > 0)
            {
                foreach (var book in request.booksNeedAdd)
                {
                    var callCardDetail = new CallCardDetail(callCard.Id, book.BookId);
                    await _context.AddAsync(callCardDetail, cancellationToken);

                    // discrease instock book
                    var bookquery = _context.Books.Where(x => x.Id == callCardDetail.BookId).FirstOrDefault();
                    if (bookquery == null) continue;
                    bookquery.InStock -= 1;
                }
                await _context.SaveChangesAsync(cancellationToken);
            }
        }

        return new CallCardUpdateResult(true, "");
    }
}