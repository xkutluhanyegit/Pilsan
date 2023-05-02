using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Sube
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string SubeKodu { get; set; } = null!;
        public string? SubeAdi { get; set; }
    }
}
