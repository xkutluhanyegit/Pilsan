using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class YnParametre
    {
        public int Idno { get; set; }
        public int Kodu { get; set; }
        public string Adi { get; set; } = null!;
        public string? Aciklama { get; set; }
        public string? Kriter { get; set; }
        public string? Deger { get; set; }
        public int? Sayi { get; set; }
        public string? VeriText { get; set; }
    }
}
