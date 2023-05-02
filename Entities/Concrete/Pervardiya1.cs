using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Pervardiya1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public short Vrkodu { get; set; }
        public DateTime Tarih { get; set; }
        public short? Ovkodu { get; set; }
        public string? Onay { get; set; }
        public string? Aciklama { get; set; }
    }
}
