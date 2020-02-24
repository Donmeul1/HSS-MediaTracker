using System;
using System.Collections.Generic;

namespace MediaTracker.Models.ViewModels.Authors
{
    public class IndexViewModel
    {
        public IndexViewModel(List<Author> authors)
        {
            this.Authors = authors;
        }

        public List<Author> Authors { get; set; }
    }
}
