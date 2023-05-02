using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyMesaiGercek
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Prsicil { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public DateTime? GlnSure { get; set; }
        public int Fmkodu { get; set; }
        public string? Aciklama { get; set; }
        public string? Neden { get; set; }
        public DateTime? OnySure { get; set; }
        public bool? Onay1 { get; set; }
        public string? Onay1kl { get; set; }
        public bool? Onay2 { get; set; }
        public string? Onay2kl { get; set; }
        public bool? Onay3 { get; set; }
        public string? Onay3kl { get; set; }
        public bool? Onay4 { get; set; }
        public string? Onay4kl { get; set; }
        public bool? Onay5 { get; set; }
        public string? Onay5kl { get; set; }
        public bool? Onay6 { get; set; }
        public string? Onay6kl { get; set; }
        public bool? Onay7 { get; set; }
        public string? Onay7kl { get; set; }
        public bool? Onay8 { get; set; }
        public string? Onay8kl { get; set; }
        public bool? Onay9 { get; set; }
        public string? Onay9kl { get; set; }
        public bool? Onay10 { get; set; }
        public string? Onay10kl { get; set; }
        public bool? Post { get; set; }
        public bool? Ret { get; set; }
        public string? MesaiTipi { get; set; }
    }
}
