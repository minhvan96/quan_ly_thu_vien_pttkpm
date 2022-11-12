using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities
{
    /// <summary>
    ///     Tác giả
    /// </summary>
    public class Author : Entity
    {
        public string Name { get; private set; }

        private Author()
        {
            Name = string.Empty;
        }

        public Author(string name)
        {
            Name = name;
        }
    }
}