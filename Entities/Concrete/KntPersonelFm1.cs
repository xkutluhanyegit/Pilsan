using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class KntPersonelFm1
    {
        public int Idno { get; set; }
        public string Sicilno { get; set; } = null!;
        public int Ay { get; set; }
        public int Yil { get; set; }
        public double? AylikLimitHi { get; set; }
        public double? AylikLimitCmt { get; set; }
        public double? AylikLimitHt { get; set; }
        public double? AylikLimitGt { get; set; }
    }
}
