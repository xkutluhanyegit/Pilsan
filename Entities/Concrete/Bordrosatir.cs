using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Bordrosatir
    {
        public int Idno { get; set; }
        public short Btkodu { get; set; }
        public string Bilgi { get; set; } = null!;
        public string? Tbadi { get; set; }
        public string? Aladi { get; set; }
        public string? Deger { get; set; }
        public string? Onchar { get; set; }
        public short? Sutun { get; set; }
        public short? Uzunluk { get; set; }
    }
}
