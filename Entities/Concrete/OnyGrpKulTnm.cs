using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyGrpKulTnm
    {
        public int Idno { get; set; }
        public int GrpKodu { get; set; }
        public string GrpAdi { get; set; } = null!;
        public string Turu { get; set; } = null!;
    }
}
