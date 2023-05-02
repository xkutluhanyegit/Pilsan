using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class KntPervardiya
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public string? Prsicil { get; set; }
        public DateTime? Bastarih { get; set; }
        public DateTime? Bittarih { get; set; }
        public int? Vrkodu { get; set; }
    }
}
