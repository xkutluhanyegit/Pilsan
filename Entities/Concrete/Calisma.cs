using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Calisma
    {
        public int? Idno { get; set; }
        public short Kodu { get; set; }
        public string? Adi { get; set; }
        public string Tipi { get; set; } = null!;
        public DateTime? Minclim { get; set; }
        public DateTime? Maxclim { get; set; }
        public short? Yuvarla { get; set; }
        public short? Carpan { get; set; }
        public DateTime? Altlim { get; set; }
        public DateTime? Ustlim { get; set; }
        public string Mecbur { get; set; } = null!;
        public string Onay { get; set; } = null!;
        public string Cmtver { get; set; } = null!;
        public string Hftver { get; set; } = null!;
        public string Gntver { get; set; } = null!;
        public bool? Cmtgunver { get; set; }
        public bool? Cmtsaatver { get; set; }
        public bool? Hftgunver { get; set; }
        public bool? Hftsaatver { get; set; }
        public bool? Gntgunver { get; set; }
        public bool? Gntsaatver { get; set; }
        public bool? Calismahesapla { get; set; }
        public bool? NedenDevam { get; set; }
        public string? RaporKodu { get; set; }
        public string? EntClkodu { get; set; }
        public int? DnkDerece { get; set; }
    }
}
