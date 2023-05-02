using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnySaatizinTemp
    {
        public int Idno { get; set; }
        public string Kladi { get; set; } = null!;
        public int Srkodu { get; set; }
        public string Prsicil { get; set; } = null!;
        public string Neden { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public DateTime Bassaat { get; set; }
        public DateTime? Saat { get; set; }
        public DateTime Bitsaat { get; set; }
        public string? Sebep { get; set; }
        public string? Sebep2 { get; set; }
        public string? Aciklama { get; set; }
    }
}
