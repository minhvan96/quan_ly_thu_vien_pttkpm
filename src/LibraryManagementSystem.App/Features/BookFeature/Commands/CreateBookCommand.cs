using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Domain.Entities;
using MediatR;

namespace LibraryManagementSystem.App.Features.BookFeature.Commands;

public class CreateBookCommand : IRequest<CreateBookResult>
{
    public string Name { get; init; } = string.Empty;
    public string Code { get; init; } = string.Empty;
    public Guid TypeId { get; init; }
    public Guid AuthorId { get; init; }
    public Guid PublisherId { get; init; }

    public DateTimeOffset? EntryDate { get; set; }
    public int quantily { get; set; }
    public int PublishedYear { get; set; }

}

public record CreateBookResult : RequestResult
{
    public Guid Id { get; set; }
    /// <inheritdoc />
    public CreateBookResult(Book book , bool success) : base(success)
    {
        if (success)
        {
            Id = book.Id;
        }
    }
}