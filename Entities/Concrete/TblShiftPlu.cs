using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class TblShiftPlu
    {
        public int Id { get; set; }
        public int? ShiftPlusCode { get; set; }
        public string? ShiftPlusName { get; set; }
    }
}
