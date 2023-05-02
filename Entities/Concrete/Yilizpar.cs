using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Yilizpar
    {
        public short Idno { get; set; }
        public int Srkodu { get; set; }
        public string Pertip { get; set; } = null!;
        public short Clkodu { get; set; }
        public string Bastar { get; set; } = null!;
        public DateTime? Tarih { get; set; }
        public string? Devirvar { get; set; }
        public bool? YilbasiHakedis { get; set; }
        public bool? GirisYiliHesapla { get; set; }
        public bool? DevirIptal { get; set; }
        public string? DevirIptalAy { get; set; }
        public int? DevirIptalGun { get; set; }
    }
}
