using LibraryManagementSystem.Domain.Common;
using MediatR;

namespace LibraryManagementSystem.App.Features.BookFeature.Commands;

public class DeleteBookCommand : IRequest<DeleteBookResult>
{
    public Guid Id { get; init; }
}

public record DeleteBookResult : RequestResult
{
    /// <inheritdoc />
    public DeleteBookResult(bool success) : base(success)
    {
    }
}