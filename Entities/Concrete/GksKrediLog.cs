using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksKrediLog
    {
        public int Idno { get; set; }
        public string? Prsicil { get; set; }
        public DateTime? Bastarih { get; set; }
        public DateTime? Bittarih { get; set; }
        public int? YuklenenKredi { get; set; }
        public int? ToplamKredi { get; set; }
        public DateTime? IslemZamani { get; set; }
        public string? Kullanici { get; set; }
    }
}
