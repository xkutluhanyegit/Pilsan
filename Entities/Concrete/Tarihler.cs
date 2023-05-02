using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Tarihler
    {
        public int Bugun { get; set; }
        public DateTime Tarih { get; set; }
        public string? FormatliBugun { get; set; }
        public string? GunAd { get; set; }
        public string? AyAd { get; set; }
        public string? TarihAd { get; set; }
        public string? BuYil { get; set; }
        public string? BuAy { get; set; }
        public string? BuHafta { get; set; }
        public string? Dun { get; set; }
        public string? GecenHaftaBugun { get; set; }
        public string? GecenAyBugun { get; set; }
        public string? GecenYil { get; set; }
        public string? GecenYilBugun { get; set; }
        public string? GecenYilBuHafta { get; set; }
        public string? GecenYilBuAy { get; set; }
        public string? HaftaIlkGun { get; set; }
        public string? HaftaSonGun { get; set; }
        public string? AyIlkGun { get; set; }
        public string? AySonGun { get; set; }
        public int? HaftaGunNo { get; set; }
        public int? AyGunNo { get; set; }
        public int YilGunNo { get; set; }
        public int? AyGunSayi { get; set; }
        public string? YilIlkGun { get; set; }
        public string? YilSonGun { get; set; }
        public bool? HaftaSonu { get; set; }
    }
}
