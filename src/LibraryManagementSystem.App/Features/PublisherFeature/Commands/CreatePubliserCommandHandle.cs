using LibraryManagementSystem.App.Features.AuthorFeature.Commands;
using LibraryManagementSystem.App.Features.PubblisherFeature.Dtos;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.PubblisherFeature.Commands;
public class CreatePubliserCommandHandle : IRequestHandler<CreatePubliserCommand, PublisherDto>
{
    private readonly LibraryDbContext _context;

    public CreatePubliserCommandHandle(LibraryDbContext context)
    {
        _context = context;
    }
    public async Task<PublisherDto> Handle(CreatePubliserCommand request, CancellationToken cancellationToken)
    {
        var newPublsier = new Publisher(request.Name);

        var Publiser = await _context.AddAsync(newPublsier, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return new PublisherDto(Publiser.Entity);
    }
}
