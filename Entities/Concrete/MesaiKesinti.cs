using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class MesaiKesinti
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Pertip { get; set; } = null!;
    }
}
