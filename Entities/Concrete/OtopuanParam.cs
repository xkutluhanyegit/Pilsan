using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OtopuanParam
    {
        public int Idno { get; set; }
        public DateTime Zaman { get; set; }
        public string? IlktarihParam { get; set; }
        public int? IlktarihGun { get; set; }
        public string? SontarihParam { get; set; }
        public int? SontarihGun { get; set; }
    }
}
