using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Golgeprim
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Pertipi { get; set; } = null!;
        public short Kaynakfm { get; set; }
        public short? Hedeffm { get; set; }
        public DateTime? Limit { get; set; }
        public short? Gun { get; set; }
    }
}
