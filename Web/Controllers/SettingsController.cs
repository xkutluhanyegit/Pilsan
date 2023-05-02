using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;

namespace Web.Controllers
{
    [Route("ayarlar")]
    [Authorize(Roles ="Admin")]
    public class SettingsController : Controller
    {
        private readonly ILogger<SettingsController> _logger;
        private readonly UserManager<AppUser> _appUser;
        private readonly RoleManager<AppRole> _appRole;

        public SettingsController(ILogger<SettingsController> logger,UserManager<AppUser> appUser,RoleManager<AppRole> appRole)
        {
            _logger = logger;
            _appUser = appUser;
            _appRole = appRole;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public async Task<IActionResult> Index(SignUpVM signUpVM)
        {
           var identityResult = await _appUser.CreateAsync( new(){
                UserName = signUpVM.email,
                Email=signUpVM.email,

            },signUpVM.password);

            if (identityResult.Succeeded)
            {
                return View();
            }
            return View();
        }

        [HttpGet("rol-ekle")]
        public IActionResult Roles()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        [HttpPost("rol-ekle")]
        public async Task<IActionResult> Roles(string rolname)
        {
          var result = await _appRole.CreateAsync( new AppRole()
          {
            Name = rolname
          });
          if (result.Succeeded)
          {
            return RedirectToAction("index","home");
          }
          
          return View();
        }

        [HttpGet("kullanici-rol-atama")]
        public async Task<IActionResult> AssignRoleToUser(string id)
        {
          var currentUser = await _appUser.FindByIdAsync(id);
          var roles = _appRole.Roles.ToList();
          var rolesVM = new List<AssignRoleToUserVM>();

          foreach (var item in roles)
          {
            
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