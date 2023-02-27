using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Elbise1
    {
        public int Idno { get; set; }
        public string Prsicil { get; set; } = null!;
        public string? Elturu { get; set; }
        public string? Beden { get; set; }
        public string? Verndn { get; set; }
        public DateTime? Tarih { get; set; }
        public short? Miktar { get; set; }
    }
}
