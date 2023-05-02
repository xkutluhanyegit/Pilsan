using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Hpuantaj1
    {
        public string Prsicil { get; set; } = null!;
        public int? Hafta { get; set; }
        public DateTime Tarih { get; set; }
        public short Clkodu { get; set; }
        public short Vrkodu { get; set; }
        public short Pskodu { get; set; }
        public short? Drcno { get; set; }
        public string? Izahat { get; set; }
        public string? Onay { get; set; }
        public string? Neden { get; set; }
        public DateTime? Orjsure { get; set; }
        public DateTime? Sure { get; set; }
        public int Idno { get; set; }
        public bool? GunHesapla { get; set; }
    }
}
