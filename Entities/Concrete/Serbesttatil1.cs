using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Serbesttatil1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public short? Vrkodu { get; set; }
    }
}
