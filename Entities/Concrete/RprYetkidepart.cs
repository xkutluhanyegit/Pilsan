using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class RprYetkidepart
    {
        public int Sira { get; set; }
        public string Kladi { get; set; } = null!;
        public string Departman { get; set; } = null!;
        public string? Srkodu { get; set; }
    }
}
