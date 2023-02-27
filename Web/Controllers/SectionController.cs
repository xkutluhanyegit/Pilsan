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

namespace Web.Controllers
{
    [Route("bolumler")]
    public class SectionController : Controller
    {
        private readonly ILogger<SectionController> _logger;
        IPersonelService _personelService;

        public SectionController(ILogger<SectionController> logger, IPersonelService personelService)
        {
            _logger = logger;
            _personelService = personelService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.battery_installation = _personelService.GetPersonelInfoDtoByDepId(DepartmanCode.battery_installation).Data.Count();
            ViewBag.injection = _personelService.GetPersonelInfoDtoByDepId(DepartmanCode.injection).Data.Count();
            ViewBag.molding_room = _personelService.GetPersonelInfoDtoByDepId(DepartmanCode.molding_room).Data.Count();
            ViewBag.toy_assembly = _personelService.GetPersonelInfoDtoByDepId(DepartmanCode.toy_assembly).Data.Count();
            ViewBag.puffing = _personelService.GetPersonelInfoDtoByDepId(DepartmanCode.puffing).Data.Count();
            ViewBag.warehouse = _personelService.GetPersonelInfoDtoByDepId(DepartmanCode.warehouse).Data.Count();

            return View();
        }

        [HttpGet("akulu-montaj")]
        public IActionResult battery_installation()
        {
            var res = _personelService.GetPersonelInfoDtoByDepId(DepartmanCode.battery_installation);
            if (res.Success)
            {

                return View(res.Data);
            }
            return View();
        }

        [HttpGet("akulu-montaj-vardiya")]
        public IActionResult battery_installation_shift()
        {
            var res = _personelService.GetPersonelInfoDtoByDepId(DepartmanCode.battery_installation);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpPost("akulu-montaj-vardiya")]
        public IActionResult battery_installation_shift(PersonelInfoShift personelInfoShift)
        {

            return View();
        }



        [HttpGet("enjeksiyon")]
        public IActionResult injection()
        {
            var res = _personelService.GetPersonelInfoDtoByDepId(DepartmanCode.injection);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("kaliphane")]
        public IActionResult molding_room()
        {
            var res = _personelService.GetPersonelInfoDtoByDepId(DepartmanCode.molding_room);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("oyuncak-montaj")]
        public IActionResult toy_assembly()
        {
            var res = _personelService.GetPersonelInfoDtoByDepId(DepartmanCode.toy_assembly);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("Şişirme")]
        public IActionResult puffing()
        {
            var res = _personelService.GetPersonelInfoDtoByDepId(DepartmanCode.puffing);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }
        [HttpGet("sevkiyat-depo")]
        public IActionResult warehouse()
        {
            var res = _personelService.GetPersonelInfoDtoByDepId(DepartmanCode.warehouse);
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