using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IPersonelDal : IEntityRepository<Personel1>
    {
        List<PersonelDetailDto> GetAllPersonelDetailDto();
    }
}