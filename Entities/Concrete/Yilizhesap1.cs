using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Yilizhesap1
    {
        public int Idno { get; set; }
        public string? Prsicil { get; set; }
        public short? Yil { get; set; }
        public double? Hakedilen { get; set; }
        public double? Kullanilan { get; set; }
        public double? Yildakalan { get; set; }
        public double? Toplamkalan { get; set; }
        public DateTime? Hesaptarih { get; set; }
        public double? Devir { get; set; }
        public double? Mahsup { get; set; }
        public double? DevirYil { get; set; }
        public double? IptalDevir { get; set; }
        public int? KidemYil { get; set; }
        public int? KidemAy { get; set; }
        public int? KidemGun { get; set; }
        public double? Ilave { get; set; }
    }
}
