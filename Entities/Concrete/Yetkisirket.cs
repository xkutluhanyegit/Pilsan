using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Yetkisirket
    {
        public int Idno { get; set; }
        public string? Kladi { get; set; }
        public int Srkodu { get; set; }
        public string Dnadi { get; set; } = null!;
        public string Yetki { get; set; } = null!;
    }
}
