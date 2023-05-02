using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Departman
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Kodu { get; set; } = null!;
        public string? Adi { get; set; }
        public int Sirket { get; set; }
        public string? Harekleme { get; set; }
        public int? NormKadro { get; set; }
    }
}
