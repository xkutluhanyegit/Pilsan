using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class DenklestirmeParamDetay
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public int? PrmIdno { get; set; }
        public int? Clkodu { get; set; }
        public double? Katsayi { get; set; }
        public int? DnkSure { get; set; }
        public string? DnkSureturu { get; set; }
        public string? Islemturu { get; set; }
        public string? Clturu { get; set; }
        public string? Iznturu { get; set; }
    }
}
