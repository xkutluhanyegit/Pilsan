using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class PersonelAmir
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string AmirKodu { get; set; } = null!;
        public string? AmirAdi { get; set; }
        public string? Kladi { get; set; }
        public string? Sifre { get; set; }
        public string? Email { get; set; }
        public string? DomainUsername { get; set; }
        public bool? FmOnay { get; set; }
        public bool? GunlukIzinOnay { get; set; }
        public bool? SaatlikIzinOnay { get; set; }
        public bool? HareketEklemeOnay { get; set; }
        public bool? TaksiUcretiOnay { get; set; }
        public bool? VardiyaOnay { get; set; }
        public bool? HaftaTatiliOnay { get; set; }
        public int? Dil { get; set; }
        public int? Font { get; set; }
        public bool? YmkModulDurumu { get; set; }
        public string? FmGrup { get; set; }
        public string? IznGrup { get; set; }
        public bool? PostUserMesai { get; set; }
        public bool? PostUserGunizin { get; set; }
        public bool? PostUserSaatizin { get; set; }
        public bool? PostUserHareket { get; set; }
        public bool? PostUserPosta { get; set; }
        public bool? PostUserVardiya { get; set; }
        public bool? RevirUser { get; set; }
        public string? RevirIzin { get; set; }
        public string? RevirBolge { get; set; }
    }
}
