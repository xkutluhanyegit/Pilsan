using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyParametre
    {
        public bool? PersonelBazliCalisma { get; set; }
        public bool? ProtokolKullanim { get; set; }
        public bool? FmOnay { get; set; }
        public bool? GunlukIzinOnay { get; set; }
        public bool? SaatlikIzinOnay { get; set; }
        public bool? VardiyaOnay { get; set; }
        public bool? HareketOnay { get; set; }
        public bool? TaksiUcretiOnay { get; set; }
        public string? MesaiOnayModu { get; set; }
        public bool? ServisPlanlama { get; set; }
        public bool? OnaySiralama { get; set; }
        public bool? IzinliKisiSayisiKontrolu { get; set; }
        public double? IzinliKisiLimiti { get; set; }
        public bool? FmOnayDegisiklik { get; set; }
        public bool? GunlukIzinOnayDegisiklik { get; set; }
        public bool? SaatlikIzinOnayDegisiklik { get; set; }
        public bool? VadiyaOnayDegisiklik { get; set; }
        public bool? HareketOnayDegisiklik { get; set; }
        public bool? TaksiUcretiOnayDegisiklik { get; set; }
        public bool? FmBaslamaBitis { get; set; }
        public bool? FmYemekyer { get; set; }
        public bool? YmkModulDurumu { get; set; }
    }
}
