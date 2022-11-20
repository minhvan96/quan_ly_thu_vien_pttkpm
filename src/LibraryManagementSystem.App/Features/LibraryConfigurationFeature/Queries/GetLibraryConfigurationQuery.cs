using LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Dtos;
using MediatR;

namespace LibraryManagementSystem.App.Features.LibraryConfigurationFeature.Queries;

public class GetLibraryConfigurationQuery : IRequest<LibraryConfigurationDto>
{
    public Guid Id { get; init; }
}