using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class MesaiKesintiparam
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Pertip { get; set; } = null!;
        public int Clkodu { get; set; }
        public int? Sira { get; set; }
        public string Turu { get; set; } = null!;
        public DateTime? Sure { get; set; }
    }
}
