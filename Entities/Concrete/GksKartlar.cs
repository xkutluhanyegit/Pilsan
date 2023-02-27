using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksKartlar
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public string? Prsicil { get; set; }
        public long? Keycode { get; set; }
        public string? Tipi { get; set; }
    }
}
