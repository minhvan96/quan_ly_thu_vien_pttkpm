using LibraryManagementSystem.Domain.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.MakeBorrowVoucherFeature.Commands;

public class BorrowBookCommand : IRequest<BorrowBookResult>
{

    public List<Guid> BookIds { get; init; }
    public Guid ReaderId { get; init; }
    public DateTime BorrowDate { get; init; }
}

public record BorrowBookResult : RequestResult
{
    /// <inheritdoc />
    public BorrowBookResult(bool success) : base(success)
    {
    }
}

