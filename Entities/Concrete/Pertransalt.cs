using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Pertransalt
    {
        public int? Idno { get; set; }
        public string Tipi { get; set; } = null!;
        public string Alan { get; set; } = null!;
        public string? Aciklama { get; set; }
        public int? Sutun { get; set; }
        public short? Sayi { get; set; }
        public string? Bilgi { get; set; }
        public string? Stddeger { get; set; }
        public string? Zorunlu { get; set; }
    }
}
