using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Yuvarlama
    {
        public int Idno { get; set; }
        public short Kodu { get; set; }
        public string Adi { get; set; } = null!;
    }
}
