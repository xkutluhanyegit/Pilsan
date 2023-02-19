using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        ITestService _testService;
        public UsersController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var res = _testService.GetAll();
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }


        [HttpPost]
        public IActionResult Post(Test test)
        {
            var res = _testService.Add(test);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
    }
}