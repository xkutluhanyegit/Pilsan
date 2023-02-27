using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{

    [Route("insan-kaynaklari")]
    public class HumanResourceController : Controller
    {
        private readonly ILogger<HumanResourceController> _logger;
        IPersonelService _personelService;


        public HumanResourceController(ILogger<HumanResourceController> logger, IPersonelService personelService)
        {
            _logger = logger;
            _personelService = personelService;
        }

        [Route("")]
        public IActionResult Index()
        {
            // var res = _personelService.GetByActiveWorkers();
            // if (res.Success)
            // {
            //     ViewBag.Data = res.Data.Count;
            //     return View(res.Data);
            // }
            var res = _personelService.GetPersonelInfoDto();
            if (res.Success)
            {
                ViewBag.Data = res.Data.Count;
                return View(res.Data);
            }
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