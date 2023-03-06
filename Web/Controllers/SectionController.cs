using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant.Messages;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;

namespace Web.Controllers
{
    [Route("bolumler")]
    public class SectionController : Controller
    {
        private readonly ILogger<SectionController> _logger;
        IPersonelService _personelService;
        IPersonelShiftService _personelShiftService;

        public SectionController(ILogger<SectionController> logger, IPersonelService personelService, IPersonelShiftService personelShiftService)
        {
            _logger = logger;
            _personelService = personelService;
            _personelShiftService = personelShiftService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.battery_installation = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.battery_installation).Data.Count();
            ViewBag.injection = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.injection).Data.Count();
            ViewBag.molding_room = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.molding_room).Data.Count();
            ViewBag.toy_assembly = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.toy_assembly).Data.Count();
            ViewBag.puffing = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.puffing).Data.Count();
            ViewBag.warehouse = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.warehouse).Data.Count();

            return View();
        }



        [HttpGet("akulu-montaj")]
        public IActionResult battery_installation()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.battery_installation);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }



        [HttpGet("akulu-montaj-vardiya")]
        public IActionResult battery_installation_shift()
        {
            var res = _personelService.GetByNoShiftPersonelDetailDto(DepartmanCode.battery_installation);

            if (res.Success)
            {
                PersonelDetailViewModel pdvm = new PersonelDetailViewModel();
                pdvm.personelDetailViewModelList = res.Data.ToList();
                return View(pdvm);
            }

            return View();

        }

        [HttpPost("akulu-montaj-vardiya")]
        public IActionResult battery_installation_shift(Personel1 personel)
        {
            var res = _personelService.Update(personel);
            if (res.Success)
            {
                return RedirectToAction("battery_installation_shift", "section");
            }

            return View();
        }

        [HttpGet("getJsonbattery_installation_shift")]
        public JsonResult getJsonbattery_installation_shift(int? id)
        {
            var res1 = _personelService.GetByYesShiftPersonelDetailDto(DepartmanCode.battery_installation);
            if (res1.Success)
            {
                if (id == null)
                {
                    var resullt = res1.Data.Where(p => p.ShiftId == 1).ToList();
                    return Json(resullt);
                }
                else
                {
                    var resullt = res1.Data.Where(p => p.ShiftId == id).ToList();
                    return Json(resullt);
                }
            }
            return null;
        }




        [HttpGet("enjeksiyon")]
        public IActionResult injection()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.injection);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("kaliphane")]
        public IActionResult molding_room()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.molding_room);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("oyuncak-montaj")]
        public IActionResult toy_assembly()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.toy_assembly);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("Şişirme")]
        public IActionResult puffing()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.puffing);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }
        [HttpGet("sevkiyat-depo")]
        public IActionResult warehouse()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.warehouse);
            if (res.Success)
            {
                return View(res.Data);
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