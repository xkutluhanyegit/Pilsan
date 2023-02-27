using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class WrUserYetki
    {
        public short Idno { get; set; }
        public string Kladi { get; set; } = null!;
        public int Srkodu { get; set; }
        public string Turu { get; set; } = null!;
        public string Deger { get; set; } = null!;
    }
}
