using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Ucret1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public double? Ayucr { get; set; }
        public double? Saatucr { get; set; }
        public string? Sosyar { get; set; }
        public string? Yolpar { get; set; }
        public string? Send { get; set; }
        public string? Sgkad { get; set; }
        public string? Sgkno { get; set; }
        public string? Sgktur { get; set; }
        public string? Banka { get; set; }
        public string? Il { get; set; }
        public string? Sube { get; set; }
        public string? Hesap { get; set; }
        public string? Iban { get; set; }
        public string? DirektEndirekt { get; set; }
    }
}
