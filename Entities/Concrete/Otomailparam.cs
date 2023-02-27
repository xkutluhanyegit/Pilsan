using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Otomailparam
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Kodu { get; set; } = null!;
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? Adresi { get; set; }
        public string? Grup { get; set; }
        public string? Aciklama { get; set; }
        public string? GirisCikis { get; set; }
        public string? Icerde { get; set; }
        public string? Disarda { get; set; }
        public string? Gelmeyen { get; set; }
        public string? Gec { get; set; }
        public string? Erken { get; set; }
        public string? Eksik { get; set; }
        public string? Aylik { get; set; }
        public string? SaatIzin { get; set; }
        public string? GunIzin { get; set; }
        public string? Izinde { get; set; }
        public string? Gelmeyen2 { get; set; }
    }
}
