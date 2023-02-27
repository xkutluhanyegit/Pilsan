using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksKullanicicihaz
    {
        public int Idno { get; set; }
        public string Kullanici { get; set; } = null!;
        public int CihazNo { get; set; }
    }
}
