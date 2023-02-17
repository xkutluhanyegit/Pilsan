using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
        
    [Route("insan-kaynaklari")]
    public class HumanResourceController : Controller
    {
        private readonly ILogger<HumanResourceController> _logger;

        
        public HumanResourceController(ILogger<HumanResourceController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("error")]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}