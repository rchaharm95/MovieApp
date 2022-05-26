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
    public class UserController : ControllerBase
    {
        UserService _userServices;

        public UserController(UserService userService)
        {
            _userServices = userService;
        }

        [HttpGet("SelectUsers")]
        public IActionResult SelectUsers()
        {
            return Ok(_userServices.SelectUser());
        }

        [HttpPost("Register")]
        public IActionResult Register(UserModel userModel)
        {
            return Ok(_userServices.Register(userModel));
        }

        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser(int id)
        {
            return Ok(_userServices.DeleteUser(id));
        }
    }
}
