using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Constant;
using Entities.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;

namespace Web.Controllers
{
    [Route("insan-kaynaklari")]
    [Authorize(Roles ="Admin,IK")]
    
    public class HumanResourceController : Controller
    {
        private readonly ILogger<HumanResourceController> _logger;
        private readonly IPersonelService _personelService;

        public HumanResourceController(ILogger<HumanResourceController> logger, IPersonelService personelService)
        {
            _logger = logger;
            _personelService = personelService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var result = _personelService.GetAllHRPersonelDetailDto(WeekofDay.weekNow,WeekofDay.dayNow);
            if (result.Success)
            {

                HRDepartmentsDetailViewModel h = new HRDepartmentsDetailViewModel();
                h.GetAllHRPersonelDetailDto = _personelService.GetAllHRPersonelDetailDto(WeekofDay.weekNow,WeekofDay.dayNow).Data.ToList();

                return View(h);
            }
            else
            {
                return View(result.Message);
            }
        }

        [HttpGet("gelecek-vardiya-plani")]
        public IActionResult next_week_shift(int shiftId)
        {
            var result = _personelService.GetAllHRPersonelDetailDto(WeekofDay.weekNext,WeekofDay.dayNow);
            if (result.Success)
            {
                HRDepartmentsDetailViewModel h = new HRDepartmentsDetailViewModel();
                h.GetAllHRPersonelDetailShiftDto = result.Data.Where(p => p.ShiftID == shiftId).ToList();
                return View(h);
            }
            return View();
        }

        [HttpGet("fazla-mesai-dagilimi")]
        public IActionResult now_overtime(int overtimeId)
        {
            var result = _personelService.GetAllHRPersonelDetailDto(WeekofDay.weekNow,WeekofDay.dayNow);
            if (result.Success)
            {
                //Çıkış Saati
                //8 -6
                //16 -1
                //18 -2
                //20 -3
                //22 -4
                //24 -5
                HRDepartmentsDetailViewModel h = new HRDepartmentsDetailViewModel();

                List<HRPersonelDetailDto> list = new List<HRPersonelDetailDto>();

                foreach (var item in result.Data)
                {
                    if (item.OvertimeID != null & item.OvertimeID == overtimeId)
                    {
                        list.Add(item);
                    }
                    else if (item.OvertimeID == null)
                    {
                        if (item.ShiftID != null & item.ShiftID == overtimeId & item.WeekofYear == WeekofDay.weekNow)
                        {
                            list.Add(item);
                        }
                    }

                }

                return View(list);
                
            }


            return View();
        }

        [HttpGet("fazla-mesai-listesi-total")]
        public IActionResult now_overtime_total()
        {
            var result = _personelService.GetAllHRPersonelDetailDto(WeekofDay.weekNow,WeekofDay.dayNow);
            if (result.Success)
            {
                var list = result.Data.Where(p=>p.OvertimeDay == WeekofDay.dayNow).ToList();
                return View(list);
            }
          //TODO: Implement Realistic Implementation
          return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}