using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAppUserService
    {
        List<AppOperationClaim> GetClaims(AppUser user);
        void Add(AppUser user);
        AppUser GetByMail(string email);
    }
}