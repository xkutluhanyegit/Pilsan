using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class YnViewUser
    {
        public string Kladi { get; set; } = null!;
        public int Idno { get; set; }
        public int Menu { get; set; }
        public string Isim { get; set; } = null!;
    }
}
