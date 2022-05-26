using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Business.Services;
using MovieApp.Entity;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        MovieService _movieServices;

        public MovieController(MovieService movieServices)
        {
            _movieServices = movieServices;
        }

        [HttpGet("SelectMovie")]
        public IActionResult SelectMovie()
        {
            return Ok(_movieServices.SelectMovie());
        }

        [HttpPost("AddMovie")]
        public IActionResult AddMovie(MovieModel movieModel)
        {
            return Ok(_movieServices.AddMovie(movieModel));
        }

        [HttpDelete("DeleteMovie")]
        public IActionResult DeleteMovie(int id)
        {
            return Ok(_movieServices.DeleteMovie(id));
        }
    }
}
