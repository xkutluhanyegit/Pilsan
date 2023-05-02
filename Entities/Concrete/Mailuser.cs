using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Mailuser
    {
        public string Kullanici { get; set; } = null!;
        public string? Mailserver { get; set; }
        public string? Mailuser1 { get; set; }
        public string? Mailpassword { get; set; }
        public string? Mailadress { get; set; }
        public int? Mailport { get; set; }
        public string? Maillogin { get; set; }
        public bool? Mailssl { get; set; }
    }
}
