using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksNeden
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public int NedenKodu { get; set; }
        public string? Aciklama { get; set; }
    }
}
