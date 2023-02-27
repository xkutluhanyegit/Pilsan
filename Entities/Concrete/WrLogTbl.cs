using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class WrLogTbl
    {
        public int Idno { get; set; }
        public string? Kladi { get; set; }
        public int? Sirket { get; set; }
        public string? Sicilno { get; set; }
        public string? Tablo { get; set; }
        public string? Islturu { get; set; }
        public DateTime? Isltarihi { get; set; }
        public string? Aciklama { get; set; }
    }
}
