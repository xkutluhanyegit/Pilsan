using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksMesaj
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public int MesajNo { get; set; }
        public string? MesajTuru { get; set; }
        public DateTime? Baslama { get; set; }
        public int? Sure { get; set; }
        public string? SureTuru { get; set; }
        public string? Satir1 { get; set; }
        public string? Satir2 { get; set; }
        public string? Satir3 { get; set; }
        public string? Satir4 { get; set; }
        public string? Satir5 { get; set; }
        public int? Okundu { get; set; }
    }
}
