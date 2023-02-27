using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class KodBazliYetkili
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public string? Turu { get; set; }
        public string? Kod { get; set; }
        public string? Sicilno { get; set; }
    }
}
