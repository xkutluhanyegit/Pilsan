using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class RprSaatizin
    {
        public int Sira { get; set; }
        public int Sirket { get; set; }
        public string Sicilno { get; set; } = null!;
        public string Neden { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public DateTime Bassaat { get; set; }
        public DateTime Bitsaat { get; set; }
    }
}
