using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Hpparam
    {
        public int Idno { get; set; }
        public string Pertip { get; set; } = null!;
        public int Srkodu { get; set; }
        public decimal? Calsaat { get; set; }
        public decimal Devlimit { get; set; }
        public decimal? Gunlimit { get; set; }
        public string? Aciklama { get; set; }
        public string? Ucsiz { get; set; }
        public string? Tatil { get; set; }
        public decimal? Haftalimit { get; set; }
    }
}
