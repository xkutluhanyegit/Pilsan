using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Mesai
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public string Pertip { get; set; } = null!;
        public short Clkodu { get; set; }
        public short? Sira { get; set; }
    }
}
