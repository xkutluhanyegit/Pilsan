using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class ZyHareket
    {
        public int Idno { get; set; }
        public long Keycode { get; set; }
        public long Zyid { get; set; }
        public DateTime Tarih { get; set; }
        public int Kapi { get; set; }
        public int Yon { get; set; }
    }
}
