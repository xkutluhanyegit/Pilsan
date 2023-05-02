using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Otomailyetki
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public int Derece { get; set; }
        public string Yetkili { get; set; } = null!;
        public string Turu { get; set; } = null!;
        public string Deger { get; set; } = null!;
    }
}
