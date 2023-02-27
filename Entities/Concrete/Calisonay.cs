using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Calisonay
    {
        public int Idno { get; set; }
        public short Clkodu { get; set; }
        public short Kodu { get; set; }
        public string Degistir { get; set; } = null!;
        public string? Ekle { get; set; }
    }
}
