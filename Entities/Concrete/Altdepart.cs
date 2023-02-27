using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Altdepart
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Dpkodu { get; set; } = null!;
        public string Adkodu { get; set; } = null!;
        public string? Adadi { get; set; }
        public string? Udkodu { get; set; }
        public int? Derece { get; set; }
    }
}
