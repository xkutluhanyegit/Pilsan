using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Sisgk
    {
        public short? Idno { get; set; }
        public string Sistem { get; set; } = null!;
        public string Reader { get; set; } = null!;
        public string? Gmyaka { get; set; }
        public string? Gc { get; set; }
    }
}
