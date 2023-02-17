using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{

    [Route("giris")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        
        
        [Route("")]
        [HttpPost]
        public IActionResult Index(LoginViewModel loginvm)
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