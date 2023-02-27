using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Yetkiaylikonay
    {
        public int Idno { get; set; }
        public string? Kullanici { get; set; }
        public string? OnayKullanici { get; set; }
        public bool? EmailGonder { get; set; }
    }
}
