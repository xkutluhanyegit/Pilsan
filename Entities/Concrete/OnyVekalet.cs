using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyVekalet
    {
        public int Idno { get; set; }
        public string? Kladi { get; set; }
        public string? Isim { get; set; }
        public DateTime? Bastarih { get; set; }
        public DateTime? Bittarih { get; set; }
        public string? Vekiladi { get; set; }
        public string? Vekilisim { get; set; }
    }
}
