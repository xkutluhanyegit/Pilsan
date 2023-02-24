using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class PersonelDepartman : IEntity
    {
        public int DepartmanID { get; set; }
        public string DepartmanName { get; set; }
    }
}