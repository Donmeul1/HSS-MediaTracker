using System;

namespace MediaTracker.Models
{
    public class Genre : BaseClass
    {
        public Genre()
        {
            if(this.Id == 0)
            {
                this.setControlProperties(false, true);
            }
        }

        public Genre(int Id)
        {
            this.Id = Id;
            if(this.Id == 0)
            {
                this.setControlProperties(false, true);
            }
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool HasPhoto { get; set; }

        public string PhotoPath { get; set; }
    }
}