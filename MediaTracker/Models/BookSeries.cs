using System;
using System.Collections.Generic;

namespace MediaTracker.Models
{
    public class BookSeries : BaseClass
    {
        public string SeriesTitle { get; set; }

        public int AmountOfBooks { get; set; }

        public DateTime FirstAppearance { get; set; }

        public DateTime LastAppearance { get; set; }

        public List<Book> Books { get; set; }
    }
}