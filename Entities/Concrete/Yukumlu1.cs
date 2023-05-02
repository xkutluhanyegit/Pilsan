using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Yukumlu1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public string Adi { get; set; } = null!;
        public string? Soyad { get; set; }
        public DateTime? Dogtrh { get; set; }
        public string? Yakinlik { get; set; }
    }
}
