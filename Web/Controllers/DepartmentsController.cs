using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant.DepartmentsCodes;
using Core.Constant;
using Entities.Concrete;
using Entities.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;

namespace Web.Controllers
{
    [Route("departmanlar")]
    [Authorize(Roles ="Admin,akulu,planlama")]
    
    public class DepartmentsController : Controller
    {
        private readonly ILogger<DepartmentsController> _logger;
        private readonly IPersonelService _personelService;
        private readonly IShiftService _shiftService;
        private readonly IPersonelShiftService _personelShiftService;

        private readonly IPersonelOvertimeService _personelOvertimeService;


        public DepartmentsController(ILogger<DepartmentsController> logger, IPersonelService personelService, IShiftService shiftService, IPersonelShiftService personelShiftService,IPersonelOvertimeService personelOvertimeService)
        {
            _logger = logger;
            _personelService = personelService;
            _shiftService = shiftService;
            _personelShiftService = personelShiftService;
            _personelOvertimeService=personelOvertimeService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.battery_installation = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.battery_installation,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.injection = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.injection,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.molding_room = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.molding_room,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.toy_assembly = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.toy_assembly,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.puffing = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.puffing,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.warehouse = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.warehouse,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.furniture = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.furniture,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.maintenance = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.maintenance,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.accept = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.accept,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.press_shop = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.press_shop,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.rotation = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.rotation,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.planning = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.planning,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.security = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.security,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.semi_product = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.semi_product,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.quality = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.quality,WeekofDay.dayNow).Data.ToList().Count();
            ViewBag.dining_hall = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,DepartmentsCode.dining_hall,WeekofDay.dayNow).Data.ToList().Count();






            return View();
        }

        [HttpGet("departman")]
        public IActionResult department(string id, string departmentname)
        {
            DepartmentsDetailViewModel d = new DepartmentsDetailViewModel();

            var result = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow, id,WeekofDay.dayNow);

            if (result.Success)
            {
                TempData["depID"]=id;
                //NowWeek List
                d.GetAllWeekNowDepartmentPersonelDetailDto = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow, id,WeekofDay.dayNow).Data.ToList();

                //NextWeek List
                d.GetAllWeekNextDepartmentPersonelDetailDto = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNext, id,WeekofDay.dayNow).Data.ToList();

                var NextWeekShiftList = d.GetAllWeekNextDepartmentPersonelDetailDto.Where(p => p.WeekofYear == WeekofDay.weekNext).ToList();

                //Need Refactoring Yeni hafta Atanmaış
                d.GetAllWeekNextNoShiftDepartmentPersonelDetailDto = d.GetAllWeekNowDepartmentPersonelDetailDto.Where(p=> !NextWeekShiftList.Any(l=>p.RegisterNo == l.RegisterNo)).ToList();

                //NextWeek List Show
                d.GetAllWeekNextYesShiftDepartmentPersonelDetailDto = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNext,id,WeekofDay.dayNow).Data.Where(p=>p.WeekofYear == WeekofDay.weekNext).ToList();
                
                d.GetAllWeekNowNoOvertimeDepartmentPersonelDetailDto = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,id,WeekofDay.dayNow).Data.Where(p=>p.OvertimeID == null & (p.ShiftID == 1 | p.ShiftID == 2)).ToList();
                d.GetAllWeekNowYesOvertimeDepartmentPersonelDetailDto = _personelService.GetAllDepartmentPersonelDetailDto(WeekofDay.weekNow,id,WeekofDay.dayNow).Data.Where(p=>p.OvertimeID!=null).ToList();

                //Shift List
                d.GetAllShiftList = _shiftService.GetAllShift().Data.ToList();
                return View(d);
            }
            return View();
        }

        [HttpPost("vardiya-ekle")]
        public IActionResult department_shift_add(DepartmentsDetailViewModel personelList, int shiftID)
        {
            var result = personelList.GetAllWeekNextNoShiftDepartmentPersonelDetailDto;

            foreach (var item in result)
            {
                Personelshift p = new Personelshift();
                if (item.Check & (item.NextWeekShiftID != null & item.NextWeekShiftID != 0))
                {
                    p.Sicilno = item.RegisterNo;
                    p.Shiftid = item.NextWeekShiftID;
                    _personelShiftService.Add(p);

                }
                else
                {

                }
            }
            return RedirectToAction("index", "departments");
        }

        [HttpPost("vardiya-sil")]
        public IActionResult department_shift_delete(DepartmentsDetailViewModel personelList)
        {
          var result = personelList.GetAllWeekNextYesShiftDepartmentPersonelDetailDto.ToList();

          foreach (var item in result)
          {
            if (item.Check)
            {
                Personelshift p = new Personelshift();
                p.Sicilno = item.RegisterNo;
                p.WeekOfYear = item.WeekofYear;
                _personelShiftService.Delete(p);
            }
          }
          return RedirectToAction("index","departments");
        }

        [HttpPost("mesai-ekle")]
        public IActionResult department_overtime_add(DepartmentsDetailViewModel personelList, int OvertimeID,string OvertimeDay)
        {
          var result = personelList.GetAllWeekNowNoOvertimeDepartmentPersonelDetailDto;

          foreach (var item in result)
          {
            if (item.Check)
            {
                Personelovertime p = new Personelovertime();
                p.Sicilno = item.RegisterNo;
                p.Overtimeid = OvertimeID;
                p.WeekOfYear = item.WeekofYear;
                p.Overtimeday = OvertimeDay;
                _personelOvertimeService.Add(p);

            }
            else{
                return RedirectToAction("index","departments");
            }
          }
          return RedirectToAction("index","departments");
          
        }

        [HttpPost("mesai-sil")]
        public IActionResult department_overtime_delete(DepartmentsDetailViewModel personelList)
        {
            var result = personelList.GetAllWeekNowYesOvertimeDepartmentPersonelDetailDto;

            foreach (var item in result)
            {
                if (item.Check)
                {
                    Personelovertime p = new Personelovertime();
                    p.Sicilno = item.RegisterNo;
                    p.Overtimeday = DateTime.Now.ToShortDateString();
                    _personelOvertimeService.Delete(p);
                }
            }
          
          return RedirectToAction("index","departments");
        }



        [HttpPost("vardiya-guncelle")]
        public IActionResult department_shift_update(string RegisterNo, int Week, int ShiftID)
        {
            var personel = _personelShiftService.Get(RegisterNo,Week).Data;
            personel.Shiftid = ShiftID;
            var result = _personelShiftService.Update(personel);

            
          return RedirectToAction("index","departments");
        }

        [HttpGet("gelecek-vardiya-plani")]
        public IActionResult next_week_shift(int shiftID, string department)
        {
          var result = _personelService.GetAllDepartmentPersonelDetailDtoWithShiftID(WeekofDay.weekNext,department,shiftID,WeekofDay.dayNow);
          if (result.Success)
          {
            return View(result.Data);
          }
          return View();
        }

        [HttpPost("fazla-mesai-gune-gore")]
        public JsonResult methodName(string date)
        {
          
          return Json(null);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}