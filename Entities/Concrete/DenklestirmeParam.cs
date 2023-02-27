using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class DenklestirmeParam
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public string? Kriter { get; set; }
        public string? Deger { get; set; }
        public DateTime? Bastarih { get; set; }
        public string? Turu { get; set; }
        public int? DnkSure { get; set; }
        public string? DnkSureKontrol { get; set; }
    }
}
