using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Sismesai
    {
        public int Idno { get; set; }
        public string CihazNo { get; set; } = null!;
        public string? CihazAdi { get; set; }
        public string Turu { get; set; } = null!;
    }
}
