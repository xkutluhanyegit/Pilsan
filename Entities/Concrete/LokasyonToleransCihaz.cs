using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class LokasyonToleransCihaz
    {
        public int Idno { get; set; }
        public int? ToleransIdno { get; set; }
        public string? Cihaz { get; set; }
        public string? Turu { get; set; }
    }
}
