using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Vartol
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public short Vgkodu { get; set; }
        public DateTime? Baserkt { get; set; }
        public DateTime? Bassaat { get; set; }
        public DateTime? Basgect { get; set; }
        public DateTime? Biterkt { get; set; }
        public DateTime? Bitsaat { get; set; }
        public DateTime? Bitgect { get; set; }
        public int? Vrkodu { get; set; }
    }
}
