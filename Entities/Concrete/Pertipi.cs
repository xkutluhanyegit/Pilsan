using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Pertipi
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Pertipi1 { get; set; } = null!;
        public string Turu { get; set; } = null!;
        public string Puantaj { get; set; } = null!;
    }
}
