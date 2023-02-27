using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Kariyer1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public string Firma { get; set; } = null!;
        public DateTime? Girtar { get; set; }
        public DateTime? Ciktar { get; set; }
        public string? Gorev { get; set; }
        public string? Ayrndn { get; set; }
        public double? Ucret { get; set; }
    }
}
