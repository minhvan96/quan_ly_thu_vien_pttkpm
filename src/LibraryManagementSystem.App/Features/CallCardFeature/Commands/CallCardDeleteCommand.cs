using LibraryManagementSystem.Domain.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Commands;

public class CallCardDeleteCommand : IRequest<CallCardDeleteResult>
{
    public Guid CallCardId { get; set; }
}

public record CallCardDeleteResult : RequestResult
{
    /// <inheritdoc />
    public CallCardDeleteResult(bool success) : base(success)
    {
    }
}