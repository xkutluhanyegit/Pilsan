using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Devamsiz
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public string Pertip { get; set; } = null!;
        public short Clkodu { get; set; }
        public short? Gun { get; set; }
        public DateTime? Sure { get; set; }
        public string Islem { get; set; } = null!;
        public short? Htkodu { get; set; }
        public bool? HtPazar { get; set; }
    }
}
