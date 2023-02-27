using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksKullaniciyetki
    {
        public int Idno { get; set; }
        public string? Kullanici { get; set; }
        public int? Srkodu { get; set; }
        public string? Dpkodu { get; set; }
        public string? Menu { get; set; }
        public string? Islem { get; set; }
        public string? Goster { get; set; }
        public string? Ekle { get; set; }
        public string? Degistir { get; set; }
        public string? Sil { get; set; }
        public string? Yetkituru { get; set; }
    }
}
