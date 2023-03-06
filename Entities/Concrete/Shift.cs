using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Shift
    {
        public int Id { get; set; }
        public string? ShiftName { get; set; }
        public int ShiftCode { get; set; }
    }
}
