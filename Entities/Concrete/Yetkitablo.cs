using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Yetkitablo
    {
        public int Idno { get; set; }
        public string Kladi { get; set; } = null!;
        public int Srkodu { get; set; }
        public string Tbadi { get; set; } = null!;
        public string? Goster { get; set; }
        public string? Ekle { get; set; }
        public string? Degistir { get; set; }
        public string? Sil { get; set; }
    }
}
