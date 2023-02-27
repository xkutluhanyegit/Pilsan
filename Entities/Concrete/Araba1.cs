using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Araba1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public short? Yili { get; set; }
        public string? Plaka { get; set; }
    }
}
