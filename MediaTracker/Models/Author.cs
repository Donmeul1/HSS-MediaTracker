using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MediaTracker.Data;
using Microsoft.EntityFrameworkCore;

namespace MediaTracker.Models
{
    public class Author : BaseClass
    {
        #region constructors

        public Author()
        {
            if(this.Id == 0)
            {
                this.setControlProperties(false, true);
            }            
        }

        public Author(int Id)
        {
            this.Id = Id;
            if(this.Id == 0)
            {
                this.setControlProperties(false, true);
            }
        }

        public Author(List<Book> Books)
        {
            this.Books = Books;
            if(this.Id == 0)
            {
                this.setControlProperties(false, true);
            }
        }

        #endregion

        #region properties

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Date of death")]
        [DataType(DataType.Date)]
        public DateTime? DateOfDeath { get; set; }

        [Display(Name = "First name")]
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Middle name")]
        [MaxLength(50)]
        public string MiddleName { get; set; }

        [MaxLength(15)]
        public string Infix { get; set; }

        [Display(Name = "Last name")]
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(2500)]
        public string Bio { get; set; }

        public int BooksWritten { get; set; }


        public virtual List<Book> Books { get; set; }

        #endregion


        
    }
}