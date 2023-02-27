using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OtopuanMail
    {
        public int Idno { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string Email { get; set; } = null!;
        public string Turu { get; set; } = null!;
    }
}
