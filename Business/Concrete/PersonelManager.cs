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

        public IDataResult<List<Personel1>> GetAll()
        {
            var res = _personelDal.GetAll(p => p.Iscikt == null);
            return new SuccessDataResult<List<Personel1>>(res, Message.ListedSuccces);
        }

        public IDataResult<List<PersonelInfoDto>> GetPersonelInfoDto()
        {
            var res = _personelDal.GetPersonelInfoDto();
            return new SuccessDataResult<List<PersonelInfoDto>>(res, Message.ListedSuccces);
        }

        public IDataResult<List<PersonelInfoDto>> GetPersonelInfoDtoByDepId(string depID)
        {
            var res = _personelDal.GetPersonelInfoDto().Where(p => p.DepartmanID == depID).ToList();
            return new SuccessDataResult<List<PersonelInfoDto>>(res, Message.ListedSuccces);
        }
    }
}