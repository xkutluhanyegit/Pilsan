using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Zilzaman
    {
        public int Cid { get; set; }
        public int Zilgrup { get; set; }
        public DateTime Baslama { get; set; }
        public DateTime Bitis { get; set; }
        public int Gun { get; set; }
        public string? Zilmsg { get; set; }
    }
}
