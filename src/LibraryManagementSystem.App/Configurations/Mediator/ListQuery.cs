using LibraryManagementSystem.Domain.Common;
using MediatR;

namespace LibraryManagementSystem.App.Configurations.Mediator;

public abstract class ListQuery<TResponse> : IRequest<IPagedList<TResponse>>
{
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}