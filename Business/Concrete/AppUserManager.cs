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

namespace Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;
        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }
        public IResult Add(AppUser appUser)
        {

            _appUserDal.Add(appUser);
            return new SuccessResult(Message.AddedSuccess);
        }

        public IDataResult<List<AppUser>> GetAll()
        {
            var res = _appUserDal.GetAll();
            return new SuccessDataResult<List<AppUser>>(res, Message.AddedSuccess);
        }
    }
}