using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksCihazgrup
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public int GrupKodu { get; set; }
        public string? GrupAdi { get; set; }
        public string? GcKontrol { get; set; }
        public string? Turu { get; set; }
        public string? GrupTuru { get; set; }
    }
}
