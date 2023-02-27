using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksPerislem
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public string? Sicilno { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? Depart { get; set; }
        public DateTime? Isgirt { get; set; }
        public DateTime? Iscikt { get; set; }
        public string? Sifre { get; set; }
        public int? Yetkituru { get; set; }
        public string? Aktif { get; set; }
        public int? PiIdno { get; set; }
        public double? PiCardid { get; set; }
        public long? Keycode { get; set; }
        public string? Islemturu { get; set; }
        public string? Kullanici { get; set; }
        public int? CihazNo { get; set; }
    }
}
