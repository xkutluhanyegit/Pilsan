using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class PersonalShift : IEntity
    {
        public int ShiftID { get; set; }
        public string ShiftName { get; set; }
    }
}