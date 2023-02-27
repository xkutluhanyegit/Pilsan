using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Maildepart
    {
        public int Idno { get; set; }
        public string Yetkili { get; set; } = null!;
        public int Srkodu { get; set; }
        public string Kodu { get; set; } = null!;
    }
}
