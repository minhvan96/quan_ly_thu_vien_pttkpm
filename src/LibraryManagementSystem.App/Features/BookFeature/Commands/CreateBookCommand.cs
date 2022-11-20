using LibraryManagementSystem.Domain.Common;
using MediatR;

namespace LibraryManagementSystem.App.Features.BookFeature.Commands;

public class CreateBookCommand : IRequest<CreateBookResult>
{
    public string Name { get; init; } = string.Empty;
    public string Code { get; init; } = string.Empty;
    public Guid TypeId { get; init; }
    public Guid AuthorId { get; init; }
    public Guid PublisherId { get; init; }
}

public record CreateBookResult : RequestResult
{
    /// <inheritdoc />
    public CreateBookResult(bool success) : base(success)
    {
    }
}