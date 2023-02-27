using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Egitim1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public string Okkodu { get; set; } = null!;
        public string? Bolum { get; set; }
        public string? Sehir { get; set; }
        public short? Basyil { get; set; }
        public short? Bityil { get; set; }
        public int? Derece { get; set; }
    }
}
