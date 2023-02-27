using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Yetkikod
    {
        public int Idno { get; set; }
        public string? Kladi { get; set; }
        public int? Srkodu { get; set; }
        public string? Turu { get; set; }
        public string? Kod { get; set; }
    }
}
