using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Aile1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public DateTime? Evtar { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? Osoyadi { get; set; }
        public string? Dogyer { get; set; }
        public DateTime? Dogtar { get; set; }
        public string? Ogrenim { get; set; }
        public short? Kiz { get; set; }
        public short? Erkek { get; set; }
    }
}
