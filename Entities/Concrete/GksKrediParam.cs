using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksKrediParam
    {
        public int Idno { get; set; }
        public string KontrolAlan { get; set; } = null!;
        public string KontrolDeger { get; set; } = null!;
        public string? KontrolTuru { get; set; }
        public int? KontrolGunu { get; set; }
        public int? Kredi { get; set; }
    }
}
