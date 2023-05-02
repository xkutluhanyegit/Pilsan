using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Perarsiv1
    {
        public int Idno { get; set; }
        public string? Prsicil { get; set; }
        public string? Bilgi { get; set; }
        public DateTime? Tarih { get; set; }
        public string Deger { get; set; } = null!;
        public DateTime? Girtarih { get; set; }
        public DateTime? Ciktarih { get; set; }
    }
}
