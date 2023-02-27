using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Tablo
    {
        public int? Idno { get; set; }
        public string Adi { get; set; } = null!;
        public string? Izahat { get; set; }
        public string? Turu { get; set; }
        public string? Sec { get; set; }
    }
}
