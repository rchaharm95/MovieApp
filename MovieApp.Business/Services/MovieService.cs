﻿using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Data.Repositories;
using MovieApp.Entity;

namespace MovieApp.Business.Services
{
    public class MovieService
    {
        IMovie movie;
        public MovieService(IMovie movie)
        {
            this.movie = movie;
        }

        public string AddMovie(MovieModel movieModel)
        {
            return movie.AddMovie(movieModel);
        }

        public object SelectMovie()
        {
            return movie.SelectMovie();
        }

        public string DeleteMovie(int id)
        {
            return movie.DeleteMovie(id);
        }
    }
}
