using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Yetkidepart
    {
        public int Idno { get; set; }
        public string? Kladi { get; set; }
        public int? Srkodu { get; set; }
        public string? Depart { get; set; }
        public string Yetki { get; set; } = null!;
        public string? Dpadi { get; set; }
    }
}
