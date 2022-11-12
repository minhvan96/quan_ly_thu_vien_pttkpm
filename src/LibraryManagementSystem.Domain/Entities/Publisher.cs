using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities
{
    /// <summary>
    ///     Nhà xuất bản
    /// </summary>
    public class Publisher : Entity
    {
        public string Name { get; private set; }

        private Publisher()
        {
            Name = string.Empty;
        }

        public Publisher(string name)
        {
            Name = name;
        }
    }
}