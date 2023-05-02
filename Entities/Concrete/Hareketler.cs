using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Hareketler
    {
        public long Cid { get; set; }
        public string? Kartno { get; set; }
        public string? Sicil { get; set; }
        public int? Sirket { get; set; }
        public DateTime ZamanTrh { get; set; }
        public long Keycode { get; set; }
        public string Yon { get; set; } = null!;
        public int Nedenkodu { get; set; }
        public int Cihaz { get; set; }
        public DateTime? ToplaTar { get; set; }
        public string? Sebep { get; set; }
        public string? Hartipi { get; set; }
        public int? Mesaj { get; set; }
    }
}
