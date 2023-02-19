using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ITestDal : IEntityRepository<Test>
    {
        List<TestDetailDto> GetTestDetailDto();
    }
}