using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class KntGunizin1
    {
        public int Idno { get; set; }
        public int Linkid { get; set; }
        public string Prsicil { get; set; } = null!;
        public string Neden { get; set; } = null!;
        public DateTime Bastarih { get; set; }
        public double? Gun { get; set; }
        public DateTime Bittarih { get; set; }
        public string? Sebep { get; set; }
        public int? Trnid { get; set; }
        public DateTime? Isbasi { get; set; }
        public string? VekilSicilno { get; set; }
        public string? Aciklama { get; set; }
    }
}
