using LibraryManagementSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class Reader : Entity
    {
        private Reader()
        {
            Name = string.Empty;
            Address = string.Empty;
            Email = string.Empty;
        }

        public Reader(string name, string address, string email, DateTimeOffset dob, DateTimeOffset createDate, string readerType)
        {
            Name = name;
            Address = address;
            Email = email;
            Dob = dob;
            CreateDate = createDate;
            ReaderType = readerType;
        }

        public Reader(Guid id, string name, string address, string email, DateTimeOffset dob, DateTimeOffset createDate, string readerType)
            : base(id)
        {
            Name = name;
            Address = address;
            Email = email;
            Dob = dob;
            CreateDate = createDate;
            ReaderType = readerType;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }    
        public DateTimeOffset Dob { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public string ReaderType { get; set; }

    }
}
