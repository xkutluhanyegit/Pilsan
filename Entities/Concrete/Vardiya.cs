using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Vardiya
    {
        public int? Idno { get; set; }
        public int Srkodu { get; set; }
        public short Kodu { get; set; }
        public string? Adi { get; set; }
        public string Turu { get; set; } = null!;
        public short Grup { get; set; }
        public DateTime? Bassaat { get; set; }
        public DateTime? Bitsaat { get; set; }
        public DateTime? Maxclim { get; set; }
        public short? Haftat { get; set; }
        public DateTime? Erktol { get; set; }
        public DateTime? Gectol { get; set; }
        public short? Arefe { get; set; }
        public DateTime? KntBassaat { get; set; }
        public DateTime? KntBitsaat { get; set; }
        public DateTime? KntMaxclim { get; set; }
        public DateTime? KntErkensure { get; set; }
        public DateTime? KntGecsure { get; set; }
        public int? KntDagitimDerece { get; set; }
        public int? KntMesaiDerece { get; set; }
        public DateTime? KntYmkSure { get; set; }
        public string? TrnKod1 { get; set; }
        public string? TrnKod2 { get; set; }
        public string? TrnKod3 { get; set; }
        public string? TrnKod4 { get; set; }
        public string? TrnKod5 { get; set; }
        public string? HftTuru { get; set; }
    }
}
