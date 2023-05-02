using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Shfyedek
    {
        public int Sira { get; set; }
        public short Srkodu { get; set; }
        public string Kladi { get; set; } = null!;
        public DateTime Islemtarih { get; set; }
        public string Sicil { get; set; } = null!;
        public string Departman { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public short Vardiya { get; set; }
        public short Grup { get; set; }
        public string? Aciklama { get; set; }
    }
}
