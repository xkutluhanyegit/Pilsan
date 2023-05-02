using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPersonelShiftService
    {
        IResult Add(Personelshift personelShift);
        IResult Delete(Personelshift personelShift);
        IResult Update(Personelshift personelshift);
        IDataResult<Personelshift> Get(string Sicilno, int week);
    }
}