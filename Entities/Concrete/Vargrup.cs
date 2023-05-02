using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Vargrup
    {
        public int? Idno { get; set; }
        public int Srkodu { get; set; }
        public short Kodu { get; set; }
        public string? Adi { get; set; }
        public DateTime? Gndsaat { get; set; }
        public string? Gndtipi { get; set; }
    }
}
