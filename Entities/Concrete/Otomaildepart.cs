using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Otomaildepart
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Yetkili { get; set; } = null!;
        public string Kodu { get; set; } = null!;
    }
}
