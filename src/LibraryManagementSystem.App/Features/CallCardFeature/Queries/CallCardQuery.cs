using LibraryManagementSystem.App.Features.CallCardFeature.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Queries;

public class CallCardQuery : IRequest<CallCardDto>
{
    public Guid Id { get; init; }
}
