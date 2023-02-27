using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyGunizinTemp
    {
        public int Idno { get; set; }
        public string Kladi { get; set; } = null!;
        public int Srkodu { get; set; }
        public string Prsicil { get; set; } = null!;
        public string Neden { get; set; } = null!;
        public DateTime Bastarih { get; set; }
        public double? Gun { get; set; }
        public DateTime Bittarih { get; set; }
        public DateTime? Isbasi { get; set; }
        public string? Sebep { get; set; }
        public string? Sebep2 { get; set; }
        public string? Aciklama { get; set; }
    }
}
