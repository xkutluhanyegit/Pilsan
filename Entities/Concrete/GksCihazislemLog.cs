using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksCihazislemLog
    {
        public int Idno { get; set; }
        public string? Kullanici { get; set; }
        public int? CihazNo { get; set; }
        public string? IpAdresi { get; set; }
        public string? Islem { get; set; }
        public string? Sonuc { get; set; }
        public DateTime? IslemZamani { get; set; }
    }
}
