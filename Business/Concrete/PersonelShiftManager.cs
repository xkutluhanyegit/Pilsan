using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant.Messages;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class PersonelShiftManager : IPersonelShiftService
    {
        IPersonelShiftDal _personelShiftDal;
        IPersonelService _personelDal;
        public PersonelShiftManager(IPersonelShiftDal personelShiftDal, IPersonelService personelDal)
        {
            _personelShiftDal = personelShiftDal;
            _personelDal = personelDal;
        }
        public IResult Add(PersonelDetailDto personelDetailDto, int shiftid)
        {

            Personelshift ps = new Personelshift();
            var getPersonel = _personelDal.Get(personelDetailDto.SicilNo).Data;

            //Mapper
            ps.SicilNo = getPersonel.Sicilno;
            ps.Author = personelDetailDto.Author;
            ps.DeptCode = getPersonel.Depart;
            ps.ServiceCode = personelDetailDto.ServiceId;
            ps.StationCode = personelDetailDto.StationId;
            ps.ShiftCode = shiftid;

            var WeekOfYear = (DateTime.Now.DayOfYear + 1) / 7;
            ps.WeekOfYear = WeekOfYear;

            _personelShiftDal.Add(ps);

            return new SuccessResult(Message.AddedSuccess);
        }
    }
}