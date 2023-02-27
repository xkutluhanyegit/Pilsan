using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class NormKadro
    {
        public int Idno { get; set; }
        public int? Srkodu { get; set; }
        public string? NormKadroAdi { get; set; }
        public string? Alan1 { get; set; }
        public string? Deger1 { get; set; }
        public string? Deger1adi { get; set; }
        public string? Alan2 { get; set; }
        public string? Deger2 { get; set; }
        public string? Deger2adi { get; set; }
        public DateTime? Tarih { get; set; }
        public int? NormKadro1 { get; set; }
    }
}
