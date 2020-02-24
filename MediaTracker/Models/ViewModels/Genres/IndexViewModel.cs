using System;
using System.Collections.Generic;

namespace MediaTracker.Models.ViewModels.Genres
{
    public class IndexViewModel
    {
        public IndexViewModel() { }

        public IndexViewModel(List<Genre> genres)
        {
            this.Genres = genres;
            if(genres.Count != 0)
            {
                this.NoData = false;
            }
        }

        public List<Genre> Genres { get; set; }

        public bool NoData { get; set; }
    }
}
