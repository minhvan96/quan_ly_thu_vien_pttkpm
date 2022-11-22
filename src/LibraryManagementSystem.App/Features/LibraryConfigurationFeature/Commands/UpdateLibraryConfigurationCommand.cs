using LibraryManagementSystem.Domain.Common;
using MediatR;

namespace LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Commands;

public class UpdateLibraryConfigurationCommand : IRequest<UpdateLibraryConfigurationRequest>
{
    public string Code { get; init; } = string.Empty;
    public string? Name { get; init; } = string.Empty;
    public int? Value { get; init; }
}

public record UpdateLibraryConfigurationRequest : RequestResult
{
    /// <inheritdoc />
    public UpdateLibraryConfigurationRequest(bool success) : base(success)
    {
    }
}