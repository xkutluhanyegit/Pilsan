using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
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
            var getPersonel = _personelDal.Get(personelDetailDto.SicilNo).Data;

            Personelshift ps = new Personelshift();

            ps.SicilNo = getPersonel.Sicilno;
            ps.Author = personelDetailDto.Author;
            ps.DeptCode = getPersonel.Depart;
            ps.ServiceCode = personelDetailDto.ServiceId;
            ps.StationCode = personelDetailDto.StationId;
            ps.ShiftCode = shiftid;
            ps.ShiftStart = DateTime.Now.ToShortDateString();
            ps.ShiftEnd = "";

            _personelShiftDal.Add(ps);
            return new SuccessResult();


        }
    }
}