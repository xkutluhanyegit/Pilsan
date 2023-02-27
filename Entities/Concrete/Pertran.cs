using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Pertran
    {
        public int? Idno { get; set; }
        public string Tipi { get; set; } = null!;
        public string? Dosya { get; set; }
        public short? Basla { get; set; }
        public string? Yedek { get; set; }
    }
}
