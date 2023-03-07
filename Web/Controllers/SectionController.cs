using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant.Messages;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;

namespace Web.Controllers
{
    [Route("bolumler")]
    [Authorize]
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
            ViewBag.furniture = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.furniture).Data.Count();
            ViewBag.maintenance = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.maintenance).Data.Count();
            ViewBag.accepnt_goods = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.accepnt_goods).Data.Count();
            ViewBag.press_shop = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.press_shop).Data.Count();
            ViewBag.rotation = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.rotation).Data.Count();
            ViewBag.planning = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.planning).Data.Count();


            return View();
        }



        [HttpGet("akulu-montaj")]
        [Authorize(Roles = "akulu-montaj,admin,ik")]
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
        [Authorize(Roles = "akulu-montaj,admin")]
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
        [Authorize(Roles = "akulu-montaj,admin")]
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
        [Authorize(Roles = "akulu-montaj,admin")]
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


        [HttpGet("getJsonbattery_installation_shift_remove")]
        [Authorize(Roles = "akulu-montaj,admin")]
        public IActionResult getJsonbattery_installation_shift_remove(Personel1 personel)
        {
            var res = _personelService.RemUpdate(personel);
            if (res.Success)
            {
                return RedirectToAction("battery_installation_shift", "section");
            }
            return View();
        }

        [HttpGet("akulu-montaj-shift-1")]
        [Authorize(Roles = "akulu-montaj,admin")]
        public IActionResult battery_installation_shift1()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }





        [HttpGet("enjeksiyon")]
        [Authorize(Roles = "enjeksiyon,admin,ik")]
        public IActionResult injection()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.injection);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }
        [HttpGet("enjeksiyon-vardiya")]
        [Authorize(Roles = "enjeksiyon,admin")]
        public IActionResult injection_shift()
        {
            var res = _personelService.GetByNoShiftPersonelDetailDto(DepartmanCode.injection);

            if (res.Success)
            {
                PersonelDetailViewModel pdvm = new PersonelDetailViewModel();
                pdvm.personelDetailViewModelList = res.Data.ToList();
                return View(pdvm);
            }

            return View();

        }

        [HttpPost("enjeksiyon-vardiya")]
        [Authorize(Roles = "enjeksiyon,admin")]
        public IActionResult injection_shift(Personel1 personel)
        {
            var res = _personelService.Update(personel);
            if (res.Success)
            {
                return RedirectToAction("injection_shift", "section");
            }

            return View();
        }

        [HttpGet("getJsoninjection_shift")]
        [Authorize(Roles = "enjeksiyon,admin")]
        public JsonResult getJsoninjection_shift(int? id)
        {
            var res1 = _personelService.GetByYesShiftPersonelDetailDto(DepartmanCode.injection);
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

        [HttpGet("getJsoninjection_shift_remove")]
        [Authorize(Roles = "enjeksiyon,admin")]
        public IActionResult getJsoninjection_shift_remove(Personel1 personel)
        {
            var res = _personelService.RemUpdate(personel);
            if (res.Success)
            {
                return RedirectToAction("injection_shift", "section");
            }
            return View();
        }



        [HttpGet("kaliphane")]
        [Authorize(Roles = "kaliphane,admin,ik")]
        public IActionResult molding_room()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.molding_room);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("kaliphane-vardiya")]
        [Authorize(Roles = "kaliphane,admin")]
        public IActionResult molding_room_shift()
        {
            var res = _personelService.GetByNoShiftPersonelDetailDto(DepartmanCode.molding_room);

            if (res.Success)
            {
                PersonelDetailViewModel pdvm = new PersonelDetailViewModel();
                pdvm.personelDetailViewModelList = res.Data.ToList();
                return View(pdvm);
            }

            return View();

        }

        [HttpPost("kaliphane-vardiya")]
        [Authorize(Roles = "kaliphane,admin")]
        public IActionResult molding_room_shift(Personel1 personel)
        {
            var res = _personelService.Update(personel);
            if (res.Success)
            {
                return RedirectToAction("molding_room_shift", "section");
            }

            return View();
        }

        [HttpGet("getJsonmolding_room_shift")]
        [Authorize(Roles = "kaliphane,admin")]
        public JsonResult getJsonmolding_room_shift(int? id)
        {
            var res1 = _personelService.GetByYesShiftPersonelDetailDto(DepartmanCode.molding_room);
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

        [HttpGet("getJsonmolding_room_shift_remove")]
        [Authorize(Roles = "kaliphane,admin")]
        public IActionResult getJsonmolding_room_shift_remove(Personel1 personel)
        {
            var res = _personelService.RemUpdate(personel);
            if (res.Success)
            {
                return RedirectToAction("molding_room_shift", "section");
            }
            return View();
        }


        [HttpGet("oyuncak-montaj")]
        [Authorize(Roles = "oyuncak-montaj,admin,ik")]
        public IActionResult toy_assembly()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.toy_assembly);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("oyuncak-montaj-vardiya")]
        [Authorize(Roles = "oyuncak-montaj,admin")]
        public IActionResult toy_assembly_shift()
        {
            var res = _personelService.GetByNoShiftPersonelDetailDto(DepartmanCode.toy_assembly);

            if (res.Success)
            {
                PersonelDetailViewModel pdvm = new PersonelDetailViewModel();
                pdvm.personelDetailViewModelList = res.Data.ToList();
                return View(pdvm);
            }

            return View();

        }

        [HttpPost("oyuncak-montaj-vardiya")]
        [Authorize(Roles = "oyuncak-montaj,admin")]
        public IActionResult toy_assembly_shift(Personel1 personel)
        {
            var res = _personelService.Update(personel);
            if (res.Success)
            {
                return RedirectToAction("toy_assembly_shift", "section");
            }

            return View();
        }

        [HttpGet("getJsontoy_assembly_shift")]
        [Authorize(Roles = "oyuncak-montaj,admin")]
        public JsonResult getJsontoy_assembly_shift(int? id)
        {
            var res1 = _personelService.GetByYesShiftPersonelDetailDto(DepartmanCode.toy_assembly);
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

        [HttpGet("getJsontoy_assembly_shift_remove")]
        [Authorize(Roles = "oyuncak-montaj,admin")]
        public IActionResult getJsontoy_assemblt_shift_remove(Personel1 personel)
        {
            var res = _personelService.RemUpdate(personel);
            if (res.Success)
            {
                return RedirectToAction("toy_assembly_shift", "section");
            }
            return View();
        }

        [HttpGet("Şişirme")]
        [Authorize(Roles = "sisirme,admin,ik")]
        public IActionResult puffing()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.puffing);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("sisirme-vardiya")]
        [Authorize(Roles = "sisirme,admin")]
        public IActionResult puffing_shift()
        {
            var res = _personelService.GetByNoShiftPersonelDetailDto(DepartmanCode.puffing);

            if (res.Success)
            {
                PersonelDetailViewModel pdvm = new PersonelDetailViewModel();
                pdvm.personelDetailViewModelList = res.Data.ToList();
                return View(pdvm);
            }

            return View();

        }

        [HttpPost("sisirme-vardiya")]
        [Authorize(Roles = "sisirme,admin")]
        public IActionResult puffing_shift(Personel1 personel)
        {
            var res = _personelService.Update(personel);
            if (res.Success)
            {
                return RedirectToAction("puffing_shift", "section");
            }

            return View();
        }

        [HttpGet("getJsonpuffing_shift")]
        [Authorize(Roles = "sisirme,admin")]
        public JsonResult getJsonpuffing_shift(int? id)
        {
            var res1 = _personelService.GetByYesShiftPersonelDetailDto(DepartmanCode.puffing);
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

        [HttpGet("getJsonpuffing_shift_remove")]
        [Authorize(Roles = "sisirme,admin")]
        public IActionResult getJsonpuffing_shift_remove(Personel1 personel)
        {
            var res = _personelService.RemUpdate(personel);
            if (res.Success)
            {
                return RedirectToAction("puffing_shift", "section");
            }
            return View();
        }
        [HttpGet("sevkiyat-depo")]
        [Authorize(Roles = "sevkiyat-depo,admin,ik")]
        public IActionResult warehouse()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.warehouse);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("sevkiyat-vardiya")]
        [Authorize(Roles = "sevkiyat-depo,admin")]
        public IActionResult warehouse_shift()
        {
            var res = _personelService.GetByNoShiftPersonelDetailDto(DepartmanCode.warehouse);

            if (res.Success)
            {
                PersonelDetailViewModel pdvm = new PersonelDetailViewModel();
                pdvm.personelDetailViewModelList = res.Data.ToList();
                return View(pdvm);
            }

            return View();

        }

        [HttpPost("sevkiyat-vardiya")]
        [Authorize(Roles = "sevkiyat-depo,admin")]
        public IActionResult warehouse_shift(Personel1 personel)
        {
            var res = _personelService.Update(personel);
            if (res.Success)
            {
                return RedirectToAction("warehouse_shift", "section");
            }

            return View();
        }

        [HttpGet("getJsonwarehouse_shift")]
        [Authorize(Roles = "sevkiyat-depo,admin")]
        public JsonResult getJsonwarehouse_shift(int? id)
        {
            var res1 = _personelService.GetByYesShiftPersonelDetailDto(DepartmanCode.warehouse);
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

        [HttpGet("getJsonwarehouse_shift_remove")]
        [Authorize(Roles = "sevkiyat-depo,admin")]
        public IActionResult getJsonwarehouse_shift_remove(Personel1 personel)
        {
            var res = _personelService.RemUpdate(personel);
            if (res.Success)
            {
                return RedirectToAction("warehouse_shift", "section");
            }
            return View();
        }

        [HttpGet("mobilya")]
        public IActionResult furniture()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.furniture);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("bakim-onarim")]
        public IActionResult maintenance()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.maintenance);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("mal-kabul")]
        public IActionResult accept_goods()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.accepnt_goods);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("preshane")]
        public IActionResult press_shop()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.press_shop);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("rotasyon")]
        public IActionResult rotation()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.rotation);
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("planlama")]
        public IActionResult planning()
        {
            var res = _personelService.GetByDepaartPrsonelDetailDto(DepartmanCode.planning);
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