using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NToastNotify;
using Web.Models;

namespace Web.Controllers
{
    [Route("kayit")]
    public class RegisterController : Controller
    {
        private readonly ILogger<RegisterController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IToastNotification _toastNotification;
        private readonly INotyfService _notyf;


        public RegisterController(ILogger<RegisterController> logger, UserManager<AppUser> userManager, IToastNotification toastNotification, INotyfService notyf, RoleManager<AppRole> roleManager)
        {
            _logger = logger;
            _userManager = userManager;
            _toastNotification = toastNotification;
            _notyf = notyf;
            _roleManager = roleManager;
        }

        [HttpGet("")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        [Route("")]
        public async Task<IActionResult> Index(RegisterViewModel registervm)
        {
            var identityResult = await _userManager.CreateAsync(new()
            {
                UserName = registervm.email,
                Email = registervm.email,
                PhoneNumber = "555555555",
            }, registervm.password);



            if (identityResult.Succeeded)
            {
                _notyf.Success("Kayıt olma işlemi başarıyla gerçekleşti!");
                _notyf.Information("Giriş ekranına yönlendiriliyorsunuz!");
                return RedirectToAction("index", "login");

            }

            foreach (IdentityError item in identityResult.Errors)
            {
                // ModelState.AddModelError("UserName",)
                _notyf.Error("Email ya da kullanıcı adı geçersiz!");
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