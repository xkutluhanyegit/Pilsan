using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
    public partial class Shift:IEntity
    {
        public int Id { get; set; }
        public int Shiftid { get; set; }
        public string? Shiftname { get; set; }
        public string? Starthour { get; set; }
        public string? Endhour { get; set; }
    }
}
