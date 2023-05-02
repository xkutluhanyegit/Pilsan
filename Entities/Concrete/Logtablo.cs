using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Logtablo
    {
        public int? Srkodu { get; set; }
        public string? Loguser { get; set; }
        public DateTime? Logdate { get; set; }
        public string? Loggrup { get; set; }
        public string? Logtype { get; set; }
        public string? Lognewrec { get; set; }
        public string? Logoldrec { get; set; }
        public int Idno { get; set; }
    }
}
