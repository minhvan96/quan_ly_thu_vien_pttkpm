using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.CallCardFeature.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Queries;

public class CallCardListQuery : ListQuery<CallCardDto>
{
    public SearchCallCardOptions SearchOption { get; init; }

    public string SearchCriteria { get; init; } = string.Empty; // text
}

[Flags]
public enum SearchCallCardOptions
{
    None = 0,
    LibraryName = 1,
    BorrowDate = 2,
    All = LibraryName | BorrowDate
}
