﻿using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities;

/// <summary>
///     Thẻ mượn sách
///     <see href="https://edu2review.com/reviews/tat-tan-tat-nhung-tu-vung-tieng-anh-ve-thu-vien-9234.html" />
/// </summary>
public class CallCard : Entity
{
    public LibraryCard? LibraryCard { get; set; }
    public ICollection<CallCardDetail> CallCardDetails { get; set; }
    public Guid LibraryCardId { get; set; }
    public DateTime BorrowDateTime { get; set; }
    public bool IsReturnBook { get; set; }

    public CallCard(Guid id, Guid libraryCardId, DateTime borrowDateTime, bool isReturnBook) : base(id)
    {
        this.LibraryCardId = libraryCardId;
        this.BorrowDateTime = borrowDateTime;   
        this.IsReturnBook = isReturnBook;
    }

    public CallCard(Guid libraryCardId, DateTime borrowDateTime, bool isReturnBook)
    {
        this.LibraryCardId = libraryCardId;
        this.BorrowDateTime = borrowDateTime;
        this.IsReturnBook = isReturnBook;
    }
}