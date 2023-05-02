using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class BankaSube
    {
        public int Idno { get; set; }
        public string BankaKodu { get; set; } = null!;
        public string Kodu { get; set; } = null!;
        public string? Sube { get; set; }
    }
}
