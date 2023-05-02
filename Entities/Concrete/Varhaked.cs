using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Varhaked
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public short Vrkodu { get; set; }
        public short Clkodu { get; set; }
        public DateTime? Maxsure { get; set; }
        public DateTime? Haksure { get; set; }
        public short Kodu { get; set; }
    }
}
