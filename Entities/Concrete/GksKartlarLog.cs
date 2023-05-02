using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksKartlarLog
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public string? Prsicil { get; set; }
        public long? Keycode { get; set; }
        public string? Kullanici { get; set; }
        public DateTime? IslemZamani { get; set; }
        public string? IslemTuru { get; set; }
    }
}
