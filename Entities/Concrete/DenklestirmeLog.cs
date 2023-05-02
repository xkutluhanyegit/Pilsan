using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class DenklestirmeLog
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public int? Yil { get; set; }
        public int? Ay { get; set; }
        public string? Prsicil { get; set; }
        public int? Fmclkodu { get; set; }
        public DateTime? Fmtarih { get; set; }
        public DateTime? Fmorjsure { get; set; }
        public DateTime? Fmkalansure { get; set; }
        public int? Iznclkodu { get; set; }
        public DateTime? Izntarih { get; set; }
        public DateTime? Iznorjsure { get; set; }
        public DateTime? Iznkalansure { get; set; }
        public DateTime? IslemZamani { get; set; }
    }
}
