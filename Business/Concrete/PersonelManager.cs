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
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public IDataResult<Personel1> Get(string sicilNo)
        {
            var res = _personelDal.Get(p => p.Sicilno == sicilNo);
            return new SuccessDataResult<Personel1>(res);
        }

        public IDataResult<List<Personel1>> GetAll()
        {
            var res = _personelDal.GetAll(p => p.Iscikt == null);
            return new SuccessDataResult<List<Personel1>>(res, Message.ListedSuccces);
        }

        public IDataResult<List<PersonelDetailDto>> GetAllPersonelDetailDto()
        {
            var res = _personelDal.GetAllPersonelDetailDto();
            return new SuccessDataResult<List<PersonelDetailDto>>(res, Message.ListedSuccces);
        }

        public IDataResult<List<PersonelDetailDto>> GetByDepaartPrsonelDetailDto(string DepId)
        {
            var res = _personelDal.GetAllPersonelDetailDto().Where(p => p.DepId == DepId).ToList();
            return new SuccessDataResult<List<PersonelDetailDto>>(res, Message.ListedSuccces);
        }

        public IDataResult<List<PersonelDetailDto>> GetByNoShiftPersonelDetailDto(string DepId)
        {
            int Week = (DateTime.Now.DayOfYear + 1) / 7;
            var res = _personelDal.GetAllPersonelDetailDto().Where(p => p.DepId == DepId && p.WeekOfYear != Week).ToList();
            return new SuccessDataResult<List<PersonelDetailDto>>(res, Message.ListedSuccces);
        }


        public IDataResult<List<PersonelDetailDto>> GetByYesShiftPersonelDetailDto(string DepId)
        {
            int Week = (DateTime.Now.DayOfYear + 1) / 7;
            var res = _personelDal.GetAllPersonelDetailDto().Where(p => p.DepId == DepId && p.WeekOfYear == Week).ToList();
            return new SuccessDataResult<List<PersonelDetailDto>>(res, Message.ListedSuccces);
        }

        public IResult RemUpdate(Personel1 personel)
        {
            var res = _personelDal.Get(p => p.Sicilno == personel.Sicilno);
            res.Weekofyear = 99;
            res.Shiftid = 99;
            _personelDal.Update(res);

            return new SuccessResult(Message.AddedSuccess);
        }

        public IResult Update(Personel1 personel)
        {
            var res = _personelDal.Get(p => p.Sicilno == personel.Sicilno);
            res.Weekofyear = (DateTime.Now.DayOfYear + 1) / 7;
            res.Shiftid = personel.Shiftid;
            _personelDal.Update(res);

            return new SuccessResult(Message.AddedSuccess);
        }
    }
}