using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Formtablo
    {
        public int Idno { get; set; }
        public string Fadi { get; set; } = null!;
        public string Tadi { get; set; } = null!;
        public string? Alias1 { get; set; }
        public string? Alias2 { get; set; }
        public string? Durum { get; set; }
        public string? Ltadi { get; set; }
    }
}
