using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MediaTracker.Models
{
    public class Book : BaseClass
    {
        public Book()
        {
            if(this.Id == 0)
            {
                this.setControlProperties(false, true);
            }
        }

        public Book(int Id)
        {
            this.Id = Id;
            if(this.Id == 0)
            {
                this.setControlProperties(false, true);
            }
        }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public int ReleaseYear { get; set; }

        [DataType(DataType.Date)]
        public DateTime Released { get; set; }

        public string Edition { get; set; }

        public int Pages { get; set; }

        public int Chapters { get; set; }

        public string Publisher { get; set; }

        public bool Illustrations { get; set; }

        public bool Translated { get; set; }

        public string Translator { get; set; }

        public string OriginalLanguage { get; set; }

        public Bindings Binding { get; set; } 

        public bool HasMap { get; set; }

        public Author Author { get; set; }

        public virtual List<Genre> Genres { get; set; }

        public float Rating { get; set; }

        public virtual List<Review> Reviews { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public virtual List<Note> Notes { get; set; }
    }
}