using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Yilizkul
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Prsicil { get; set; } = null!;
        public double? Kullan { get; set; }
        public DateTime? Bastarih { get; set; }
        public string? Ay { get; set; }
        public string? Yil { get; set; }
        public string? Turu { get; set; }
    }
}
