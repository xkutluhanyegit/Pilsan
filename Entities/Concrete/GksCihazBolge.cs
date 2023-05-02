using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksCihazBolge
    {
        public int Idno { get; set; }
        public string BolgeKodu { get; set; } = null!;
        public string? BolgeAdi { get; set; }
        public string? Turu { get; set; }
    }
}
