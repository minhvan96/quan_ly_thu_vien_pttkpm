using LibraryManagementSystem.App.Features.CallCardFeature.Dtos;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Queries;

public class GetLibraryCardQueryHandler : IRequestHandler<GetLibraryCardQuery, LibraryCardDto?>
{
    private readonly LibraryDbContext _context;

    public GetLibraryCardQueryHandler(LibraryDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<LibraryCardDto?> Handle(GetLibraryCardQuery request, CancellationToken cancellationToken)
    {
        var book = await _context.LibraryCards
            .Select(x => new LibraryCardDto
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                BirthDay = x.BirthDay,
                Email = x.Email,
                TypeOfReader = x.TypeOfReader,
            })
            .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        return book;
    }
}