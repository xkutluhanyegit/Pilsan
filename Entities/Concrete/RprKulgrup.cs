using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class RprKulgrup
    {
        public int Sira { get; set; }
        public string Kladi { get; set; } = null!;
        public int Kodu { get; set; }
        public string Adi { get; set; } = null!;
        public string? Aciklama { get; set; }
    }
}
