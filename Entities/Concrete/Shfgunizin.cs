using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Shfgunizin
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Kladi { get; set; } = null!;
        public string Sicil { get; set; } = null!;
        public string Adi { get; set; } = null!;
        public string Soyadi { get; set; } = null!;
        public string Kartno { get; set; } = null!;
        public DateTime Bastar { get; set; }
        public int Gun { get; set; }
        public int Neden { get; set; }
        public DateTime Bittar { get; set; }
        public string Sebep { get; set; } = null!;
        public string Tipi { get; set; } = null!;
        public string Belge { get; set; } = null!;
        public string Durum { get; set; } = null!;
        public string Aciklama { get; set; } = null!;
        public string Note { get; set; } = null!;
    }
}
