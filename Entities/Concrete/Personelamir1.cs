using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Personelamir1
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Prsicil { get; set; } = null!;
        public string AmirKodu { get; set; } = null!;
        public int Derece { get; set; }
    }
}
