using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Display(Name="Title"), Required, MaxLength(50)]
        public string title { get; set; }
        [Display(Name="Genre")]
        public string genre { get; set; }
        [DataType(DataType.Date), Display(Name ="Release Date")]
        public DateTime releaseDate { get; set; }

        public int ProducerId { get; set; }

        public Producer Producer { get; set; }
    }
}
