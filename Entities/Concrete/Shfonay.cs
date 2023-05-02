using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Shfonay
    {
        public int? Srkodu { get; set; }
        public DateTime? Tarih { get; set; }
        public string Onay { get; set; } = null!;
        public string? Sicil { get; set; }
        public int? Vardiya { get; set; }
    }
}
