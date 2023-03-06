using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class PasifDonem
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public DateTime? Bastarih { get; set; }
        public DateTime? Bittarih { get; set; }
    }
}
