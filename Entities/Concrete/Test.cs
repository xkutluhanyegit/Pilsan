using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Test:IEntity
    {
        public int TestID { get; set; }
        public string PersonelName { get; set; }
        public string PersonelDepartment { get; set; }
        
    }
}