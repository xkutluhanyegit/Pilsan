using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Yilizhuk
    {
        public short Idno { get; set; }
        public int Srkodu { get; set; }
        public string Pertip { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public short Gun { get; set; }
        public string Durum { get; set; } = null!;
    }
}
