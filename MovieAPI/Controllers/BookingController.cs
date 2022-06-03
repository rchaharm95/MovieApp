using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Business.Services;
using MovieApp.Entity;
using System.Collections.Generic;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        MovieBookingService _movieBookingService;


        public BookingController(MovieBookingService movieBookingService)
        {
            _movieBookingService = movieBookingService;
        }

        [HttpGet("Allbookings")]
        public IActionResult ShowAllBookings()
        {
            return Ok(_movieBookingService.ShowAllBookings());
        }

        [HttpPost("addbooking")]
        public IActionResult AddBooking(BookingModel booking)
        {
            return Ok(_movieBookingService.AddMovieBooking(booking));
        }

    }
}
