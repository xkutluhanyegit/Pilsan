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
    public class PersonelShiftManager : IPersonelShiftService
    {
        IPersonelShiftDal _personelShiftDal;
        public PersonelShiftManager(IPersonelShiftDal personelShiftDal)
        {
            _personelShiftDal = personelShiftDal;
        }
        public IResult Add(Personelshift personelShift)
        {
            personelShift.Createday = DateTime.Now.ToShortDateString();
            var ShiftEnd = DateTime.Now;
            var ShiftStart = DateTime.Now;

            while (true)
            {
                if (ShiftStart.DayOfWeek == DayOfWeek.Monday)
                {
                    personelShift.Startday = ShiftStart.ToShortDateString();
                    personelShift.WeekOfYear = WeekofDay.weekNext;
                    //Vardiya
                    if (personelShift.Shiftid == 1 | personelShift.Shiftid == 5 | personelShift.Shiftid == 6)
                    {
                        personelShift.Endday = ShiftStart.AddDays(5).ToShortDateString();
                        break;
                    }
                    //Sabit
                    else if (personelShift.Shiftid == 2)
                    {
                        personelShift.Endday = ShiftStart.AddDays(4).ToShortDateString();
                        break;
                    }
                    
                }
                ShiftStart = ShiftStart.AddDays(1);
            }

            _personelShiftDal.Add(personelShift);
            return new SuccessResult(Messages.AddedSuccessMessage);
        }

        public IResult Delete(Personelshift personelshift)
        {
            var personel = _personelShiftDal.Get(p=>p.Sicilno == personelshift.Sicilno & p.WeekOfYear == personelshift.WeekOfYear);
            _personelShiftDal.Delete(personel);
            return new SuccessResult();
        }

        public IDataResult<Personelshift> Get(string Sicilno, int week)
        {
            var result = _personelShiftDal.Get(p=>p.Sicilno == Sicilno & p.WeekOfYear == week);
            return new SuccessDataResult<Personelshift>(result);
        }

        public IResult Update(Personelshift personelshift)
        {
            _personelShiftDal.Update(personelshift);
            return new SuccessResult();
        }
    }
}