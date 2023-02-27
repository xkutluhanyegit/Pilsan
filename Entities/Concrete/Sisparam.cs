using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Sisparam
    {
        public int Idno { get; set; }
        public string Sistem { get; set; } = null!;
        public string Kolon { get; set; } = null!;
        public string Operator { get; set; } = null!;
        public string Deger { get; set; } = null!;
    }
}
