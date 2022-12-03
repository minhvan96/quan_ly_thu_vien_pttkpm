using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Domain.Entities;
using MediatR;

namespace LibraryManagementSystem.App.Features.LibraryCardFeature.Commands;

public class UpdateLibraryCardCommand : IRequest<UpdateLibraryCardResult>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public DateTimeOffset? BirthDay { get; set; }
    public DateTimeOffset? CreationDate { get; set; }
    public string TypeOfReader { get; set; }

}

public record UpdateLibraryCardResult : RequestResult
{
    /// <inheritdoc />
    public UpdateLibraryCardResult(bool success) : base(success)
    {
    }
}