using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class PntListealt
    {
        public int ListeKodu { get; set; }
        public int Clkodu { get; set; }
        public string Baslik { get; set; } = null!;
        public string? Aciklama { get; set; }
    }
}
