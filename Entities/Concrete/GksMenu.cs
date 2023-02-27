using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksMenu
    {
        public int Idno { get; set; }
        public string Menu { get; set; } = null!;
        public string? MenuAciklama { get; set; }
        public string? Button { get; set; }
    }
}
