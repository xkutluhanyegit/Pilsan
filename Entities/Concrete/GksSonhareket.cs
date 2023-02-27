using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksSonhareket
    {
        public int Idno { get; set; }
        public int? GrupKodu { get; set; }
        public int? Srkodu { get; set; }
        public string? Prsicil { get; set; }
        public string? Kartno { get; set; }
        public int? PiIdno { get; set; }
        public long? Keycode { get; set; }
        public DateTime? ZamanTrh { get; set; }
        public int? Yon { get; set; }
        public int? Nedenkodu { get; set; }
        public int? Cihaz { get; set; }
        public DateTime? ToplaTar { get; set; }
    }
}
