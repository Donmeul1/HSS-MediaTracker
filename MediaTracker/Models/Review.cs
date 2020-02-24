using System;

namespace MediaTracker.Models
{
    public class Review : BaseClass
    {
        public string Title { get; set; }

        public string Text { get; set; }

        public float Rating { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }
    }
}
