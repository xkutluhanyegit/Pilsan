using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class YilizMahsuptar
    {
        public int Idno { get; set; }
        public int Srkodu { get; set; }
        public string Prsicil { get; set; } = null!;
        public DateTime MahsupTarihi { get; set; }
    }
}
