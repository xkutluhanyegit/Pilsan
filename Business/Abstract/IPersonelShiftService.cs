using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IPersonelShiftService
    {
        IResult Add(PersonelDetailDto personelDetailDto, int shiftid);
    }
}