using System;
using System.Collections.Generic;

namespace MediaTracker.Models.ViewModels.Books
{
    public class IndexViewModel
    {
        public IndexViewModel(List<Book> books)
        {
            this.Books = new List<Book>();
            this.Books = books;

            if(this.Books.Count != 0)
            {
                this.NoBooks = false;
            } else
            {
                this.NoBooks = true;
            }
        }

        public List<Book> Books { get; set; }

        public bool NoBooks { get; set; }
    }
}
