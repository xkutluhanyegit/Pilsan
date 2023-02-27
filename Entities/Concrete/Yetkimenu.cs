using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Yetkimenu
    {
        public int Idno { get; set; }
        public string Kladi { get; set; } = null!;
        public int Srkodu { get; set; }
        public string Mnadi { get; set; } = null!;
        public string? Yetki { get; set; }
    }
}
