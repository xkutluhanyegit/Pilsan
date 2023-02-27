using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class YnMola
    {
        public short Idno { get; set; }
        public int? Srkodu { get; set; }
        public int? Kodu { get; set; }
        public DateTime? Baslama { get; set; }
        public DateTime? Bitis { get; set; }
    }
}
