using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksSyncLog
    {
        public int? CihazNo { get; set; }
        public DateTime? TanimliZaman { get; set; }
        public DateTime? IslemZamani { get; set; }
        public string? IslemTuru { get; set; }
        public int? ToplamHareket { get; set; }
        public int? GecerliHareket { get; set; }
        public int? BlokeHareket { get; set; }
        public int? PersonelSayisi { get; set; }
        public string? Aciklama { get; set; }
        public int? Sonuc { get; set; }
    }
}
