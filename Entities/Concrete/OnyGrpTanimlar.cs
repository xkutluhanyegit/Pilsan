using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyGrpTanimlar
    {
        public int Idno { get; set; }
        public int KulGrupKodu { get; set; }
        public string KulGrupAdi { get; set; } = null!;
        public string IslemTuru { get; set; } = null!;
        public int TnmGrupKodu { get; set; }
        public string TnmGrupAdi { get; set; } = null!;
    }
}
