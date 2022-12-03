using LibraryManagementSystem.App.Features.AuthorFeature.Dtos;
using LibraryManagementSystem.App.Features.BookFeature.Commands;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.AuthorFeature.Commands;
public class CreateAuthorCommandHandle : IRequestHandler<CreateAuthorCommand, AuthorDto>
{
    private readonly LibraryDbContext _context;

    public CreateAuthorCommandHandle(LibraryDbContext context)
    {
        _context = context;
    }

    public async Task<AuthorDto> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
    {
        var newAuthor = new Author(request.Name);

        var Author = await _context.AddAsync(newAuthor, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return new AuthorDto(Author.Entity);
    }
}
