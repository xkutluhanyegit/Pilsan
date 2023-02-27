using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksCihazYetkilendirmeZaman
    {
        public int Idno { get; set; }
        public int? GrupKodu { get; set; }
        public DateTime? Baszaman { get; set; }
        public string? Yetkilendirme { get; set; }
    }
}
