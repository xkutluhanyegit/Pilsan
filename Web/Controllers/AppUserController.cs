using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;

namespace Web.Controllers
{
    [Route("kullanici")]
    public class AppUserController : Controller
    {
        IAppUserService _appUserService;
        IAppRoleService _appRoleService;
        private readonly ILogger<AppUserController> _logger;

        public AppUserController(ILogger<AppUserController> logger, IAppUserService appUserService, IAppRoleService appRoleService)
        {
            _logger = logger;
            _appUserService = appUserService;
            _appRoleService = appRoleService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var res = _appUserService.GetAll();
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("ekle")]
        [Route("ekle")]
        public IActionResult Add()
        {
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