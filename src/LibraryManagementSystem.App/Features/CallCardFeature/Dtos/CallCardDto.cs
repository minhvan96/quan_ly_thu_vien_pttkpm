using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.CallCardFeature.Dtos;

public class CallCardDto
{
    public Guid Id { get; set; }
    public List<CallCardDetail> CallCardDetails { get; set; }
    public DateTime BorrowDate{ get; set; }
    public LibraryCard LibraryCard { get; set; }
    public string Status { get; set; }
    public int BookCount{ get; set; }
}
