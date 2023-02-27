using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Durak
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string ServisKodu { get; set; } = null!;
        public string DurakKodu { get; set; } = null!;
        public string? DurakAdi { get; set; }
    }
}
