using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Rppreview
    {
        public string Rpturu { get; set; } = null!;
        public string Rpadi { get; set; } = null!;
        public string Lsadi { get; set; } = null!;
        public string? Font { get; set; }
        public string? Fontsize { get; set; }
        public string? Orientation { get; set; }
        public short? Autowidth { get; set; }
    }
}
