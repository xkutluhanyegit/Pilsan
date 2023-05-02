using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Saatizin1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public string Neden { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public DateTime Bassaat { get; set; }
        public DateTime? Saat { get; set; }
        public DateTime Bitsaat { get; set; }
        public string? Sebep { get; set; }
        public int? Trnid { get; set; }
        public string? Aciklama { get; set; }
    }
}
