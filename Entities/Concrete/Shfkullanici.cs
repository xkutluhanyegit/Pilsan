using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Shfkullanici
    {
        public int Klsira { get; set; }
        public int Srkodu { get; set; }
        public string Adi { get; set; } = null!;
        public string Sifre { get; set; } = null!;
        public string Izahat { get; set; } = null!;
        public string Adm { get; set; } = null!;
        public string Ytkdepart { get; set; } = null!;
        public string Ytkderece { get; set; } = null!;
        public string? Ik { get; set; }
        public string? ArsivAc { get; set; }
        public string? ArsivKpt { get; set; }
        public string? PostUser { get; set; }
        public string? UserTanim { get; set; }
    }
}
