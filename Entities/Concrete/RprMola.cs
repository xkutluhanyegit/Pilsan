using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class RprMola
    {
        public int Sira { get; set; }
        public DateTime? Bassaat { get; set; }
        public DateTime? Bitsaat { get; set; }
        public int Kodu { get; set; }
        public string Adi { get; set; } = null!;
    }
}
