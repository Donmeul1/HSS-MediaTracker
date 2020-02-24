using System;
using System.ComponentModel.DataAnnotations;

namespace MediaTracker.Models
{
    public abstract class BaseClass
    {
        #region properties

        [Required]
        public int Id { get; set; }

        [Required]
        public bool Deleted { get; set; }

        [Required]
        public bool Active { get; set; }

        #endregion

        #region methods

        protected void setControlProperties(bool Deleted, bool Active)
        {
            this.Deleted = Deleted;
            this.Active = Active;
        }

        public bool IsNew()
        {
            if (this.Id == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }

    public enum Bindings : byte
    {
        Paperback,
        Hardcover,
        Audiobook,
        eBook
    };
}
