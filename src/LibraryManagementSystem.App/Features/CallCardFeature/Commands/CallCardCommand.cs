using LibraryManagementSystem.Domain.Common;
using MediatR;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Commands;

public class CallCardCommand : IRequest<CallCardResult>
{
    public List<Guid> BookIds { get; set; }
    public DateTime BorrowDate { get; set; }
    public Guid LibraryCardId { get; set; }

}

public record CallCardResult : RequestResult
{
    /// <inheritdoc />
    public CallCardResult(bool success) : base(success)
    {
    }
}
