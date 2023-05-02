using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Vartran
    {
        public string Dosya { get; set; } = null!;
        public string? Yedek { get; set; }
        public short? Sicil { get; set; }
        public short? Sutun { get; set; }
        public short? Satir { get; set; }
    }
}
