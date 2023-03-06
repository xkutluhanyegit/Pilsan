using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _userDal;

        public AppUserManager(IAppUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<AppOperationClaim> GetClaims(AppUser user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(AppUser user)
        {
            _userDal.Add(user);
        }

        public AppUser GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}