using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTestDal : EFEntityRepositoryBase<Test, AppDbContext>, ITestDal
    {
        public List<TestDetailDto> GetTestDetailDto()
        {
            // var res = from .....
            //     ....
            //     ...
            //     ..

            // return List.ToList();

            return null;
        }
    }
}