using LibraryManagementSystem.Domain.Common;
using MediatR;

namespace LibraryManagementSystem.App.Features.LibraryCardFeature.Commands;

public class DeleteLibraryCardCommand : IRequest<DeleteLibraryCardResult>
{
    public Guid Id { get; init; }
}

public record DeleteLibraryCardResult : RequestResult
{
    /// <inheritdoc />
    public DeleteLibraryCardResult(bool success) : base(success)
    {
    }
}