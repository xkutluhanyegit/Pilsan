using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Blokehareket
    {
        public int Cid { get; set; }
        public long Keycode { get; set; }
        public DateTime Zaman { get; set; }
        public int Yon { get; set; }
        public int Sebep { get; set; }
        public int Cihaz { get; set; }
    }
}
