using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class WrSpDeger
    {
        public int Idno { get; set; }
        public int Kodu { get; set; }
        public string Aciklama { get; set; } = null!;
        public string? Text { get; set; }
    }
}
