using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Serizin
    {
        public int Idno { get; set; }
        public short Kodu { get; set; }
        public string Gun { get; set; } = null!;
        public short Tatil { get; set; }
        public DateTime? Sure { get; set; }
    }
}
