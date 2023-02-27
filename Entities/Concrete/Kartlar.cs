using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Kartlar
    {
        public int Cid { get; set; }
        public long Keycode { get; set; }
        public string Persicil { get; set; } = null!;
        public int Persirket { get; set; }
        public DateTime Atamatarih { get; set; }
        public DateTime? Sonkulltarih { get; set; }
        public bool? Atcustomer { get; set; }
        public string? Customerdef { get; set; }
        public string? Durum { get; set; }
        public string? Tipi { get; set; }
        public string? Pizikeycode { get; set; }
    }
}
