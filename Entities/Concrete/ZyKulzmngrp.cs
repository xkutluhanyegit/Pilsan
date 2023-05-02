using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class ZyKulzmngrp
    {
        public int Idno { get; set; }
        public string Kladi { get; set; } = null!;
        public string Zmnkodu { get; set; } = null!;
        public string? Zmnadi { get; set; }
    }
}
