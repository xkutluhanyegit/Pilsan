using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Shflog
    {
        public int Srkodu { get; set; }
        public string Kladi { get; set; } = null!;
        public DateTime Zaman { get; set; }
        public string Islem { get; set; } = null!;
    }
}
