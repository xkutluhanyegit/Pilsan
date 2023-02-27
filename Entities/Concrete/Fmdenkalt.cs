using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Fmdenkalt
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Pertipi { get; set; } = null!;
        public int Clkodu { get; set; }
        public string? Tipi { get; set; }
        public int Aktar { get; set; }
        public decimal Carpan { get; set; }
    }
}
