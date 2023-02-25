using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    [Route("uretim")]
    public class ProductionDepartmentController : Controller
    {
        private readonly ILogger<ProductionDepartmentController> _logger;

        public ProductionDepartmentController(ILogger<ProductionDepartmentController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}