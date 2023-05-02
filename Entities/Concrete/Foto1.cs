using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Foto1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public byte[]? Foto { get; set; }
    }
}
