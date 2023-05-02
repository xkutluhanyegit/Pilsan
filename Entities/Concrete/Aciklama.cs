using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Aciklama
    {
        public int Srkodu { get; set; }
        public string Aciklama1 { get; set; } = null!;
        public string Turu { get; set; } = null!;
    }
}
