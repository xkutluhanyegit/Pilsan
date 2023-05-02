using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksCihazReaderLocker
    {
        public int Id { get; set; }
        public int? Srkodu { get; set; }
        public string? CihazNo { get; set; }
        public string? PortNo { get; set; }
        public string DolapNo { get; set; } = null!;
    }
}
