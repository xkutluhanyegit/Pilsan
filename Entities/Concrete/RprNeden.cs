using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class RprNeden
    {
        public int Sira { get; set; }
        public int Kodu { get; set; }
        public string Adi { get; set; } = null!;
        public string Turu { get; set; } = null!;
    }
}
