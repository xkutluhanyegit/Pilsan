using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyTaksiTemp
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Prsicil { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public DateTime? GlnSure { get; set; }
        public int Fmkodu { get; set; }
        public double? Ucret { get; set; }
        public string? Aciklama { get; set; }
        public string? Neden { get; set; }
        public double? Sure { get; set; }
    }
}
