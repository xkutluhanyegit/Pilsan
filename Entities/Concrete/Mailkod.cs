using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Mailkod
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Yetkili { get; set; } = null!;
        public string Turu { get; set; } = null!;
        public string Kodu { get; set; } = null!;
    }
}
