using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entity;
using MovieApp.Data.DataConnection;
using System.Linq;

namespace MovieApp.Data.Repositories
{
    public class Movie : IMovie
    {
        MovieDbContext _movieDbContext;

        public Movie(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public string AddMovie(MovieModel movieModel)
        {
            string msg = "";
            _movieDbContext.movieModel.Add(movieModel);
            _movieDbContext.SaveChanges();
            msg = "movie added successfully";
            return msg;
        }

        public string DeleteMovie(int id)
        {
            string msg = "";
            var foundMovie = _movieDbContext.movieModel.Find(id);
            if(foundMovie == null)
            {
                msg = "no movie found with given id";
            }
            else
            {
                _movieDbContext.movieModel.Remove(foundMovie);
                _movieDbContext.SaveChanges();
                msg = "movie deleted sccessfully..";
            }
            return msg;
        }

        public object SelectMovie()
        {
            List<MovieModel> list =  _movieDbContext.movieModel.ToList();
            return list;
        }
    }
}
