using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Web.Models;

namespace Web.Controllers
{

    [Route("giris")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IToastNotification _toastNotification;
        private readonly INotyfService _notyf;



        public LoginController(ILogger<LoginController> logger, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, INotyfService notyf)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _notyf = notyf;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }



        [Route("")]
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel? loginvm, string? returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Action("index", "home");

            var hasUser = await _userManager.FindByEmailAsync(loginvm.email);
            if (hasUser == null)
            {
                _notyf.Error("Email veya şifre yanlış!");
                return View();
            }
            var result = await _signInManager.PasswordSignInAsync(hasUser, loginvm.password, false, false);
            if (result.Succeeded)
            {
                _notyf.Success("Giriş işlemi başarıyla gerçekleşti!");
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