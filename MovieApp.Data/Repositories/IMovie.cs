using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entity;

namespace MovieApp.Data.Repositories
{
    public interface IMovie
    {
        string AddMovie(MovieModel movieModel);
        string DeleteMovie(int id);
        object SelectMovie();
    }
}
