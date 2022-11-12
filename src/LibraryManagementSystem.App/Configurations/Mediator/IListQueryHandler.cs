using LibraryManagementSystem.Domain.Common;
using MediatR;

namespace LibraryManagementSystem.App.Configurations.Mediator;

public interface IListQueryHandler<in TRequest, TResponse> : IRequestHandler<TRequest, IPagedList<TResponse>>
    where TRequest : ListQuery<TResponse>
{
}