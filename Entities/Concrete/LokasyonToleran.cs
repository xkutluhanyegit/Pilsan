using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class LokasyonToleran
    {
        public int Idno { get; set; }
        public string? CikisLokasyon { get; set; }
        public string? GirisLokasyon { get; set; }
        public DateTime? Tolerans { get; set; }
    }
}
