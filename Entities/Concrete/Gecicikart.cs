using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Gecicikart
    {
        public long Keycode { get; set; }
        public string No { get; set; } = null!;
        public int Sirket { get; set; }
        public string? Aciklama { get; set; }
        public string Durum { get; set; } = null!;
    }
}
