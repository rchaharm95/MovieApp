using MovieApp.Data.Repositories;
using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Business.Services
{
    public class MovieTimeService
    {
        IMovieTime _imovieTime;

        public MovieTimeService(IMovieTime imovieTime)
        {
            _imovieTime = imovieTime;
        }

        public string AddMovieTime(ShowMovieTime showMovieTime)
        {
            return _imovieTime.AddMovieTime(showMovieTime);
        }

        public List<ShowMovieTime> ShowAllMovie()
        {
            return _imovieTime.showAllMovie();
        }

        public string DeleteMovieTime(int id)
        {
            return _imovieTime.DeleteMovieTime(id);
        }

    }
}

