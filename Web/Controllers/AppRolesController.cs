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
    [Route("rol")]
    public class AppRolesController : Controller
    {

        IAppRoleService _appRoleService;
        private readonly ILogger<AppRolesController> _logger;

        public AppRolesController(ILogger<AppRolesController> logger, IAppRoleService appRoleService)
        {
            _logger = logger;
            _appRoleService = appRoleService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var res = _appRoleService.GetAll();
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("ekle")]
        [Route("ekle")]
        public IActionResult add()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }

        [HttpPost("ekle")]
        [Route("ekle")]
        public IActionResult add(AppRole appRole)
        {
            var result = _appRoleService.Add(appRole);
            if (result.Success)
            {
                return RedirectToAction("index", "approles");
            }
            return View(appRole);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}