using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Sifrekural
    {
        public int Idno { get; set; }
        public int? Uzunluk { get; set; }
        public int? Oncekisifresayi { get; set; }
        public bool? Kullaniciiceremez { get; set; }
        public string? Ilkkarakter { get; set; }
        public bool? Buyukharf { get; set; }
        public int? Buyukharfsayisi { get; set; }
        public bool? Kucukharf { get; set; }
        public int? Kucukharfsayisi { get; set; }
        public bool? Rakam { get; set; }
        public int? Rakamsayisi { get; set; }
        public bool? Digerkarakter { get; set; }
        public int? Digerkaraktersayisi { get; set; }
        public int? Degisikliksure { get; set; }
    }
}
