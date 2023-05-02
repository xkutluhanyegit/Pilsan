using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Serdinlenme
    {
        public DateTime Baslama { get; set; }
        public DateTime Bitis { get; set; }
        public string Refcal { get; set; } = null!;
        public DateTime? Trnsure { get; set; }
        public string? Trncal { get; set; }
        public DateTime Varsure { get; set; }
        public int Srkodu { get; set; }
        public int Vardiya { get; set; }
    }
}
