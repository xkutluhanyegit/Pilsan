using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class KntAypuan1
    {
        public string Prsicil { get; set; } = null!;
        public short Yil { get; set; }
        public short Ay { get; set; }
        public short Clkodu { get; set; }
        public decimal? Topgun { get; set; }
        public string? Sure { get; set; }
        public short? Drcno { get; set; }
        public decimal? Ondsure { get; set; }
        public int Idno { get; set; }
    }
}
