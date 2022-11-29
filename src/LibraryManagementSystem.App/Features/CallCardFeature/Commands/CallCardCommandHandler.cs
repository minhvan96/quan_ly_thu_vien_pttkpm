using LibraryManagementSystem.Domain.Common;
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
        // in stock -1
        var books = await _context.Books.Where(x => request.BookIds.Any(b => b.Equals(x.Id))).ToListAsync(cancellationToken);
        if (books != null && books.Count > 0)
            foreach (var book in books)
                book.InStock -= 1;

        var callCard = new CallCard(request.LibraryCardId, request.BorrowDate);
        await _context.AddAsync(callCard, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        // save borrow book table
        foreach (var bookId in request.BookIds)
        {
            var callCardDetail = new CallCardDetail(callCard.Id, bookId);
            await _context.AddAsync(callCardDetail, cancellationToken);
        }
        await _context.SaveChangesAsync(cancellationToken);

        return new CallCardResult(true);
    }
}