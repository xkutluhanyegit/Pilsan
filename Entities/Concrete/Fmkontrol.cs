using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Fmkontrol
    {
        public short Idno { get; set; }
        public int? Srkodu { get; set; }
        public string? Pertipi { get; set; }
        public string? Kontrol { get; set; }
        public short? Ekclkodu { get; set; }
        public short? Bakclkodu { get; set; }
        public short? Limit { get; set; }
        public short? Fmkd1 { get; set; }
        public short? Fmkd2 { get; set; }
        public short? Fmkd3 { get; set; }
    }
}
