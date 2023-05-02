using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Vpdetail
    {
        public string Sicilno { get; set; } = null!;
        public string Adi { get; set; } = null!;
        public string Soyadi { get; set; } = null!;
        public DateTime Isgirt { get; set; }
        public DateTime? Iscikt { get; set; }
        public string? Depkodu { get; set; }
        public string? Depadi { get; set; }
        public string? Adres { get; set; }
        public string? Il { get; set; }
        public string? DurakKodu { get; set; }
        public string? DurakAdi { get; set; }
        public string? Serviskodu { get; set; }
        public string? Servisadi { get; set; }
        public short? Postakodu { get; set; }
        public string? Postaadi { get; set; }
        public string? Postaturu { get; set; }
    }
}
