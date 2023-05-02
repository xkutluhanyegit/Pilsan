using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyPersonelProtokol
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Prsicil { get; set; } = null!;
        public int? ProtokolDurumu { get; set; }
        public DateTime? ProtokolBasimZamani { get; set; }
        public DateTime? ProtokolOnayZamani { get; set; }
    }
}
