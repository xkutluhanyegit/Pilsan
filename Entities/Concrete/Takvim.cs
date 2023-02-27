using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Takvim
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public short Pskodu { get; set; }
        public short Vrkodu { get; set; }
        public DateTime Tarih { get; set; }
    }
}
