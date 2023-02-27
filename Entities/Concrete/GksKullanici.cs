using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksKullanici
    {
        public int Idno { get; set; }
        public string? Kullanici { get; set; }
        public string? Sifre { get; set; }
        public string? Aciklama { get; set; }
        public string? Admin { get; set; }
    }
}
