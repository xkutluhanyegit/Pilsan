using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Varcali
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public short Vrkodu { get; set; }
        public short Clkodu { get; set; }
        public DateTime? Sure { get; set; }
        public string? Durum { get; set; }
        public DateTime? Bassaat { get; set; }
        public DateTime? Bitsaat { get; set; }
    }
}
