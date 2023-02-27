using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyMailParam
    {
        public string? Mailgonder { get; set; }
        public string? Hostname { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Portno { get; set; }
        public int? Sayi { get; set; }
        public string? SartMail { get; set; }
        public string? SartOnay { get; set; }
        public string? SartRet { get; set; }
        public string? MailKonusu { get; set; }
        public string? MailAdresi { get; set; }
        public string? Ssl { get; set; }
    }
}
