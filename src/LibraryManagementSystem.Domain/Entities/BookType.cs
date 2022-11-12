﻿using LibraryManagementSystem.Domain.Common;

namespace LibraryManagementSystem.Domain.Entities
{
    /// <summary>
    ///     Loại sách, thể loại
    /// </summary>
    public class BookType : Entity
    {
        public string Name { get; private set; }

        private BookType()
        {
            Name = string.Empty;
        }

        public BookType(string name)
        {
            Name = name;
        }
    }
}