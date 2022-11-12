using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities
{
    /// <summary>
    ///     Sách
    /// </summary>
    public class Book : Entity
    {
        public BookType? Type { get; private set; }
        public string Code { get; private set; }
        public string Name { get; private set; }
        public Guid TypeId { get; private set; }
        public Author? Author { get; private set; }
        public Guid AuthorId { get; private set; }

        private Book()
        {
            Name = string.Empty;
            Code = string.Empty;
        }

        public Book(string name,
            string code,
            Guid typeId,
            Guid authorId)
        {
            Code = code;
            TypeId = typeId;
            Name = name;
            AuthorId = authorId;
        }
    }
}