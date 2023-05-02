using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class GksHaberlesmeParam
    {
        public int? Timeout { get; set; }
        public int? OnlineTimeout { get; set; }
        public int? TtlTimeout { get; set; }
        public int? OnlineBekleme { get; set; }
        public int? OnlineTekrarsay { get; set; }
        public string? PiServer { get; set; }
        public int? PiPort { get; set; }
        public int? PiMaxthread { get; set; }
        public int? PiBekleme { get; set; }
        public int? MaxThread { get; set; }
        public int? ClientPortCezeri { get; set; }
        public int? ClientPortIdstar { get; set; }
        public int? ClientPortBiopass { get; set; }
        public int? ClientPortDiger { get; set; }
    }
}
