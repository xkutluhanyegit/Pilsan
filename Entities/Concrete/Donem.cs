using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Donem
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Adi { get; set; } = null!;
        public DateTime? Ilktarih { get; set; }
        public DateTime? Sontarih { get; set; }
        public string? Aktif { get; set; }
    }
}
