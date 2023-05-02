using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;

namespace Web.Controllers
{
    [Route("giris")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly UserManager<AppUser> _usermanager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(ILogger<LoginController> logger,UserManager<AppUser> usermanager,SignInManager<AppUser> signInManager)
        {
            _logger = logger;
            _usermanager = usermanager;
            _signInManager = signInManager;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public async Task<IActionResult> Index(LoginVM loginVM,string? returnUrl = null)
        {

            returnUrl = returnUrl ?? Url.Action("index", "home");

            var hasUser = await _usermanager.FindByEmailAsync(loginVM.email);
            if (hasUser == null)
            {
                
                return View();
            }
            var result = await _signInManager.PasswordSignInAsync(hasUser, loginVM.password, false, false);
            if (result.Succeeded)
            {
                
                return Redirect(returnUrl);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}