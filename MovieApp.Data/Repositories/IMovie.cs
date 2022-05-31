﻿using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.Repository
{
    public interface IMovie
    {
        string AddMovie(MovieModel movieModel);

        string DeleteMovie(int id);
        object SelectMovie();

        string EditMovie(MovieModel movieModel);

        public object findMovieById(int movieid);
    }
}
