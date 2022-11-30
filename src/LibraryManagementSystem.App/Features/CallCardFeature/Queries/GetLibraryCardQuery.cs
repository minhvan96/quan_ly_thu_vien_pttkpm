using LibraryManagementSystem.App.Features.CallCardFeature.Dtos;
using MediatR;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Queries;

public class GetLibraryCardQuery : IRequest<LibraryCardDto>
{
    public Guid Id { get; init; }
}