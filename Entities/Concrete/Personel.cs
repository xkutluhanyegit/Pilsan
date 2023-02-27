using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Personel
    {
        public string Sicil { get; set; } = null!;
        public int? Sirket { get; set; }
        public string? Departman { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? Kartno { get; set; }
        public DateTime? Karttarih { get; set; }
        public DateTime? Isgiristar { get; set; }
        public DateTime? Iscikistar { get; set; }
        public int? Privilege { get; set; }
        public int? Enabled { get; set; }
        public string? Password { get; set; }
        public string? Adsoyad { get; set; }
        public string? Vergino { get; set; }
        public string? Tckimlik { get; set; }
        public double? Cardno { get; set; }
        public string? Feyyaz { get; set; }
        public string? Gorevi { get; set; }
        public string? Kurumsicilno { get; set; }
        public string? Altdep { get; set; }
    }
}
