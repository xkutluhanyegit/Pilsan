using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Bordrotanim
    {
        public int Idno { get; set; }
        public short Kodu { get; set; }
        public string Izahat { get; set; } = null!;
        public string? Turu { get; set; }
        public short? Strbasla { get; set; }
    }
}
