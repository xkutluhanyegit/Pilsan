using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AppUserOperationClaim
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public int AppOperationClaimId { get; set; }
    }
}