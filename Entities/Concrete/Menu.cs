using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Menu
    {
        public int? Idno { get; set; }
        public string Adi { get; set; } = null!;
        public string? Izahat { get; set; }
        public string? Anamenu { get; set; }
        public string? Aizahat { get; set; }
    }
}
