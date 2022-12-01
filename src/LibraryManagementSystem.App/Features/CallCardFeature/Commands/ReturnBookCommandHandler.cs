using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Commands;

public class ReturnBookCommandHandler : IRequestHandler<ReturnBookCommand, ReturnBookResult>
{
    private readonly LibraryDbContext _context;

    public ReturnBookCommandHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<ReturnBookResult> Handle(ReturnBookCommand request, CancellationToken cancellationToken)
    {
        var callCard = _context.CallCards.FirstOrDefault(x => x.Id == request.CallCardId);
        if (callCard == null) return new ReturnBookResult(false);

        // increase instock book
        foreach (var callCardDetail in callCard.CallCardDetails)
        {
            var book = _context.Books.Where(x => x.Id == callCardDetail.BookId).FirstOrDefault();
            if (book == null) continue;
            book.InStock += 1;

            await _context.SaveChangesAsync(cancellationToken);
        }

        callCard.IsReturnBook = true;
        await _context.SaveChangesAsync(cancellationToken);

        return new ReturnBookResult(true);
    }
}
