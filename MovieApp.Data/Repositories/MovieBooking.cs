using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Data.DataConnection;
using MovieApp.Entity;
using System.Linq;
using System.Text;

namespace MovieApp.Data.Repositories
{
    public class MovieBooking : IMovieBooking
    {
        MovieDbContext _movieDbContext;
        public MovieBooking(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public string AddBooking(BookingModel booking)
        {
            _movieDbContext.MovieBooking.Add(booking);
            _movieDbContext.SaveChanges();
            return "Booking Added Successfully..!!";
        }

        public List<BookingModel> BookingList()
        {
            return _movieDbContext.MovieBooking.ToList();
        }

    }
}
