using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class ZyMailbilgi
    {
        public int Idno { get; set; }
        public string? Mail { get; set; }
        public string? Disfirma { get; set; }
        public string? Dissahis { get; set; }
        public string? Firma { get; set; }
        public string? Departman { get; set; }
        public string? Personel { get; set; }
        public DateTime? Tarih { get; set; }
        public string? Islem { get; set; }
        public string? Durum { get; set; }
        public int? Sayi { get; set; }
    }
}
