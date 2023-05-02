using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class RprKullanici
    {
        public int Sira { get; set; }
        public string Kladi { get; set; } = null!;
        public string? Sifre { get; set; }
        public string? Aciklama { get; set; }
        public string? Yetkili { get; set; }
        public string? Mail { get; set; }
    }
}
