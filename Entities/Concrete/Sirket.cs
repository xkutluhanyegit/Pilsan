using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Sirket
    {
        public int? Idno { get; set; }
        public int Kodu { get; set; }
        public string Unvan { get; set; } = null!;
        public byte[]? Logo { get; set; }
        public string? Adres { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Semt { get; set; }
        public string? Tel1 { get; set; }
        public string? Tel2 { get; set; }
        public string? Tel3 { get; set; }
        public string? Fax1 { get; set; }
        public string? Fax2 { get; set; }
        public string? Mail { get; set; }
        public string? Web { get; set; }
        public string? Verda { get; set; }
        public string? Verno { get; set; }
        public short? Krtuzun { get; set; }
        public string Sistem { get; set; } = null!;
        public short? Aydonum { get; set; }
        public string? Teksicil { get; set; }
        public string? Gunyuvar { get; set; }
        public string? Ayyuvar { get; set; }
        public decimal? Trsirkodu { get; set; }
        public string? Trsirturu { get; set; }
        public string? Hftyuvar { get; set; }
        public short? Scluzun { get; set; }
        public string? Aytoplamyuvar { get; set; }
        public string? Hfttoplamyuvar { get; set; }
        public int? PrgTipi { get; set; }
        public bool? DnkKullan { get; set; }
        public bool? DnkonayGunluk { get; set; }
        public bool? DnkonayHaftalik { get; set; }
    }
}
