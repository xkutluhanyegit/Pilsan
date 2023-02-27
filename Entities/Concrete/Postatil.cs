using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Postatil
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public int Pskodu { get; set; }
        public DateTime Tarih { get; set; }
        public short Gun { get; set; }
        public short Vrkodu { get; set; }
    }
}
