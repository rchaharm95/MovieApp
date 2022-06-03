using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entity;
using static MovieApp.Data.Repositories.IMovieBooking;

namespace MovieApp.Business.Services
{
    public class MovieBookingService
    {
        IBooking _movieBooking;

        public MovieBookingService(IBooking movieBooking)
        {
            _movieBooking = movieBooking;
        }

        public string AddMovieBooking(BookingModel booking)
        {
            return _movieBooking.AddBooking(booking);
        }

        public List<BookingModel> ShowAllBookings()
        {
            return _movieBooking.BookingList();

        }
    }
}
