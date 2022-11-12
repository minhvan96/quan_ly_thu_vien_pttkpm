using LibraryManagementSystem.App.Features.BookFeature.Dtos;
using MediatR;

namespace LibraryManagementSystem.App.Features.BookFeature.Queries;

public class GetBookQuery : IRequest<BookDto>
{
    public Guid Id { get; init; }
}