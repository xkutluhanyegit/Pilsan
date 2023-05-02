using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Cihazgrup
    {
        public int Num { get; set; }
        public string Adi { get; set; } = null!;
        public bool? Ziyaretci { get; set; }
        public int? Sirket { get; set; }
    }
}
