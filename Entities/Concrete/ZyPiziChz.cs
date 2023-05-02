using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class ZyPiziChz
    {
        public int Idno { get; set; }
        public string Adi { get; set; } = null!;
        public string Ip { get; set; } = null!;
        public int? Port { get; set; }
    }
}
