using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class VarhakedZaman
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public int? Vrkodu { get; set; }
        public DateTime? Bassaat { get; set; }
        public DateTime? Bitsaat { get; set; }
        public int? Clkodu { get; set; }
        public string? IslemTuru { get; set; }
    }
}
