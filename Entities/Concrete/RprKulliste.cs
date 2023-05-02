using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class RprKulliste
    {
        public int Sira { get; set; }
        public string Kladi { get; set; } = null!;
        public string Kodu { get; set; } = null!;
    }
}
