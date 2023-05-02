using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class YnYetki
    {
        public string Turu { get; set; } = null!;
        public int Srkodu { get; set; }
        public string? Kodu { get; set; }
        public string? Adi { get; set; }
        public int? Secim { get; set; }
    }
}
