using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DataAccess
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Required]
        [StringLength(50)]
        public string MovieName { get; set; }
        [StringLength(50)]
        public string MainCharacter { get; set; }
        [Required]
        [Range(0, double.PositiveInfinity)]
        public int DurationInMinutes { get; set; }
    }
}
