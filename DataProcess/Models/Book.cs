﻿using System;
using System.Collections.Generic;

namespace DataProcess.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime PublicationDate { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Author { get; set; } = null!;
        public int BookCategoryId { get; set; }
        public virtual BookCategory BookCategory { get; set; } = null!;

        public override string? ToString()
        {
            return $"{BookId};{BookName};{Description};{PublicationDate};{Quantity};{Price};{Author};{BookCategoryId}";
        }
    }
}
