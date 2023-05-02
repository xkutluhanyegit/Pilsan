using System.Diagnostics;
using Business.Abstract;
using Core.Constant;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;


[Authorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IPersonelService _personelService;


    
    public HomeController(ILogger<HomeController> logger,IPersonelService personelService)
    {
        _logger = logger;
        _personelService = personelService;
    }

    public IActionResult Index()
    {
        ViewBag.personelCount = _personelService.GetAllHRPersonelDetailDto(WeekofDay.weekNow,WeekofDay.dayNow).Data.ToList().Count();
        ViewBag.departmentsCount = "16";
        return View();
    }

    public IActionResult unauth()
    {
      //TODO: Implement Realistic Implementation
        return RedirectToAction("index","home");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
