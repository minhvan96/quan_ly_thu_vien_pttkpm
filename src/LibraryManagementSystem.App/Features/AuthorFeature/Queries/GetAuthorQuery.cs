using LibraryManagementSystem.App.Features.AuthorFeature.Dtos;
using LibraryManagementSystem.App.Features.BookFeature.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.AuthorFeature.Queries
{
    public class GetAuthorQuery : IRequest<AuthorDto>
    {
        public string Name { get; set; }
    }
}
