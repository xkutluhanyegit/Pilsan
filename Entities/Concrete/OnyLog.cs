using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyLog
    {
        public int Idno { get; set; }
        public DateTime? Zaman { get; set; }
        public string? Kullanici { get; set; }
        public string? Sicilno { get; set; }
        public DateTime? Tarih { get; set; }
        public string? Tablo { get; set; }
        public string? Deger { get; set; }
        public string? Islem { get; set; }
    }
}
