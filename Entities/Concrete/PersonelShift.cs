using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
    public partial class PersonelShift : IEntity
    {
        public int Id { get; set; }
        public string SicilNo { get; set; } = null!;
        public int ShiftId { get; set; }
        public string DepId { get; set; } = null!;
        public string ServiceId { get; set; } = null!;
        public string StationId { get; set; } = null!;
        public int WeekOfYear { get; set; }
        public string? CreateDate { get; set; }
        public string? Author { get; set; }
    }
}
