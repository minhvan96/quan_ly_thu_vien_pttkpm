using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
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
        if (callCard == null) return new CallCardUpdateResult(false);

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

        return new CallCardUpdateResult(true);
    }
}