using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Seminer1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public string Kuradi { get; set; } = null!;
        public string? Konusu { get; set; }
        public DateTime? Girtar { get; set; }
        public DateTime? Ciktar { get; set; }
        public double? Sure { get; set; }
        public short? Derece { get; set; }
        public string? Suresec { get; set; }
        public double? Ucret { get; set; }
    }
}
