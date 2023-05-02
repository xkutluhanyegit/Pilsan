using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksSyncMailliste
    {
        public int Idno { get; set; }
        public string? Alici { get; set; }
        public string MailAdresi { get; set; } = null!;
    }
}
