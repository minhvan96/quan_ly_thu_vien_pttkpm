using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.AuthorFeature.Dtos
{
    public record AuthorDto : RequestResult
    {

        public AuthorDto() : base(true)
        {
           
        }

        public AuthorDto(Author author) : base(true)
        {
            Name = author.Name;
            Id = author.Id;
        }

        public Guid Id { get; init; }
        public string Name { get; set; } = string.Empty;
    }
}
