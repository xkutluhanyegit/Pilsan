using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class MesaiOnay
    {
        public int Idno { get; set; }
        public string? Prsicil { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? Sure { get; set; }
        public int? Srkodu { get; set; }
        public string? Onay1 { get; set; }
        public string? Onay1kl { get; set; }
        public string? Onay2 { get; set; }
        public string? Onay2kl { get; set; }
        public string? Onay3 { get; set; }
        public string? Onay3kl { get; set; }
        public string? Onay4 { get; set; }
        public string? Onay4kl { get; set; }
        public string? Onay5 { get; set; }
        public string? Onay5kl { get; set; }
        public string? Aciklama { get; set; }
        public string? Neden { get; set; }
    }
}
