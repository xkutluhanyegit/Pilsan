using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksPlaka
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public string? Prsicil { get; set; }
        public string? Plaka { get; set; }
        public bool? Aktif { get; set; }
    }
}
