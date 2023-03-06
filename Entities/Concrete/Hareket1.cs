using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Hareket1
    {
        public int Idno { get; set; }
        public int Linkid { get; set; }
        public string Barkod { get; set; } = null!;
        public string Prsicil { get; set; } = null!;
        public string? Gckodu { get; set; }
        public int? Neden { get; set; }
        public string? Termkodu { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? Zaman { get; set; }
        public DateTime? Otarih { get; set; }
        public DateTime? Ozaman { get; set; }
        public string? Sistem { get; set; }
        public int HareketIdno { get; set; }
    }
}
