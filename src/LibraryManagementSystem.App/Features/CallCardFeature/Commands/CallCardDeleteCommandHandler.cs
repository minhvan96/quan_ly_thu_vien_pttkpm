using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Commands;

public class CallCardDeleteCommandHandler : IRequestHandler<CallCardDeleteCommand, CallCardDeleteResult>
{
    private readonly LibraryDbContext _context;

    public CallCardDeleteCommandHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<CallCardDeleteResult> Handle(CallCardDeleteCommand request, CancellationToken cancellationToken)
    {
        var callCard = _context.CallCards.FirstOrDefault(x => x.Id == request.CallCardId);
        if (callCard == null) return new CallCardDeleteResult(false);

        // increase instock book
        foreach (var callCardDetail in callCard.CallCardDetails)
        {
            var book = _context.Books.Where(x => x.Id == callCardDetail.BookId).FirstOrDefault();
            if(book == null) continue;
            book.InStock += 1;

            await _context.SaveChangesAsync(cancellationToken);
        }

        _context.CallCards.Remove(callCard);
        await _context.SaveChangesAsync(cancellationToken);

        return new CallCardDeleteResult(true);
    }
}