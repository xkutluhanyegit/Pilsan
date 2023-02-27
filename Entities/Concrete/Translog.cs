using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Translog
    {
        public int Idno { get; set; }
        public DateTime Islzamani { get; set; }
        public string? Turu { get; set; }
        public string? Aciklama { get; set; }
        public string? Sistem { get; set; }
        public string? Kartno { get; set; }
        public string? Prsicil { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? Zaman { get; set; }
        public string? Gckodu { get; set; }
        public string? Cihaz { get; set; }
        public int? Neden { get; set; }
        public string? Kullanici { get; set; }
    }
}
