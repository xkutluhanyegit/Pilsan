using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class YnPerView
    {
        public int Srkodu { get; set; }
        public string? Unvan { get; set; }
        public string Sicilno { get; set; } = null!;
        public string Adi { get; set; } = null!;
        public string Soyadi { get; set; } = null!;
        public DateTime Isgirt { get; set; }
        public DateTime? Iscikt { get; set; }
        public string Departman { get; set; } = null!;
        public string? DpAdi { get; set; }
        public string? Altdepart { get; set; }
        public string? Adadi { get; set; }
        public string? Kadro { get; set; }
        public string? KdAdi { get; set; }
        public string? Meslek { get; set; }
        public string? MsAdi { get; set; }
        public string? Servis { get; set; }
        public string? SrAdi { get; set; }
        public string? Gorev { get; set; }
        public string? GrAdi { get; set; }
        public short Posta { get; set; }
        public string? PsAdi { get; set; }
        public string Pertipi { get; set; } = null!;
        public string? PtAdi { get; set; }
        public string? Kod1 { get; set; }
        public string? Kod2 { get; set; }
    }
}
