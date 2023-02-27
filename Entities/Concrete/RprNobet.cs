using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class RprNobet
    {
        public short Idno { get; set; }
        public string Sicil { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public DateTime Bassaat { get; set; }
        public DateTime Bitsaat { get; set; }
        public int? Sayi { get; set; }
    }
}
