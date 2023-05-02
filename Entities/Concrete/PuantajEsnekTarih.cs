using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class PuantajEsnekTarih
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Prsicil { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public DateTime? Zaman { get; set; }
    }
}
