using LibraryManagementSystem.App.Features.AuthorFeature.Dtos;
using LibraryManagementSystem.App.Features.BookFeature.Commands;
using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.AuthorFeature.Commands;

public  class CreateAuthorCommand : IRequest<AuthorDto>
{
    public string Name { get; init; } = string.Empty;
}

