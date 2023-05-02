using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksYtkGrupzaman
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public int GrupKodu { get; set; }
        public int? Gunkodu { get; set; }
        public string? Gun { get; set; }
        public DateTime? Bassaat { get; set; }
        public DateTime? Bitsaat { get; set; }
        public int? Sayi { get; set; }
    }
}
