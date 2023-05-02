using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Calisdgl
    {
        public int Idno { get; set; }
        public short Clkodu { get; set; }
        public short Kodu { get; set; }
        public string Durum { get; set; } = null!;
        public DateTime? Altlmt { get; set; }
        public DateTime? Ustlmt { get; set; }
        public short? Carpan { get; set; }
    }
}
