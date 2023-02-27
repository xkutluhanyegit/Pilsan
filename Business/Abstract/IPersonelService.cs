using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IPersonelService
    {
        IDataResult<List<Personel1>> GetAll();
        IDataResult<List<PersonelInfoDto>> GetPersonelInfoDto();
        IDataResult<List<PersonelInfoDto>> GetPersonelInfoDtoByDepId(string depID);
    }
}