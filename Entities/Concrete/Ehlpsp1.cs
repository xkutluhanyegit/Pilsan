using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Ehlpsp1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public string? Ehlno { get; set; }
        public string? Ehlcns { get; set; }
        public string? Ehlyer { get; set; }
        public DateTime? Ehltar { get; set; }
        public string? Pspno { get; set; }
        public string? Pspcns { get; set; }
        public string? Pspyer { get; set; }
        public DateTime? Pspvrt { get; set; }
        public DateTime? Pspbtt { get; set; }
    }
}
