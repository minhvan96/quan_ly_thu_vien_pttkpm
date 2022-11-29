﻿using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.CallCardFeature.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Queries;

public class LibraryCardListQuery : ListQuery<LibraryCardDto>
{
    public SearchLibraryOptions SearchOption { get; init; }

    public string SearchCriteria { get; init; } = string.Empty; // text
}

[Flags]
public enum SearchLibraryOptions
{
    None = 0,
    Name = 1,
    All = Name
}
