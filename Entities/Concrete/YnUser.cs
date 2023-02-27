using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class YnUser
    {
        public int Idno { get; set; }
        public string UserAdi { get; set; } = null!;
        public string? UserSifre { get; set; }
        public string? Yetkili { get; set; }
        public string? Isim { get; set; }
        public string? Email { get; set; }
    }
}
