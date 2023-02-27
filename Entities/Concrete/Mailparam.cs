using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Mailparam
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Kodu { get; set; } = null!;
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? Adresi { get; set; }
        public string? Grup { get; set; }
        public string? Aciklama { get; set; }
    }
}
