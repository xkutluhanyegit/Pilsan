using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class YnRapor
    {
        public int Sira { get; set; }
        public string Kladi { get; set; } = null!;
        public string Rpradi { get; set; } = null!;
        public string Adi { get; set; } = null!;
        public string Kriter { get; set; } = null!;
    }
}
