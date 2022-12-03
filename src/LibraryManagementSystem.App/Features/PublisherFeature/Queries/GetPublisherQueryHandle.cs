using LibraryManagementSystem.App.Features.AuthorFeature.Commands;
using LibraryManagementSystem.App.Features.AuthorFeature.Dtos;
using LibraryManagementSystem.App.Features.AuthorFeature.Queries;
using LibraryManagementSystem.App.Features.PubblisherFeature.Dtos;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.PubblisherFeature.Queries;
public class GetPublisherQueryHandle : IRequestHandler<GetPublisherQuery, PublisherDto?>
{

    private readonly LibraryDbContext _context;

    public GetPublisherQueryHandle(LibraryDbContext context)
    {
        _context = context;
    }
    public async Task<PublisherDto?> Handle(GetPublisherQuery request, CancellationToken cancellationToken)
    {
        var publiser = await _context.Publishers
            .Select(x => new PublisherDto
            {
                Id = x.Id,
                Name = x.Name,
            })
            .FirstOrDefaultAsync(x => x.Name.ToLower() == request.Name.ToLower(), cancellationToken);

        return publiser;
    }
}
