using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entity;

namespace MovieApp.Data.Repositories
{
    public interface IMovieBooking
    {
        public interface IBooking
        {
            public string AddBooking(BookingModel booking);

            public List<BookingModel> BookingList();
        }
    }
}
