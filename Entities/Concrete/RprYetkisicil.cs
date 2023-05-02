using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class RprYetkisicil
    {
        public int Sira { get; set; }
        public string Kladi { get; set; } = null!;
        public string Sicil { get; set; } = null!;
        public string? Srkodu { get; set; }
    }
}
