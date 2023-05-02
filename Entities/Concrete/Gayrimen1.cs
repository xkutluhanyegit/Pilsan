using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Gayrimen1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public string Turu { get; set; } = null!;
        public string? Kullanim { get; set; }
        public string? Alani { get; set; }
        public string? Aciklama { get; set; }
    }
}
