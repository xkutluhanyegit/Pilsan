using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksSyncGrupcihaz
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public int GrupKodu { get; set; }
        public int CihazNo { get; set; }
        public string? Topla { get; set; }
        public string? Yukle { get; set; }
        public string? Sil { get; set; }
        public string? YuklemeTuru { get; set; }
        public string? ZamanAyari { get; set; }
    }
}
