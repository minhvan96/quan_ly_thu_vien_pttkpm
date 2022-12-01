using LibraryManagementSystem.Domain.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Commands;

public class ReturnBookCommand : IRequest<ReturnBookResult>
{
    public Guid CallCardId { get; set; }

}

public record ReturnBookResult : RequestResult
{
    /// <inheritdoc />
    public ReturnBookResult(bool success) : base(success)
    {
    }
}