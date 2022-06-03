using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entity;

namespace MovieApp.Data.Repositories
{
    public interface IMovieTime
    {
        public string AddMovieTime(ShowMovieTime movieTime);

        List<ShowMovieTime> showAllMovie();

        string DeleteMovieTime(int id);
    }
}
