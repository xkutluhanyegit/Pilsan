using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Haberci1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public string Adi { get; set; } = null!;
        public string? Soyadi { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Tel1 { get; set; }
        public string? Tel2 { get; set; }
        public string? Gsm { get; set; }
    }
}
