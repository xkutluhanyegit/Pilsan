using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class ZyZiyaretci
    {
        public int Sicilno { get; set; }
        public string? Isim { get; set; }
        public string? Firma { get; set; }
        public string? Departman { get; set; }
        public string? Telefon { get; set; }
        public string? Yasakli { get; set; }
        public string? Gsm { get; set; }
        public string? Adres1 { get; set; }
        public string? Adres2 { get; set; }
        public string? Ilce { get; set; }
        public string? Sehir { get; set; }
        public string Tipi { get; set; } = null!;
    }
}
