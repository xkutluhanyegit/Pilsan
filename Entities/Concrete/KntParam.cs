using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class KntParam
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public bool? KontrolHi { get; set; }
        public bool? KontrolCmt { get; set; }
        public bool? KontrolHt { get; set; }
        public bool? KontrolGt { get; set; }
        public int? FmkoduHi { get; set; }
        public int? FmkoduCmt { get; set; }
        public int? FmkoduHt { get; set; }
        public int? FmkoduGt { get; set; }
        public int? ClkoduNrm { get; set; }
        public int? ClkoduDvm { get; set; }
        public int? ClkoduCmt { get; set; }
        public int? ClkoduHt { get; set; }
        public int? ClkoduGt { get; set; }
        public double? GunlukLimitHi { get; set; }
        public double? GunlukLimitCmt { get; set; }
        public double? GunlukLimitHt { get; set; }
        public double? GunlukLimitGt { get; set; }
        public bool? HaftalikKontrolHi { get; set; }
        public bool? HaftalikKontrolCmt { get; set; }
        public bool? HaftalikKontrolHt { get; set; }
        public bool? HaftalikKontrolGt { get; set; }
        public double? HaftalikLimitHi { get; set; }
        public double? HaftalikLimitCmt { get; set; }
        public double? HaftalikLimitHt { get; set; }
        public double? HaftalikLimitGt { get; set; }
        public bool? AylikKontrolHi { get; set; }
        public bool? AylikKontrolCmt { get; set; }
        public bool? AylikKontrolHt { get; set; }
        public bool? AylikKontrolGt { get; set; }
        public double? AylikLimitHi { get; set; }
        public double? AylikLimitCmt { get; set; }
        public double? AylikLimitHt { get; set; }
        public double? AylikLimitGt { get; set; }
        public int? FazlaClkoduHi { get; set; }
        public int? FazlaClkoduCmt { get; set; }
        public int? FazlaClkoduHt { get; set; }
        public int? FazlaClkoduGt { get; set; }
        public double? KatsayiHi { get; set; }
        public double? KatsayiCmt { get; set; }
        public double? KatsayiHt { get; set; }
        public double? KatsayiGt { get; set; }
        public bool? EksikGunFmyaz { get; set; }
        public bool? CalisilanHi { get; set; }
        public bool? CalisilanCmt { get; set; }
        public bool? CalisilanHt { get; set; }
        public bool? CalisilanGt { get; set; }
        public string? VrdKnt { get; set; }
        public DateTime? VrdSure { get; set; }
        public bool? VardiyaDuzenle { get; set; }
        public bool? TekVardiyayiDuzenleme { get; set; }
        public double? HaftalikToplamCalisma { get; set; }
        public bool? TumMesaileriDagit { get; set; }
        public int? ClkoduSsk { get; set; }
        public bool? GercekCalismaSuresi { get; set; }
        public int? IzinKodu { get; set; }
        public DateTime? IzinSuresi { get; set; }
        public bool? GercekGunlukIzin { get; set; }
        public bool? GercekSaatlikIzin { get; set; }
        public bool? DereceliMesaiDagilim { get; set; }
        public double? GunlukLimitCmt2 { get; set; }
        public double? GunlukLimitCmtMax { get; set; }
        public double? GunlukLimitHt2 { get; set; }
        public double? GunlukLimitHtMax { get; set; }
        public double? GunlukLimitGt2 { get; set; }
        public double? GunlukLimitGtMax { get; set; }
        public bool? OrjinalAylikMesai { get; set; }
        public bool? FmcmtOrj { get; set; }
        public bool? FmhtOrj { get; set; }
        public bool? FmgtOrj { get; set; }
        public bool? PersonelBazliMesai { get; set; }
        public bool? TumMesaileriGunduzeDagit { get; set; }
        public bool? HaftalikVardiyaKontrol { get; set; }
        public int? FmkoduGt2 { get; set; }
    }
}
