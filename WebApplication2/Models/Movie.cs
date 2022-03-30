using System;

namespace WebApplication2.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string title { get; set; }
        public string genre { get; set; }
        public DateTime releaseDate { get; set; }

        public int ProducerId { get; set; }

        public Producer Producer { get; set; }
    }
}
