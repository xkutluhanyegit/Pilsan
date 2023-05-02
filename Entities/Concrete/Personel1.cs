using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
    public partial class Personel1:IEntity
    {
        public int Idno { get; set; }
        public string Sicilno { get; set; } = null!;
        public string Adi { get; set; } = null!;
        public string Soyadi { get; set; } = null!;
        public string Kartno { get; set; } = null!;
        public DateTime Krttar { get; set; }
        public DateTime Isgirt { get; set; }
        public DateTime? Iscikt { get; set; }
        public string? Cikndn { get; set; }
        public DateTime Tpgirt { get; set; }
        public short Posta { get; set; }
        public DateTime Postar { get; set; }
        public string Depart { get; set; } = null!;
        public DateTime Deptar { get; set; }
        public string? Kadro { get; set; }
        public string? Meslek { get; set; }
        public string Pertip { get; set; } = null!;
        public DateTime Pertiptar { get; set; }
        public string Puantb { get; set; } = null!;
        public string Mesai { get; set; } = null!;
        public string? Gorev { get; set; }
        public string? Servis { get; set; }
        public string? Gmyaka { get; set; }
        public string? Kod1 { get; set; }
        public string? Kod2 { get; set; }
        public string? Ucretturu { get; set; }
        public string? Ucrettipi { get; set; }
        public string? Altdepart { get; set; }
        public DateTime? Altdeptar { get; set; }
        public string? Masraf { get; set; }
        public DateTime? Masraftar { get; set; }
        public DateTime? Kadrotar { get; set; }
        public DateTime? Meslektar { get; set; }
        public DateTime? Gorevtar { get; set; }
        public DateTime? Servistar { get; set; }
        public DateTime? Yilizhesapt { get; set; }
        public string? GrupKodu { get; set; }
        public DateTime? GrupTarihi { get; set; }
        public string? BirimKodu { get; set; }
        public DateTime? BirimTarihi { get; set; }
        public string? SubeKodu { get; set; }
        public DateTime? SubeTarihi { get; set; }
        public string? Durak { get; set; }
        public DateTime? DurakTarihi { get; set; }
        public string? Amir1 { get; set; }
        public string? Amir2 { get; set; }
        public string? Amir3 { get; set; }
        public string? Amir4 { get; set; }
        public string? Amir5 { get; set; }
        public string? DomainUsername { get; set; }
        public string? Sifre { get; set; }
        public int? Yetkituru { get; set; }
        public string? Aktif { get; set; }
        public int? PiIdno { get; set; }
        public double? PiCardid { get; set; }
        public string? Kisitlama { get; set; }
        public int? Kredi { get; set; }
        public DateTime? KrediBastar { get; set; }
        public DateTime? KrediBittar { get; set; }
        public string? GecisYetkituru { get; set; }
        public string? OnySifre { get; set; }
        public string? Altdepart2 { get; set; }
        public DateTime? Altdeptar2 { get; set; }
        public string? Altdepart3 { get; set; }
        public DateTime? Altdeptar3 { get; set; }
        public string? Altdepart4 { get; set; }
        public DateTime? Altdeptar4 { get; set; }
        public string? PiIdnoYdk { get; set; }
    }
}
