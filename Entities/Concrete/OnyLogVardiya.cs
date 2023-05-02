using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyLogVardiya
    {
        public int Idno { get; set; }
        public int? OnyIdno { get; set; }
        public int? Srkodu { get; set; }
        public string? Prsicil { get; set; }
        public DateTime? Tarih { get; set; }
        public int? Vrkodu { get; set; }
        public string? Kullanici { get; set; }
        public int? Derece { get; set; }
        public bool? Onay { get; set; }
        public DateTime? IslemZamani { get; set; }
    }
}
