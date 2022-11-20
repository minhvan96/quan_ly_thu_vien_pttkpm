using LibraryManagementSystem.Domain.Common;
using MediatR;

namespace LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Commands;

public class UpdateLibraryConfigurationCommand : IRequest<UpdateLibraryConfigurationRequest>
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public int? Value { get; init; }
}

public record UpdateLibraryConfigurationRequest : RequestResult
{
    /// <inheritdoc />
    public UpdateLibraryConfigurationRequest(bool success) : base(success)
    {
    }
}