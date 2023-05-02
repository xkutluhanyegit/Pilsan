using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Oteleme
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public int Clkodu { get; set; }
        public string? Gtatil { get; set; }
        public string? Htatil { get; set; }
        public string? Cmt { get; set; }
        public string Pertip { get; set; } = null!;
    }
}
