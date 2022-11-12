using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities
{
    /// <summary>
    ///     Tình trạng sách
    /// </summary>
    public class BookStatus : Entity
    {
        public string Name { get; private set; }

        private BookStatus()
        {
            Name = string.Empty;
        }

        public BookStatus(string name)
        {
            Name = name;
        }
    }
}