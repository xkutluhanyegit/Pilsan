using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant.Messages;
using Core.Constant;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PersonelOvertimeManager : IPersonelOvertimeService
    {
        IPersonelOvertimeDal _personelOvertimeDal;
        public PersonelOvertimeManager(IPersonelOvertimeDal personelOvertimeDal)
        {
            _personelOvertimeDal = personelOvertimeDal;
        }
        public IResult Add(Personelovertime personelovertime)
        {
            personelovertime.Createdat = WeekofDay.dayNow;
            _personelOvertimeDal.Add(personelovertime);
            return new SuccessResult(Messages.AddedSuccessMessage);
        }

        public IResult Delete(Personelovertime personelovertime)
        {
            var personel = _personelOvertimeDal.Get(s=>s.Sicilno == personelovertime.Sicilno & s.Overtimeday == personelovertime.Overtimeday);
            _personelOvertimeDal.Delete(personel);
            return new SuccessResult();
        }
    }
}