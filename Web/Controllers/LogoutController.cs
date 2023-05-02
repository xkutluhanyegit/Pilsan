using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    [Route("cikis")]
    public class LogoutController : Controller
    {
        private readonly ILogger<LogoutController> _logger;
        private readonly SignInManager<AppUser> _signInManager;

        public LogoutController(ILogger<LogoutController> logger,SignInManager<AppUser> signInManager)
        {
            _logger = logger;
            _signInManager = signInManager;
        }

        [HttpGet()]
        public IActionResult Index()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("index","login");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}