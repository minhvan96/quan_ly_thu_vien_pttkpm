using LibraryManagementSystem.Domain.Common;
using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.PubblisherFeature.Dtos;
public record PublisherDto : RequestResult
{

    public PublisherDto() : base(true)
    {

    }

    public PublisherDto(Publisher author) : base(true)
    {
        Name = author.Name;
        Id = author.Id;
    }

    public PublisherDto(Guid id, string name) : base(true)
    {
        this.Name = name;
        this.Id = id;
    }
    public Guid Id { get; init; }
    public string Name { get; set; } = string.Empty;
}
