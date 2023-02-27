using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyDonemler
    {
        public int Idno { get; set; }
        public int Grupkod { get; set; }
        public string? Grupadi { get; set; }
        public int Srkodu { get; set; }
        public DateTime Bastarih { get; set; }
        public DateTime Bittarih { get; set; }
        public DateTime Sontarih { get; set; }
    }
}
