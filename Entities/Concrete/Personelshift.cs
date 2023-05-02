using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
    public partial class Personelshift:IEntity
    {
        public int Id { get; set; }
        public int Shiftid { get; set; }
        public string? Sicilno { get; set; }
        public string? Startday { get; set; }
        public string? Endday { get; set; }
        public string? Createday { get; set; }
        public int? WeekOfYear { get; set; }
        public bool? Relaesed { get; set; }
    }
}
