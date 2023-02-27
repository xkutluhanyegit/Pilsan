using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Otorpparam
    {
        public string Rpkodu { get; set; } = null!;
        public string Tipi { get; set; } = null!;
        public string Adi { get; set; } = null!;
        public string Degeri { get; set; } = null!;
        public int Idno { get; set; }
    }
}
