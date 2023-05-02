using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Puanturu
    {
        public int? Idno { get; set; }
        public int Srkodu { get; set; }
        public short Kodu { get; set; }
        public string? Aciklama { get; set; }
        public string? Turu { get; set; }
        public string? Gunyuv { get; set; }
        public string? Gunmodu { get; set; }
        public string? Ayyuv { get; set; }
        public string? Aymodu { get; set; }
        public string? Bosgoster { get; set; }
    }
}
