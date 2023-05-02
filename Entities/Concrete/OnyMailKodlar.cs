using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyMailKodlar
    {
        public int Idno { get; set; }
        public string Tanim { get; set; } = null!;
        public int Kodu { get; set; }
        public string? Adi { get; set; }
        public string? Deger { get; set; }
    }
}
