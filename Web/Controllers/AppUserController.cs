using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    [Route("kullanici")]
    public class AppUserController : Controller
    {
        IAppUserService _appUserService;
        private readonly ILogger<AppUserController> _logger;

        public AppUserController(ILogger<AppUserController> logger, IAppUserService appUserService)
        {
            _logger = logger;
            _appUserService = appUserService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("ekle")]
        [Route("ekle")]
        public IActionResult Add()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }

        [HttpPost("ekle")]
        [Route("ekle")]
        public IActionResult Add(AppUser appUser)
        {
            var result = _appUserService.Add(appUser);
            if (result.Success)
            {
                return RedirectToAction("index", "AppUser");
            }

            return View(appUser);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}