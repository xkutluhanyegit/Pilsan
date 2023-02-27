using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class ZyMailparam
    {
        public string? Mailgonder { get; set; }
        public string? Hostname { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Portno { get; set; }
        public string? ZyrBilgi { get; set; }
        public string? EvrBilgi { get; set; }
        public string? ArcBilgi { get; set; }
        public int? Sure { get; set; }
        public int? Sayi { get; set; }
    }
}
