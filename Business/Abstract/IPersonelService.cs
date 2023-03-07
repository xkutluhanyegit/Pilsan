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
        IResult Update(Personel1 personel);
        IResult RemUpdate(Personel1 personel);

        IDataResult<Personel1> Get(string sicilNo);
        IDataResult<List<Personel1>> GetAll();
        IDataResult<List<PersonelDetailDto>> GetAllPersonelDetailDto();
        IDataResult<List<PersonelDetailDto>> GetByDepaartPrsonelDetailDto(string DepId);
        IDataResult<List<PersonelDetailDto>> GetByNoShiftPersonelDetailDto(string DepId);
        IDataResult<List<PersonelDetailDto>> GetByYesShiftPersonelDetailDto(string DepId);


    }
}