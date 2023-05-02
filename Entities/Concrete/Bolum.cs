using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Bolum
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Kodu { get; set; } = null!;
        public string Turu { get; set; } = null!;
    }
}
