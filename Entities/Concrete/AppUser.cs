using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class AppUser : IEntity
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int RolID { get; set; } = 1;
        public string UserPassword { get; set; }
        public string UserPasswordConfirm { get; set; }
    }
}