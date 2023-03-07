using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{

    [Route("insan-kaynaklari")]
    [Authorize]
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
        [Authorize(Roles = "ik,admin")]
        public IActionResult Index()
        {
            var res = _personelService.GetAllPersonelDetailDto();

            if (res.Success)
            {
                ViewBag.shift1 = res.Data.Where(p => p.ShiftId == 1).Count();
                ViewBag.shift2 = res.Data.Where(p => p.ShiftId == 2).Count();
                ViewBag.shift3 = res.Data.Where(p => p.ShiftId == 3).Count();
                ViewBag.shift4 = res.Data.Where(p => p.ShiftId == 4).Count();
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("shift1-detay")]
        [Authorize(Roles = "ik,admin")]
        public IActionResult shift1_detail()
        {
            var res = _personelService.GetAllPersonelDetailDto();
            if (res.Success)
            {
                var result = res.Data.Where(p => p.ShiftId == 1).ToList();

                var group = from k in result
                            group k by k.ServiceName;
                return View(group.ToList());
            }

            return View();
        }

        [HttpGet("shift2-detay")]
        [Authorize(Roles = "ik,admin")]
        public IActionResult shift2_detail()
        {
            var res = _personelService.GetAllPersonelDetailDto();
            if (res.Success)
            {
                var result = res.Data.Where(p => p.ShiftId == 2).ToList();

                var group = from k in result
                            group k by k.ServiceName;
                return View(group.ToList());
            }
            return View();
        }
        [HttpGet("shift3-detay")]
        [Authorize(Roles = "ik,admin")]
        public IActionResult shift3_detail()
        {
            var res = _personelService.GetAllPersonelDetailDto();
            if (res.Success)
            {
                var result = res.Data.Where(p => p.ShiftId == 3).ToList();

                var group = from k in result
                            group k by k.ServiceName;
                return View(group.ToList());
            }
            return View();
        }
        [HttpGet("shift4-detay")]
        [Authorize(Roles = "ik,admin")]
        public IActionResult shift4_detail()
        {
            var res = _personelService.GetAllPersonelDetailDto();
            if (res.Success)
            {
                var result = res.Data.Where(p => p.ShiftId == 4).ToList();

                var group = from k in result
                            group k by k.ServiceName;
                return View(group.ToList());
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