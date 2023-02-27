using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Cocuk1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public string Adi { get; set; } = null!;
        public string Soyadi { get; set; } = null!;
        public DateTime? Dogtar { get; set; }
        public string? Okkodu { get; set; }
        public string? Bolum { get; set; }
        public string? Cins { get; set; }
    }
}
