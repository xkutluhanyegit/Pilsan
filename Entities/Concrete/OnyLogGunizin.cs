using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyLogGunizin
    {
        public int Idno { get; set; }
        public int? OnyIdno { get; set; }
        public int? Srkodu { get; set; }
        public string? Prsicil { get; set; }
        public string? Neden { get; set; }
        public DateTime? Bastarih { get; set; }
        public double? Gun { get; set; }
        public DateTime? Bittarih { get; set; }
        public DateTime? Isbasi { get; set; }
        public string? Sebep { get; set; }
        public string? Sebep2 { get; set; }
        public string? Aciklama { get; set; }
        public string? Kullanici { get; set; }
        public int? Derece { get; set; }
        public bool? Onay { get; set; }
        public DateTime? IslemZamani { get; set; }
    }
}
