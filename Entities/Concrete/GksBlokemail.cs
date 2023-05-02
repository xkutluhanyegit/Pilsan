using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksBlokemail
    {
        public int Idno { get; set; }
        public long? Keycode { get; set; }
        public int? Cihaz { get; set; }
        public DateTime? Zaman { get; set; }
        public bool? Mail { get; set; }
        public DateTime? IslemZamani { get; set; }
    }
}
