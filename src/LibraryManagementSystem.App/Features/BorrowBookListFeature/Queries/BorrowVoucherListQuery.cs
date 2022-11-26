using LibraryManagementSystem.App.Configurations.Mediator;
using LibraryManagementSystem.App.Features.BorrowBookListFeature.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.BorrowBookListFeature.Queries;
 
public class BorrowVoucherListQuery : ListQuery<BorrowBookListDto>
{
    public SearchBookOptions SearchOption { get; init; }

    public string SearchCriteria { get; init; } = string.Empty;  
}

[Flags]
public enum SearchBookOptions
{
    None = 0,
    BookName = 1,
    ReaderName = 2,
    All = BookName | ReaderName
}
