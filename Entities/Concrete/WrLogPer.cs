using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class WrLogPer
    {
        public short IdNo { get; set; }
        public DateTime? Zaman { get; set; }
        public string? Sorgu { get; set; }
        public string? Sebep { get; set; }
        public string? Durum { get; set; }
    }
}
