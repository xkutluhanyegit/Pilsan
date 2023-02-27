using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyYemekTanim
    {
        public int Idno { get; set; }
        public string? Adi { get; set; }
        public DateTime? Bassaat { get; set; }
        public DateTime? Bitsaat { get; set; }
    }
}
