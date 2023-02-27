using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Alan
    {
        public int Idno { get; set; }
        public string Tbadi { get; set; } = null!;
        public string Adi { get; set; } = null!;
        public string? Keyalan { get; set; }
        public string? Izahat { get; set; }
        public string? Tipi { get; set; }
        public string? Sec { get; set; }
        public string? Ltablo { get; set; }
        public string? Llistalan { get; set; }
        public string? Lkeyalan { get; set; }
        public int? Srkodu { get; set; }
        public string? SpTbadi { get; set; }
        public string? SpAlan { get; set; }
    }
}
