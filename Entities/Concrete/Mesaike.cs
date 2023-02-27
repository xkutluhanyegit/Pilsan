using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Mesaike
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public int? Bagno { get; set; }
        public short Clkodu { get; set; }
        public string Islem { get; set; } = null!;
        public short? Sira { get; set; }
    }
}
