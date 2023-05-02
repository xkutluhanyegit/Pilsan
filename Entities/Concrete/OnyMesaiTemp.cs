using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyMesaiTemp
    {
        public int Idno { get; set; }
        public string Kladi { get; set; } = null!;
        public int Srkodu { get; set; }
        public string Prsicil { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public DateTime? Sure { get; set; }
        public DateTime? Bastarih { get; set; }
        public DateTime? Bittarih { get; set; }
        public bool? Yemekyer { get; set; }
        public string? Aciklama { get; set; }
        public string? Neden { get; set; }
        public bool? GelisServisKullanim { get; set; }
        public string? GelisServisi { get; set; }
        public DateTime? GelisSaati { get; set; }
        public bool? DonusServisKullanim { get; set; }
        public string? DonusServisi { get; set; }
        public DateTime? DonusSaati { get; set; }
    }
}
