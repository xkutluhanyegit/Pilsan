using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksSyncCihazgrup
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public int Grupkodu { get; set; }
        public string? Grupadi { get; set; }
        public string? ServerIp { get; set; }
    }
}
