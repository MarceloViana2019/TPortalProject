using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPortalProject.Application.DTO;
using TPortalProject.Application.Interfaces;

namespace TPortalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userService.GetAll());
        }

        [HttpPost, AllowAnonymous]
        public IActionResult Post(UserDTO user)
        {
            return Ok(_userService.Post(user));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_userService.GetById(id));
        }

        [HttpPost("authenticate"), AllowAnonymous]
        public IActionResult Atuthenticate(UserAuthRequestDTO userDTO)
        {
            return Ok(_userService.Authenticate(userDTO));
        }
    }
}
