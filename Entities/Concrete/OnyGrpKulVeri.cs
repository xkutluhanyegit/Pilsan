using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyGrpKulVeri
    {
        public int Idno { get; set; }
        public int GrpKodu { get; set; }
        public string Kladi { get; set; } = null!;
        public string? Aciklama { get; set; }
        public string Turu { get; set; } = null!;
    }
}
