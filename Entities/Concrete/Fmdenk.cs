using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Fmdenk
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Pertipi { get; set; } = null!;
        public short? Aysure { get; set; }
        public string? Aciklama { get; set; }
        public string Dahil { get; set; } = null!;
    }
}
