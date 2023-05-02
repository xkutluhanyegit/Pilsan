using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Grup
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string GrupKodu { get; set; } = null!;
        public string? GrupAdi { get; set; }
    }
}
