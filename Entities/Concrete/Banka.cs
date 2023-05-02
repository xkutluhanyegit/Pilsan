using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Banka
    {
        public int Idno { get; set; }
        public string Kodu { get; set; } = null!;
        public string? Banka1 { get; set; }
    }
}
