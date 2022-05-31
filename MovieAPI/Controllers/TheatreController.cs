using Microsoft.AspNetCore.Http;
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

        [HttpGet("SelectTheatre")]
        public IActionResult SelectTheatre()
        {
            return Ok(_theatreService.SelectTheatre());
        }

        [HttpPost("AddTheatre")]
        public IActionResult AddTheatre(TheatreModel theatreModel)
        {
            return Ok(_theatreService.AddTheatre(theatreModel));
        }

        [HttpPut("EditThetre")]
        public IActionResult EditThetre(TheatreModel theatreModel)
        {
            return Ok(_theatreService.EditTheatre(theatreModel));
        }

        [HttpGet("FetchTheatre")]
        public IActionResult FetchThetreById(int id)
        {
            return Ok(_theatreService.FetchTheatreById(id));
        }

        [HttpDelete("DeleteThetre")]
        public IActionResult DeleteThetre(int id)
        {
            return Ok(_theatreService.DeleteTheatre(id));
        }
    }
}
