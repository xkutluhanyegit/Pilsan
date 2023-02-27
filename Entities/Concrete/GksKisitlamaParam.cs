using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksKisitlamaParam
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public string? Departman { get; set; }
        public DateTime? Baslama { get; set; }
        public DateTime? Bitis { get; set; }
        public int? Kredi { get; set; }
    }
}
