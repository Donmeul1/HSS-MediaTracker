using System;
using Microsoft.AspNetCore.Identity;

namespace MediaTracker.Models
{
    public class Note : BaseClass
    {
        public string Text { get; set; }

        public DateTime Created { get; set; }

        public IdentityUser User { get; set; }
    }
}
