using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Postum
    {
        public int? Idno { get; set; }
        public int Srkodu { get; set; }
        public short Kodu { get; set; }
        public string? Adi { get; set; }
        public DateTime? Bastar { get; set; }
        public string? Turu { get; set; }
        public int? IzinDevirLimit { get; set; }
        public int? GrupKodu { get; set; }
        public int? HaftaTatili { get; set; }
        public string? Gun { get; set; }
        public double? DvmSure { get; set; }
        public int? IsbasiGun { get; set; }
    }
}
