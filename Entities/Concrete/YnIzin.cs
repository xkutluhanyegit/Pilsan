using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class YnIzin
    {
        public string Tipi { get; set; } = null!;
        public int Srkodu { get; set; }
        public string Prsicil { get; set; } = null!;
        public DateTime? Tarih { get; set; }
        public string Neden { get; set; } = null!;
        public string? Adi { get; set; }
    }
}
