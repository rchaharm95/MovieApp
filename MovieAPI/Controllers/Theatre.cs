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
    public class TheatreController : ControllerBase
    {
        TheatreService _theatreService;

        public TheatreController(TheatreService theatreService)
        {
            _theatreService = theatreService;
        }

        [HttpGet("selectTheatre")]
        public IActionResult SelectTheatre()
        {
            return Ok(_theatreService.SelectTheatre());
        }

        [HttpPost("addTheatre")]
        public IActionResult AddTheatre(TheatreModel theatreModel)
        {
            return Ok(_theatreService.AddTheatre(theatreModel));
        }
    }
}
