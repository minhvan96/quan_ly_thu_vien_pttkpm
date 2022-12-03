using LibraryManagementSystem.App.Features.PubblisherFeature.Dtos;
using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.PubblisherFeature.Commands;
public class CreatePubliserCommand : IRequest<PublisherDto>
{
    public string Name { get; init; } = string.Empty;
}
//public record CreatePubliserResult : RequestResult
//{
//    public string Name { get; init; }
//    public Guid Id { get; init; }

//    public CreatePubliserResult(Publisher author) : base(true)
//    {
//        Name = author.Name;
//        Id = author.Id;
//    }
//}