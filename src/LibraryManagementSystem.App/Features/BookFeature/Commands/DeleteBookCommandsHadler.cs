using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.BookFeature.Commands
{

    internal class DeleteBookCommandsHadler : IRequestHandler<DeleteBookCommand, DeleteBookResult>
    {
        private readonly LibraryDbContext _context;

        public DeleteBookCommandsHadler(LibraryDbContext context)
        {
            _context = context;
        }
        public async Task<DeleteBookResult> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (book != null) //return new DeleteBookResult(true); ;
                _context.Remove(book);

            await _context.SaveChangesAsync(cancellationToken);
            return new DeleteBookResult(true);
        }
    }
}
