using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class OnyLogMesai
    {
        public int Idno { get; set; }
        public int? OnyIdno { get; set; }
        public int? Srkodu { get; set; }
        public string? Prsicil { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? Sure { get; set; }
        public DateTime? Baszaman { get; set; }
        public DateTime? Bitzaman { get; set; }
        public bool? Yemekyer { get; set; }
        public string? Aciklama { get; set; }
        public string? Neden { get; set; }
        public bool? GelisServisKullanim { get; set; }
        public string? GelisServisi { get; set; }
        public DateTime? GelisSaati { get; set; }
        public bool? DonusServisKullanim { get; set; }
        public string? DonusServisi { get; set; }
        public DateTime? DonusSaati { get; set; }
        public string? Kullanici { get; set; }
        public int? Derece { get; set; }
        public bool? Onay { get; set; }
        public DateTime? IslemZamani { get; set; }
    }
}
