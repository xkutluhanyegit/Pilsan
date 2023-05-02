using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Htke
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Pertip { get; set; } = null!;
        public short? Devamsiz { get; set; }
        public string? Devir { get; set; }
    }
}
