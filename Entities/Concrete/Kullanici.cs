using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Kullanici
    {
        public int? Idno { get; set; }
        public string Adi { get; set; } = null!;
        public string Sifre { get; set; } = null!;
        public string? Ntadi { get; set; }
        public string? Izahat { get; set; }
        public string Derece { get; set; } = null!;
        public string? Toolbar { get; set; }
        public string? Outlook { get; set; }
        public string? Explorer { get; set; }
        public string? Theme { get; set; }
        public string? Stylesheet { get; set; }
        public string? Admin { get; set; }
        public string? Email { get; set; }
        public string? Adisoyadi { get; set; }
        public string? HareketTablo { get; set; }
        public string? PuantajTablo { get; set; }
        public bool? FmOnay { get; set; }
        public bool? GunlukIzinOnay { get; set; }
        public bool? SaatlikIzinOnay { get; set; }
        public int? Dil { get; set; }
        public int? Font { get; set; }
        public bool? KodBazliYetki { get; set; }
        public bool? HareketEklemeOnay { get; set; }
        public string? OnySifre { get; set; }
        public bool? PostUser { get; set; }
        public bool? TaksiUcretiOnay { get; set; }
        public bool? VardiyaOnay { get; set; }
        public string? Vekil { get; set; }
        public int? AylikOnayDerece { get; set; }
        public bool? ExcelTransfer { get; set; }
        public string? DomainUsername { get; set; }
        public bool? HaftaTatiliOnay { get; set; }
        public bool? OfflineCalisma { get; set; }
        public bool? HareketGecmisislem { get; set; }
    }
}
