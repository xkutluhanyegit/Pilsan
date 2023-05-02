using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Rpsorgu
    {
        public int Idno { get; set; }
        public string Rpkodu { get; set; } = null!;
        public string? Tbadi { get; set; }
        public string? Alan { get; set; }
        public string? Kriter { get; set; }
        public string? Deger1 { get; set; }
        public string? Deger2 { get; set; }
        public short? Siralama { get; set; }
        public string? Baglama { get; set; }
    }
}
