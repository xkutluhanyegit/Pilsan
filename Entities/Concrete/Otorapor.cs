using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Otorapor
    {
        public int Srkodu { get; set; }
        public string Kodu { get; set; } = null!;
        public string Adi { get; set; } = null!;
        public string Aciklama { get; set; } = null!;
        public int Ilktarih { get; set; }
        public int Sontarih { get; set; }
        public string Goster { get; set; } = null!;
    }
}
