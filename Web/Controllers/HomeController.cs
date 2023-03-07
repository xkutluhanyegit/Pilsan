using System.Diagnostics;
using AspNetCoreHero.ToastNotification.Abstractions;
using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IPersonelService _personelService;
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly INotyfService _notyf;


    public HomeController(ILogger<HomeController> logger, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, INotyfService notyf, IPersonelService personelService)
    {
        _logger = logger;
        _signInManager = signInManager;
        _userManager = userManager;
        _notyf = notyf;
        _personelService = personelService;
    }

    public IActionResult Index()
    {
        var res = _personelService.GetAll().Data.Count();
        ViewData["IK"] = _personelService.GetAll().Data.Count();
        ViewData["Section"] = 6;
        return View();
    }


    public IActionResult LogOut()
    {
        _signInManager.SignOutAsync();
        return RedirectToAction("index", "login");
    }
    public IActionResult unauth()
    {
        _notyf.Information("Yetkisiz giriş tespit edildi , Anasayfaya yönlendiriliyorsunuz!");
        return RedirectToAction("index", "home");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
