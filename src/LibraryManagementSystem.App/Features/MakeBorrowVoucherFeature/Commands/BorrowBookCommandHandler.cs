using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
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
        // save borrow book table

        //var newBook = new Book(request.Name,
        //    request.Code,
        //    request.TypeId,
        //    request.AuthorId,
        //    request.PublisherId,
        //    0);

        //await _context.AddAsync(newBook, cancellationToken);
        //await _context.SaveChangesAsync(cancellationToken);
        return new BorrowBookResult(true);
    }
}
