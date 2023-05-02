using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksKapiLog
    {
        public int Idno { get; set; }
        public string? IpAdresi { get; set; }
        public int? CihazNo { get; set; }
        public int? Adres { get; set; }
        public int? DurumKodu { get; set; }
        public string? Durum { get; set; }
        public DateTime? Zaman { get; set; }
    }
}
