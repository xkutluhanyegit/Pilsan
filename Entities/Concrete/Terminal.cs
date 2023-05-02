using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Terminal
    {
        public int Idno { get; set; }
        public string Kodu { get; set; } = null!;
        public string Turu { get; set; } = null!;
    }
}
