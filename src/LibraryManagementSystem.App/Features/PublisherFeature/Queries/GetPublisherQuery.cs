using LibraryManagementSystem.App.Features.AuthorFeature.Dtos;
using LibraryManagementSystem.App.Features.PubblisherFeature.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.PubblisherFeature.Queries;
public class GetPublisherQuery : IRequest<PublisherDto>
{
    public string Name { get; set; }
}
