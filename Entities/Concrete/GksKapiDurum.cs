using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksKapiDurum
    {
        public int Idno { get; set; }
        public string IpAdresi { get; set; } = null!;
        public int CihazNo { get; set; }
        public string? Reader1 { get; set; }
        public DateTime? Reader1Zaman { get; set; }
        public string? Reader2 { get; set; }
        public DateTime? Reader2Zaman { get; set; }
    }
}
