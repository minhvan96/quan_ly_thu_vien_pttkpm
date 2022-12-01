using LibraryManagementSystem.App.Features.CallCardFeature.Dtos;
using LibraryManagementSystem.Domain.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Commands;

public class CallCardUpdateCommand : IRequest<CallCardUpdateResult>
{
    public Guid CallCardId { get; set; }
    public List<BorrowBookListSelectedDto> booksNeedAdd { get; set; }
    public List<BorrowBookListSelectedDto> booksNeedDelete { get; set; }
    public DateTime BorrowDate { get; set; }
    public Guid LibraryCardId { get; set; }

}

public record CallCardUpdateResult : RequestResult
{
    /// <inheritdoc />
    public CallCardUpdateResult(bool success, string message) : base(success, message)
    {
    }
}
