using LibraryManagementSystem.Domain.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.BookFeature.Commands
{
    public class UpdateBookCommand : IRequest<UpdateBookResult>
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string Code { get; init; } = string.Empty;
        public Guid TypeId { get; init; }
        public Guid AuthorId { get; init; }
        public Guid PublisherId { get; init; }
    }

    public record UpdateBookResult : RequestResult
    {
        /// <inheritdoc />
        public UpdateBookResult(bool success) : base(success)
        {

        }
    }
}
