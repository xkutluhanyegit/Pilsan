using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Sistem
    {
        public short Idno { get; set; }
        public string Adi { get; set; } = null!;
        public string Tipi { get; set; } = null!;
        public string? Transfer { get; set; }
        public string Protocol { get; set; } = null!;
        public string? Hostname { get; set; }
        public string? Tablo { get; set; }
        public string? Masterusr { get; set; }
        public string? Masterpswd { get; set; }
        public string? Veriyolu { get; set; }
        public DateTime? Oksure { get; set; }
        public DateTime? Gunlim { get; set; }
        public string? Gcvar { get; set; }
        public string? Gkodu { get; set; }
        public string? Ckodu { get; set; }
        public string? Refcolumn { get; set; }
        public string? Refid { get; set; }
        public string? Txtgcknt { get; set; }
        public string? Saniye { get; set; }
        public string? RemoteHostname { get; set; }
        public string? Sorgu { get; set; }
        public bool? Ilksonhar { get; set; }
        public string? IlksonGndtipi { get; set; }
        public DateTime? IlksonGndsaat { get; set; }
        public string? IlksonGckontrol { get; set; }
        public DateTime? IlksonKontrolTolerans { get; set; }
        public bool? OksureTekyon { get; set; }
    }
}
