using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Filtred
    {
        public int Idno { get; set; }
        public int Fidno { get; set; }
        public string Tadi { get; set; } = null!;
        public string Alan { get; set; } = null!;
        public string? Kriter { get; set; }
        public string? Deger1 { get; set; }
        public string? Deger2 { get; set; }
        public short? Siralama { get; set; }
        public string? Baglama { get; set; }
    }
}
