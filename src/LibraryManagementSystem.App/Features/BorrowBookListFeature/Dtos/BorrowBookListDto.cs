﻿using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.App.Features.BorrowBookListFeature.Dtos
{
    public class BorrowBookListDto
    {
        public Guid Id { get; set; }
        public string ReaderName { get; set; }
        public int BookCount { get; set; }
        public DateTimeOffset BorrowDate { get; set; }
        public string Status { get; set; }
    }
}
