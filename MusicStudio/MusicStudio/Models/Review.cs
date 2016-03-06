using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MusicStudio.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
        public string Contents { get; set; }

        [Required ()]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }
    }
}
