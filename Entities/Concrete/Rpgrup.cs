using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Rpgrup
    {
        public int Idno { get; set; }
        public string Kodu { get; set; } = null!;
        public string? Adi { get; set; }
        public string? Tbadi { get; set; }
    }
}
