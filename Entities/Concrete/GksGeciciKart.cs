using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksGeciciKart
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Kartno { get; set; } = null!;
        public string? Aciklama { get; set; }
        public long? KartId { get; set; }
    }
}
