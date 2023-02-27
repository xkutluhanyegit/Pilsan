using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksCihazPrinter
    {
        public int Idno { get; set; }
        public int CihazNo { get; set; }
        public string? Printer { get; set; }
        public string? PrinterIp { get; set; }
        public int? PrinterPort { get; set; }
        public bool? Aktif { get; set; }
    }
}
