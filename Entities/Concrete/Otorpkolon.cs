using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Otorpkolon
    {
        public string Rpkodu { get; set; } = null!;
        public string Adi { get; set; } = null!;
        public string Aciklama { get; set; } = null!;
        public string Goster { get; set; } = null!;
        public int Idno { get; set; }
    }
}
