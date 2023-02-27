using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Sisveri
    {
        public short Idno { get; set; }
        public string Sistem { get; set; } = null!;
        public string? Alan { get; set; }
        public short? Baslangic { get; set; }
        public short? Uzunluk { get; set; }
        public string? Field { get; set; }
    }
}
