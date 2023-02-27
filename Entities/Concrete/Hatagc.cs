using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Hatagc
    {
        public int Idno { get; set; }
        public string? Barkod { get; set; }
        public string? Gckodu { get; set; }
        public int? Neden { get; set; }
        public string? Termkodu { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? Zaman { get; set; }
        public string? Izahat { get; set; }
        public string? Sistem { get; set; }
        public string? Kartid { get; set; }
    }
}
