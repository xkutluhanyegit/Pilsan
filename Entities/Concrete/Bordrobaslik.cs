using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Bordrobaslik
    {
        public int Idno { get; set; }
        public short Btkodu { get; set; }
        public string Bilgi { get; set; } = null!;
        public string? Tbadi { get; set; }
        public string? Aladi { get; set; }
        public string? Deger { get; set; }
        public short? Satir { get; set; }
        public short? Sutun { get; set; }
        public short? Uzunluk { get; set; }
    }
}
