using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities;

/// <summary>
///     Thẻ mượn sách
///     <see href="https://edu2review.com/reviews/tat-tan-tat-nhung-tu-vung-tieng-anh-ve-thu-vien-9234.html" />
/// </summary>
public class CallCard : Entity
{
    public LibraryCard? LibraryCard { get; private set; }
    public Guid LibraryCardId { get; private set; }

    public DateTime BorrowDate { get; private set; }
    
    public CallCard() { 
        BorrowDate= DateTime.Now;
    }

    public CallCard(Guid libraryCardId)
    {
        LibraryCardId= libraryCardId;
    }

}