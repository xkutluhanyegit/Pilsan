using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksKisitlama
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public int? Cihazgrup { get; set; }
        public string? Sicilno { get; set; }
        public DateTime? Bastarih { get; set; }
        public DateTime? Bittarih { get; set; }
        public int? Sayi { get; set; }
        public string? Turu { get; set; }
    }
}
