using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class ZyFoto
    {
        public int Idno { get; set; }
        public int Sicilno { get; set; }
        public byte[] Foto { get; set; } = null!;
    }
}
