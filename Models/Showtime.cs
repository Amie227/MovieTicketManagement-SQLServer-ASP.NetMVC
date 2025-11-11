
using System;
using System.ComponentModel.DataAnnotations;

namespace no12finalproject.Models
{
    public class Showtime
    {

        public Guid ShowtimeID { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public Guid MovieID { get; set; }

        public Movie Movie { get; set; }

    }
}
