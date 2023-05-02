using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
    public partial class Overtime:IEntity
    {
        public int Id { get; set; }
        public int? Overtimeid { get; set; }
        public string? Overtimename { get; set; }
        public string? Endhour { get; set; }
        public string? Starthour { get; set; }
    }
}
