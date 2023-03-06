using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAppUserDal : EfEntityRepositoryBase<AppUser, AppDbContext>, IAppUserDal
    {
        public List<AppOperationClaim> GetClaims(AppUser user)
        {
            using (var context = new AppDbContext())
            {
                var result = from operationClaim in context.appOperationClaims
                             join userOperationClaim in context.appUserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.AppOperationClaimId
                             where userOperationClaim.AppUserId == user.ID
                             select new AppOperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}