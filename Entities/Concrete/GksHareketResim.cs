using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksHareketResim
    {
        public int Idno { get; set; }
        public int? CihazNo { get; set; }
        public DateTime? ZamanTrh { get; set; }
        public byte[]? Resim { get; set; }
    }
}
