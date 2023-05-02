using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class WrDiller
    {
        public int Id { get; set; }
        public string? Dil { get; set; }
        public string? Kodu { get; set; }
        public string? Text { get; set; }
        public string? Tarihformat { get; set; }
    }
}
