using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class RprGunizin
    {
        public int Sira { get; set; }
        public int Sirket { get; set; }
        public string Sicilno { get; set; } = null!;
        public string Neden { get; set; } = null!;
        public DateTime Bastar { get; set; }
        public DateTime Bittar { get; set; }
    }
}
