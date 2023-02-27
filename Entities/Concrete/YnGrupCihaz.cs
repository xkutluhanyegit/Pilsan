using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class YnGrupCihaz
    {
        public int Kodu { get; set; }
        public int? Grupkodu { get; set; }
        public int? Cihaz { get; set; }
        public string? Cihazadi { get; set; }
    }
}
