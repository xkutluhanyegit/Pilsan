using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Puanlama1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public double? Verim { get; set; }
        public double? Kalite { get; set; }
        public double? Bilgi { get; set; }
        public double? Disiplin { get; set; }
        public double? Baglilik { get; set; }
        public double? Temizlik { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
