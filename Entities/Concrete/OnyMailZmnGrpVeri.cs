using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyMailZmnGrpVeri
    {
        public int Idno { get; set; }
        public int No { get; set; }
        public string Adi { get; set; } = null!;
        public string ZmnBaslik { get; set; } = null!;
        public string ZmnTuru { get; set; } = null!;
        public string ZmnDeger { get; set; } = null!;
        public string VktTuru { get; set; } = null!;
        public string VktDeger { get; set; } = null!;
    }
}
