using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class RaporHareket
    {
        public int Idno { get; set; }
        public string? Kladi { get; set; }
        public string? Prsicil { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? Girtarih1 { get; set; }
        public DateTime? Girsaat1 { get; set; }
        public DateTime? Ciktarih1 { get; set; }
        public DateTime? Ciksaat1 { get; set; }
        public DateTime? Girtarih2 { get; set; }
        public DateTime? Girsaat2 { get; set; }
        public DateTime? Ciktarih2 { get; set; }
        public DateTime? Ciksaat2 { get; set; }
    }
}
