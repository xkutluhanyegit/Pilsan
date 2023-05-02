using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class YnYmk
    {
        public int Idno { get; set; }
        public DateTime? Bassaat { get; set; }
        public DateTime? Bitsaat { get; set; }
        public int Kodu { get; set; }
        public string Adi { get; set; } = null!;
        public decimal? Fiyati { get; set; }
    }
}
