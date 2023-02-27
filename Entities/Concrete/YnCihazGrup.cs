using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class YnCihazGrup
    {
        public int Kodu { get; set; }
        public string? Adi { get; set; }
        public string? Turu { get; set; }
        public int? Cihaz { get; set; }
    }
}
