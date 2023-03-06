using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonelShiftDal : EfEntityRepositoryBase<PersonelShift, PersonelCIContext>, IPersonelShiftDal
    {

    }
}