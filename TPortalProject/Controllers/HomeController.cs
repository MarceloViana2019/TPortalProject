using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPortalProject.Application.Services.Interfaces;

namespace TPortalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_homeService.GetPrivateContent());
        }

    }
}
