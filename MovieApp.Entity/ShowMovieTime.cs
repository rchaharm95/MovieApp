using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Entity
{
    public class ShowMovieTime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieTimeId { get; set; }

        [ForeignKey("movieModel")]
        public int MovieId { get; set; }

        public MovieModel MovieModel { get; set; }

        [ForeignKey("theatreModel")]
        public int TheatreId { get; set; }

        public TheatreModel TheatreModel { get; set; }

        public string ShowTime { get; set; }

        public string Date { get; set; }
    }
}
