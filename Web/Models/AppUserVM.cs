using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Web.Models
{
    public class AppUserVM : AppUser
    {
        public List<AppRole> roles { get; set; }
    }
}