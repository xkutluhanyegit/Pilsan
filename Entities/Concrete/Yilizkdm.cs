using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Yilizkdm
    {
        public short Idno { get; set; }
        public int Srkodu { get; set; }
        public string Pertip { get; set; } = null!;
        public string? Kriter { get; set; }
        public short Ilkyil { get; set; }
        public short Sonyil { get; set; }
        public short Hakgun { get; set; }
    }
}
