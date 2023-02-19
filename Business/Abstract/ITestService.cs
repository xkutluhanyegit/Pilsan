using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ITestService
    {
        IResult Add(Test test);
        IDataResult<TestDetailDto> GetTestDetailDto();

    }
}