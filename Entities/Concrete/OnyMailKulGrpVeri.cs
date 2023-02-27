using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyMailKulGrpVeri
    {
        public int Idno { get; set; }
        public int No { get; set; }
        public string Adi { get; set; } = null!;
        public int KulIdno { get; set; }
        public string? KulAdi { get; set; }
        public int KonuIdno { get; set; }
        public string? KonuAdi { get; set; }
        public int MailIdno { get; set; }
        public string? MailIcerik { get; set; }
    }
}
