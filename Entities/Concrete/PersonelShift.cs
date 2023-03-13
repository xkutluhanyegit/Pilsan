using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
    public partial class Personelshift : IEntity
    {
        public int Id { get; set; }
        public string? SicilNo { get; set; }
        public int? ShiftCode { get; set; }
        public string? StationCode { get; set; }
        public string? ServiceCode { get; set; }
        public string? DeptCode { get; set; }
        public string? ShiftStart { get; set; }
        public string? ShiftEnd { get; set; }
        public string? Author { get; set; }
        public int? WeekOfYear { get; set; }
    }
}
