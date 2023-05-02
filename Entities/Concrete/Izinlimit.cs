using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Izinlimit
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public short Clkodu { get; set; }
        public string? Tip { get; set; }
        public DateTime? Saat { get; set; }
        public short? Gun { get; set; }
        public string? Sec { get; set; }
        public double? LimitSure { get; set; }
        public short? Trnclkodu { get; set; }
        public string? PersonelGrubu { get; set; }
        public bool? YillikIzinKontrol { get; set; }
        public bool? ParcaliKullanim { get; set; }
        public string? IzinTuru { get; set; }
        public string? YenilemePeriyodu { get; set; }
        public DateTime? GunlukLimitSure { get; set; }
        public bool? IzinGiris { get; set; }
        public bool? GunlukPuantaj { get; set; }
        public bool? AylikPuantaj { get; set; }
        public double? AylikLimitSure { get; set; }
    }
}
