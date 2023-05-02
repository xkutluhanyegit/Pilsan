using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyMailListe
    {
        public int Idno { get; set; }
        public string? KlAdi { get; set; }
        public string? KlMail { get; set; }
        public int? KlDerece { get; set; }
        public string? KlTipi { get; set; }
        public int? LogIdno { get; set; }
        public int? Srkodu { get; set; }
        public string? Prsicil { get; set; }
        public int? Onay { get; set; }
        public int? Mailtipi { get; set; }
        public string? Islem { get; set; }
        public int? Sayi { get; set; }
        public bool? Durum { get; set; }
    }
}
