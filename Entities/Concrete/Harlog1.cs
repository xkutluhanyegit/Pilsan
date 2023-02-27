using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Harlog1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public DateTime? Isltarih { get; set; }
        public DateTime? Islzaman { get; set; }
        public string? Islturu { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? Zaman { get; set; }
        public int? Linkid { get; set; }
        public string? Barkod { get; set; }
        public string? Gckodu { get; set; }
        public int? Neden { get; set; }
        public string? Termkodu { get; set; }
        public string? Kullanici { get; set; }
        public DateTime? NewTarih { get; set; }
        public DateTime? NewZaman { get; set; }
        public int? NewLinkid { get; set; }
        public string? NewBarkod { get; set; }
        public string? NewGckodu { get; set; }
        public int? NewNeden { get; set; }
        public string? NewTermkodu { get; set; }
    }
}
