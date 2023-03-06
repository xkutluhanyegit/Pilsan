using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class RpOzelrapor
    {
        public int Idno { get; set; }
        public string? RaporKodu { get; set; }
        public string? RaporAdi { get; set; }
        public string? StoredProcedure { get; set; }
        public bool? Grupla { get; set; }
        public string? GrupAlan { get; set; }
        public string? Toplamalan { get; set; }
        public string? Sayalan { get; set; }
    }
}
