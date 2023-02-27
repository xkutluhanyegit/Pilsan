using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class ZyTanim
    {
        public int Zyid { get; set; }
        public int Sicil { get; set; }
        public string? Isim { get; set; }
        public string? Firma { get; set; }
        public string? ZSirket { get; set; }
        public string? ZIsim { get; set; }
        public string? ZDepartman { get; set; }
        public string? Aciklama { get; set; }
        public string? Kartno { get; set; }
        public DateTime? GrsTarih { get; set; }
        public DateTime? CksTarih { get; set; }
        public string? ZSicil { get; set; }
        public string? ZyPlaka { get; set; }
    }
}
