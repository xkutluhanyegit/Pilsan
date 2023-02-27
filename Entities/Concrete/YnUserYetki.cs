using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class YnUserYetki
    {
        public int Idno { get; set; }
        public string? Turu { get; set; }
        public string Kullanici { get; set; } = null!;
        public string? Srkodu { get; set; }
        public bool? Secim { get; set; }
        public string Kodu { get; set; } = null!;
        public string? Adi { get; set; }
    }
}
