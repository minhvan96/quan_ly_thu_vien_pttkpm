using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.MakeBorrowVoucherFeature.Commands;
//internal class BorrowBookCommandHandler
//{
//}
public class BorrowBookCommandHandler : IRequestHandler<BorrowBookCommand, BorrowBookResult>
{
    private readonly LibraryDbContext _context;

    public BorrowBookCommandHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<BorrowBookResult> Handle(BorrowBookCommand request, CancellationToken cancellationToken)
    {
        // in stock -1
        var books = await _context.Books.Where(x => request.BookIds.Any(b => b.Equals(x.Id))).ToListAsync(cancellationToken);
        if (books != null && books.Count > 0)
            foreach (var book in books)
                book.InStock -= 1;

        // save borrow book table
        foreach (var bookId in request.BookIds)
        {
            var borrowBook = new BorrowBook(
                request.ReaderId,
                bookId,
                request.BorrowDate,
                DateTimeOffset.Now,
                false);
            await _context.AddAsync(borrowBook, cancellationToken);
        }

        await _context.SaveChangesAsync(cancellationToken); 
        return new BorrowBookResult(true);
    }
}
