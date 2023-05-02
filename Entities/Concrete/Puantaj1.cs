using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Puantaj1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public short Drcno { get; set; }
        public DateTime Tarih { get; set; }
        public short Clkodu { get; set; }
        public short Vrkodu { get; set; }
        public short Pskodu { get; set; }
        public DateTime? Sure { get; set; }
        public string? Izahat { get; set; }
        public string? Onay { get; set; }
        public string? Neden { get; set; }
        public DateTime? Orjsure { get; set; }
        public int? TpSure { get; set; }
        public bool? GunHesapla { get; set; }
        public DateTime? DnkOrjsure { get; set; }
        public string? DnkDonem { get; set; }
        public string? Kullanici { get; set; }
        public DateTime? Hesapzaman { get; set; }
    }
}
