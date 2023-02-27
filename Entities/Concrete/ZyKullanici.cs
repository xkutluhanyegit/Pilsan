using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class ZyKullanici
    {
        public int Idno { get; set; }
        public string Kladi { get; set; } = null!;
        public string? Sifre { get; set; }
        public string? Aciklama { get; set; }
        public string? Yetki { get; set; }
    }
}
