using LibraryManagementSystem.App.Features.AuthorFeature.Dtos;
using LibraryManagementSystem.App.Features.BookFeature.Dtos;
using LibraryManagementSystem.App.Features.BookFeature.Queries;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.AuthorFeature.Queries
{
    public class getAuthorQueryHandler : IRequestHandler<GetAuthorQuery, AuthorDto?>
    {
        private readonly LibraryDbContext _context;

        public getAuthorQueryHandler(LibraryDbContext context)
        {
            _context = context;
        }
        public async Task<AuthorDto?> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var author = await _context.Authors
            .Select(x => new AuthorDto
            {
                Id = x.Id,
                Name = x.Name,
            })
            .FirstOrDefaultAsync(x => x.Name.ToLower() == request.Name.ToLower(), cancellationToken);

            return author;
        }
    }
}
