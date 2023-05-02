using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Rapor
    {
        public int Idno { get; set; }
        public string Grkodu { get; set; } = null!;
        public string Kodu { get; set; } = null!;
        public string? Turu { get; set; }
        public string? Adi { get; set; }
        public string? Kullanici { get; set; }
        public string? Yetki { get; set; }
        public string? Baslik { get; set; }
        public string? Selectsql { get; set; }
        public string? Wheresql { get; set; }
        public string? Ordersql { get; set; }
        public string? Alanbaslik { get; set; }
        public string? Alantipi { get; set; }
        public string? Alanuzunluk { get; set; }
    }
}
