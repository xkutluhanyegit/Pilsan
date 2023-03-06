using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IAppUserDal : IEntityRepository<AppUser>
    {
        List<AppOperationClaim> GetClaims(AppUser user);
    }
}