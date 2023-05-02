using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Birim
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string BirimKodu { get; set; } = null!;
        public string? BirimAdi { get; set; }
    }
}
