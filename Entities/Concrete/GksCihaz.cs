using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksCihaz
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public int CihazNo { get; set; }
        public string? CihazAdi { get; set; }
        public string? CihazTuru { get; set; }
        public string? IpAdresi { get; set; }
        public int? Port { get; set; }
        public int? Adres { get; set; }
        public int? HaberlesmeHizi { get; set; }
        public string? CalismaModu { get; set; }
        public string? Yon { get; set; }
        public string? Yetkilendirme { get; set; }
        public int? RoleSuresi { get; set; }
        public int? OnlineTimeout { get; set; }
        public int? TtlTimeout { get; set; }
        public string? Converter { get; set; }
        public int? PerislemIdI { get; set; }
        public int? PerislemIdD { get; set; }
        public int? ParametreSet { get; set; }
        public string? KartTekrariKnt { get; set; }
        public int? TekrarSure { get; set; }
        public string? ArdisikKartKnt { get; set; }
        public int? ArdisikSure { get; set; }
        public string? Sifre { get; set; }
        public int? HareketIndex { get; set; }
        public DateTime? HareketZaman { get; set; }
        public string? MacAdresi { get; set; }
        public string? ClientIpAdresi { get; set; }
        public int? ClientTcpPort { get; set; }
        public int? ClientUdpPort { get; set; }
        public int? UdpPort { get; set; }
        public string? RoleModu { get; set; }
        public int? YetkilendirmeGrubu { get; set; }
        public string? Antipassback { get; set; }
        public string? OptikGiris { get; set; }
        public string? KartKeyKontrol { get; set; }
        public string? SmartRoleModu { get; set; }
        public string? BolgeKodu { get; set; }
        public string? AsansorKarti { get; set; }
        public string? KartYetki { get; set; }
        public int? KartyetkiGrupkodu { get; set; }
        public string? CokluPersonel { get; set; }
        public string? TusTakimiKontrol { get; set; }
        public string? KartSifreKontrol { get; set; }
        public int? PingSuresi { get; set; }
        public string? OkuyucuTipi { get; set; }
        public string? NedenKontrol { get; set; }
        public int? RandomStart { get; set; }
        public int? RandomEnd { get; set; }
        public int? OlumsuzMesajSure { get; set; }
        public string? TusSesi { get; set; }
        public string? SistemSesi { get; set; }
        public string? OptikGirisAcil { get; set; }
        public string? OptikGirisYangin { get; set; }
        public string? OptikGirisKapi { get; set; }
        public string? OptikGirisTurnike { get; set; }
        public string? AlarmKontrol { get; set; }
        public string? AlarmCihazno { get; set; }
        public int? KapiAdresi { get; set; }
        public int? BolgeAdresi { get; set; }
        public int? EkranParlakligi { get; set; }
        public int? ParmakHassasiyeti { get; set; }
        public string? CihazDili { get; set; }
        public int? EkranArkaIsikSuresi { get; set; }
        public int? TusTakimiArkaIsikSuresi { get; set; }
        public int? SistemSesSeviyesi { get; set; }
        public string? Tema { get; set; }
        public int? TtfsmAdresi { get; set; }
    }
}
