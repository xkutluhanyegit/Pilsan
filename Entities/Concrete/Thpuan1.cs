using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Thpuan1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public short Yil { get; set; }
        public short Ay { get; set; }
        public DateTime Bastar { get; set; }
        public DateTime Bittar { get; set; }
        public short Clkodu { get; set; }
        public short? Topgun { get; set; }
        public string? Sure { get; set; }
    }
}
