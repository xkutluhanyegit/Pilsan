using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Filtre
    {
        public int Idno { get; set; }
        public string Adi { get; set; } = null!;
        public string Form { get; set; } = null!;
        public string? Izahat { get; set; }
        public string? Tipi { get; set; }
        public string? Wheresql { get; set; }
        public string? Ordersql { get; set; }
    }
}
