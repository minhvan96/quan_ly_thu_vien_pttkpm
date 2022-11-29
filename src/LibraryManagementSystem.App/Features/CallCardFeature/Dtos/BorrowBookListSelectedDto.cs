using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Dtos;

public class BorrowBookListSelectedDto
{
    public string Author { get; set; }
    public Guid BookId { get; set; }
    public string BookName { get; set; }
    public string BookType { get; set; }

}
