using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class AppRole : IEntity
    {
        [Key]
        public int RolID { get; set; }
        public string RolName { get; set; }
    }
}