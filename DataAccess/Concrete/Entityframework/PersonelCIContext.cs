using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Entities.Concrete;


namespace DataAccess.Concrete
{
    public partial class PersonelCIContext : DbContext
    {
        public PersonelCIContext()
        {
        }

        public PersonelCIContext(DbContextOptions<PersonelCIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aciklama> Aciklamas { get; set; } = null!;
        public virtual DbSet<Adres1> Adres1s { get; set; } = null!;
        public virtual DbSet<Aile1> Aile1s { get; set; } = null!;
        public virtual DbSet<Alan> Alans { get; set; } = null!;
        public virtual DbSet<Altdepart> Altdeparts { get; set; } = null!;
        public virtual DbSet<Araba1> Araba1s { get; set; } = null!;
        public virtual DbSet<Aypuan1> Aypuan1s { get; set; } = null!;
        public virtual DbSet<Banka> Bankas { get; set; } = null!;
        public virtual DbSet<BankaSube> BankaSubes { get; set; } = null!;
        public virtual DbSet<BioVeriyolu> BioVeriyolus { get; set; } = null!;
        public virtual DbSet<Birim> Birims { get; set; } = null!;
        public virtual DbSet<BlkSebep> BlkSebeps { get; set; } = null!;
        public virtual DbSet<Blokehareket> Blokeharekets { get; set; } = null!;
        public virtual DbSet<Bolum> Bolums { get; set; } = null!;
        public virtual DbSet<Bordrobaslik> Bordrobasliks { get; set; } = null!;
        public virtual DbSet<Bordrosatir> Bordrosatirs { get; set; } = null!;
        public virtual DbSet<Bordrotanim> Bordrotanims { get; set; } = null!;
        public virtual DbSet<Calisdgl> Calisdgls { get; set; } = null!;
        public virtual DbSet<Calisma> Calismas { get; set; } = null!;
        public virtual DbSet<CalismaSaatizinZorunlusaat> CalismaSaatizinZorunlusaats { get; set; } = null!;
        public virtual DbSet<Calismablg1> Calismablg1s { get; set; } = null!;
        public virtual DbSet<Calisonay> Calisonays { get; set; } = null!;
        public virtual DbSet<Calsurelimit> Calsurelimits { get; set; } = null!;
        public virtual DbSet<Cihaz> Cihazs { get; set; } = null!;
        public virtual DbSet<Cihazgrup> Cihazgrups { get; set; } = null!;
        public virtual DbSet<Cikissebep> Cikissebeps { get; set; } = null!;
        public virtual DbSet<Cocuk1> Cocuk1s { get; set; } = null!;
        public virtual DbSet<DenklestirmeLog> DenklestirmeLogs { get; set; } = null!;
        public virtual DbSet<DenklestirmeParam> DenklestirmeParams { get; set; } = null!;
        public virtual DbSet<DenklestirmeParamDetay> DenklestirmeParamDetays { get; set; } = null!;
        public virtual DbSet<DenklestirmePuantaj> DenklestirmePuantajs { get; set; } = null!;
        public virtual DbSet<Departman> Departmen { get; set; } = null!;
        public virtual DbSet<Dernek1> Dernek1s { get; set; } = null!;
        public virtual DbSet<Devamsiz> Devamsizs { get; set; } = null!;
        public virtual DbSet<Devamsizke> Devamsizkes { get; set; } = null!;
        public virtual DbSet<Donem> Donems { get; set; } = null!;
        public virtual DbSet<Durak> Duraks { get; set; } = null!;
        public virtual DbSet<Dusunce1> Dusunce1s { get; set; } = null!;
        public virtual DbSet<Egitim1> Egitim1s { get; set; } = null!;
        public virtual DbSet<Ehlpsp1> Ehlpsp1s { get; set; } = null!;
        public virtual DbSet<Elbise1> Elbise1s { get; set; } = null!;
        public virtual DbSet<Elbisebeden> Elbisebedens { get; set; } = null!;
        public virtual DbSet<Elbiseblg1> Elbiseblg1s { get; set; } = null!;
        public virtual DbSet<Elbiseturu> Elbiseturus { get; set; } = null!;
        public virtual DbSet<Esnekgrup> Esnekgrups { get; set; } = null!;
        public virtual DbSet<Esnekvardiya> Esnekvardiyas { get; set; } = null!;
        public virtual DbSet<Filtre> Filtres { get; set; } = null!;
        public virtual DbSet<Filtred> Filtreds { get; set; } = null!;
        public virtual DbSet<Fmdenk> Fmdenks { get; set; } = null!;
        public virtual DbSet<Fmdenkalt> Fmdenkalts { get; set; } = null!;
        public virtual DbSet<Fmkontrol> Fmkontrols { get; set; } = null!;
        public virtual DbSet<Fmned> Fmneds { get; set; } = null!;
        public virtual DbSet<Form> Forms { get; set; } = null!;
        public virtual DbSet<Formtablo> Formtablos { get; set; } = null!;
        public virtual DbSet<Foto1> Foto1s { get; set; } = null!;
        public virtual DbSet<Gayrimen1> Gayrimen1s { get; set; } = null!;
        public virtual DbSet<Gecicikart> Gecicikarts { get; set; } = null!;
        public virtual DbSet<GksBlokeharMailadre> GksBlokeharMailadres { get; set; } = null!;
        public virtual DbSet<GksBlokehareket> GksBlokeharekets { get; set; } = null!;
        public virtual DbSet<GksBlokemail> GksBlokemails { get; set; } = null!;
        public virtual DbSet<GksCihaz> GksCihazs { get; set; } = null!;
        public virtual DbSet<GksCihazBolge> GksCihazBolges { get; set; } = null!;
        public virtual DbSet<GksCihazPrinter> GksCihazPrinters { get; set; } = null!;
        public virtual DbSet<GksCihazReader> GksCihazReaders { get; set; } = null!;
        public virtual DbSet<GksCihazReaderId> GksCihazReaderIds { get; set; } = null!;
        public virtual DbSet<GksCihazReaderLocker> GksCihazReaderLockers { get; set; } = null!;
        public virtual DbSet<GksCihazReaderLockerPersonel> GksCihazReaderLockerPersonels { get; set; } = null!;
        public virtual DbSet<GksCihazYetkilendirmeGrup> GksCihazYetkilendirmeGrups { get; set; } = null!;
        public virtual DbSet<GksCihazYetkilendirmeZaman> GksCihazYetkilendirmeZamen { get; set; } = null!;
        public virtual DbSet<GksCihazgrup> GksCihazgrups { get; set; } = null!;
        public virtual DbSet<GksCihazislemLog> GksCihazislemLogs { get; set; } = null!;
        public virtual DbSet<GksFace> GksFaces { get; set; } = null!;
        public virtual DbSet<GksGeciciHareket> GksGeciciHarekets { get; set; } = null!;
        public virtual DbSet<GksGeciciKart> GksGeciciKarts { get; set; } = null!;
        public virtual DbSet<GksGrupcihaz> GksGrupcihazs { get; set; } = null!;
        public virtual DbSet<GksHaberlesmeParam> GksHaberlesmeParams { get; set; } = null!;
        public virtual DbSet<GksHareket> GksHarekets { get; set; } = null!;
        public virtual DbSet<GksHareketResim> GksHareketResims { get; set; } = null!;
        public virtual DbSet<GksHareketZyr> GksHareketZyrs { get; set; } = null!;
        public virtual DbSet<GksKapiDurum> GksKapiDurums { get; set; } = null!;
        public virtual DbSet<GksKapiLog> GksKapiLogs { get; set; } = null!;
        public virtual DbSet<GksKartlar> GksKartlars { get; set; } = null!;
        public virtual DbSet<GksKartlarLog> GksKartlarLogs { get; set; } = null!;
        public virtual DbSet<GksKisitlama> GksKisitlamas { get; set; } = null!;
        public virtual DbSet<GksKisitlamaParam> GksKisitlamaParams { get; set; } = null!;
        public virtual DbSet<GksKrediLog> GksKrediLogs { get; set; } = null!;
        public virtual DbSet<GksKrediParam> GksKrediParams { get; set; } = null!;
        public virtual DbSet<GksKullanici> GksKullanicis { get; set; } = null!;
        public virtual DbSet<GksKullanicicihaz> GksKullanicicihazs { get; set; } = null!;
        public virtual DbSet<GksKullaniciyetki> GksKullaniciyetkis { get; set; } = null!;
        public virtual DbSet<GksMenu> GksMenus { get; set; } = null!;
        public virtual DbSet<GksMesaj> GksMesajs { get; set; } = null!;
        public virtual DbSet<GksNeden> GksNedens { get; set; } = null!;
        public virtual DbSet<GksNedenKarti> GksNedenKartis { get; set; } = null!;
        public virtual DbSet<GksOnlineHarindex> GksOnlineHarindices { get; set; } = null!;
        public virtual DbSet<GksParam> GksParams { get; set; } = null!;
        public virtual DbSet<GksParmakizi> GksParmakizis { get; set; } = null!;
        public virtual DbSet<GksPerislem> GksPerislems { get; set; } = null!;
        public virtual DbSet<GksPlaka> GksPlakas { get; set; } = null!;
        public virtual DbSet<GksSonhareket> GksSonharekets { get; set; } = null!;
        public virtual DbSet<GksSyncCihazgrup> GksSyncCihazgrups { get; set; } = null!;
        public virtual DbSet<GksSyncGrupcihaz> GksSyncGrupcihazs { get; set; } = null!;
        public virtual DbSet<GksSyncGrupzaman> GksSyncGrupzamen { get; set; } = null!;
        public virtual DbSet<GksSyncLog> GksSyncLogs { get; set; } = null!;
        public virtual DbSet<GksSyncMailcihaz> GksSyncMailcihazs { get; set; } = null!;
        public virtual DbSet<GksSyncMailliste> GksSyncMaillistes { get; set; } = null!;
        public virtual DbSet<GksSyncTanim> GksSyncTanims { get; set; } = null!;
        public virtual DbSet<GksSyncZamangrup> GksSyncZamangrups { get; set; } = null!;
        public virtual DbSet<GksVersion> GksVersions { get; set; } = null!;
        public virtual DbSet<GksYetkitanim> GksYetkitanims { get; set; } = null!;
        public virtual DbSet<GksYetkitanimAsansor> GksYetkitanimAsansors { get; set; } = null!;
        public virtual DbSet<GksYtkCihazgrup> GksYtkCihazgrups { get; set; } = null!;
        public virtual DbSet<GksYtkGrupcihaz> GksYtkGrupcihazs { get; set; } = null!;
        public virtual DbSet<GksYtkGruppersonel> GksYtkGruppersonels { get; set; } = null!;
        public virtual DbSet<GksYtkGrupzaman> GksYtkGrupzamen { get; set; } = null!;
        public virtual DbSet<GksYtkPersonelgrup> GksYtkPersonelgrups { get; set; } = null!;
        public virtual DbSet<GksYtkZamangrup> GksYtkZamangrups { get; set; } = null!;
        public virtual DbSet<Golgeprim> Golgeprims { get; set; } = null!;
        public virtual DbSet<Gorev> Gorevs { get; set; } = null!;
        public virtual DbSet<Grup> Grups { get; set; } = null!;
        public virtual DbSet<Grupcihazlari> Grupcihazlaris { get; set; } = null!;
        public virtual DbSet<Gunizin1> Gunizin1s { get; set; } = null!;
        public virtual DbSet<Haberci1> Haberci1s { get; set; } = null!;
        public virtual DbSet<Hareket1> Hareket1s { get; set; } = null!;
        public virtual DbSet<Hareketler> Hareketlers { get; set; } = null!;
        public virtual DbSet<Harlog1> Harlog1s { get; set; } = null!;
        public virtual DbSet<Hartemp> Hartemps { get; set; } = null!;
        public virtual DbSet<Hatagc> Hatagcs { get; set; } = null!;
        public virtual DbSet<Hobi1> Hobi1s { get; set; } = null!;
        public virtual DbSet<Hpparam> Hpparams { get; set; } = null!;
        public virtual DbSet<Hpparamalt> Hpparamalts { get; set; } = null!;
        public virtual DbSet<Hpuantaj1> Hpuantaj1s { get; set; } = null!;
        public virtual DbSet<Htke> Htkes { get; set; } = null!;
        public virtual DbSet<Htkesdgl> Htkesdgls { get; set; } = null!;
        public virtual DbSet<Iliski> Iliskis { get; set; } = null!;
        public virtual DbSet<IzinOnay> IzinOnays { get; set; } = null!;
        public virtual DbSet<IzinOnaySaat> IzinOnaySaats { get; set; } = null!;
        public virtual DbSet<Izindagit> Izindagits { get; set; } = null!;
        public virtual DbSet<Izinlimit> Izinlimits { get; set; } = null!;
        public virtual DbSet<IzinlimitGrupdetay> IzinlimitGrupdetays { get; set; } = null!;
        public virtual DbSet<IzinlimitPergrup> IzinlimitPergrups { get; set; } = null!;
        public virtual DbSet<Izinlog1> Izinlog1s { get; set; } = null!;
        public virtual DbSet<Izneden> Iznedens { get; set; } = null!;
        public virtual DbSet<Kadro> Kadros { get; set; } = null!;
        public virtual DbSet<Kariyer1> Kariyer1s { get; set; } = null!;
        public virtual DbSet<Kartlar> Kartlars { get; set; } = null!;
        public virtual DbSet<Kimlik1> Kimlik1s { get; set; } = null!;
        public virtual DbSet<KntAypuan1> KntAypuan1s { get; set; } = null!;
        public virtual DbSet<KntGunizin1> KntGunizin1s { get; set; } = null!;
        public virtual DbSet<KntHareket1> KntHareket1s { get; set; } = null!;
        public virtual DbSet<KntParam> KntParams { get; set; } = null!;
        public virtual DbSet<KntPersonelFm1> KntPersonelFm1s { get; set; } = null!;
        public virtual DbSet<KntPervardiya> KntPervardiyas { get; set; } = null!;
        public virtual DbSet<KntPuantaj1> KntPuantaj1s { get; set; } = null!;
        public virtual DbSet<KntSaatizin1> KntSaatizin1s { get; set; } = null!;
        public virtual DbSet<KntVardiya> KntVardiyas { get; set; } = null!;
        public virtual DbSet<KodBazliYetkili> KodBazliYetkilis { get; set; } = null!;
        public virtual DbSet<Kullanici> Kullanicis { get; set; } = null!;
        public virtual DbSet<Lisan> Lisans { get; set; } = null!;
        public virtual DbSet<Logtablo> Logtablos { get; set; } = null!;
        public virtual DbSet<LokasyonToleran> LokasyonTolerans { get; set; } = null!;
        public virtual DbSet<LokasyonToleransCihaz> LokasyonToleransCihazs { get; set; } = null!;
        public virtual DbSet<Maildepart> Maildeparts { get; set; } = null!;
        public virtual DbSet<Mailkod> Mailkods { get; set; } = null!;
        public virtual DbSet<Mailparam> Mailparams { get; set; } = null!;
        public virtual DbSet<Mailuser> Mailusers { get; set; } = null!;
        public virtual DbSet<MasrafMerkezi> MasrafMerkezis { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<Mesai> Mesais { get; set; } = null!;
        public virtual DbSet<MesaiKesinti> MesaiKesintis { get; set; } = null!;
        public virtual DbSet<MesaiKesintiparam> MesaiKesintiparams { get; set; } = null!;
        public virtual DbSet<MesaiOnay> MesaiOnays { get; set; } = null!;
        public virtual DbSet<Mesaike> Mesaikes { get; set; } = null!;
        public virtual DbSet<Meslek> Mesleks { get; set; } = null!;
        public virtual DbSet<NormKadro> NormKadros { get; set; } = null!;
        public virtual DbSet<NormKadroArsiv> NormKadroArsivs { get; set; } = null!;
        public virtual DbSet<Okul> Okuls { get; set; } = null!;
        public virtual DbSet<OnyDonemler> OnyDonemlers { get; set; } = null!;
        public virtual DbSet<OnyGrpFmnedTnm> OnyGrpFmnedTnms { get; set; } = null!;
        public virtual DbSet<OnyGrpFmnedVeri> OnyGrpFmnedVeris { get; set; } = null!;
        public virtual DbSet<OnyGrpIzinTnm> OnyGrpIzinTnms { get; set; } = null!;
        public virtual DbSet<OnyGrpIzinVeri> OnyGrpIzinVeris { get; set; } = null!;
        public virtual DbSet<OnyGrpKulTnm> OnyGrpKulTnms { get; set; } = null!;
        public virtual DbSet<OnyGrpKulVeri> OnyGrpKulVeris { get; set; } = null!;
        public virtual DbSet<OnyGrpTanimlar> OnyGrpTanimlars { get; set; } = null!;
        public virtual DbSet<OnyGunizin> OnyGunizins { get; set; } = null!;
        public virtual DbSet<OnyGunizinTemp> OnyGunizinTemps { get; set; } = null!;
        public virtual DbSet<OnyLog> OnyLogs { get; set; } = null!;
        public virtual DbSet<OnyLogGunizin> OnyLogGunizins { get; set; } = null!;
        public virtual DbSet<OnyLogMesai> OnyLogMesais { get; set; } = null!;
        public virtual DbSet<OnyLogMesaiGercek> OnyLogMesaiGerceks { get; set; } = null!;
        public virtual DbSet<OnyLogSaatizin> OnyLogSaatizins { get; set; } = null!;
        public virtual DbSet<OnyLogTaksi> OnyLogTaksis { get; set; } = null!;
        public virtual DbSet<OnyLogVardiya> OnyLogVardiyas { get; set; } = null!;
        public virtual DbSet<OnyMailGrp> OnyMailGrps { get; set; } = null!;
        public virtual DbSet<OnyMailKodlar> OnyMailKodlars { get; set; } = null!;
        public virtual DbSet<OnyMailKulGrpTnm> OnyMailKulGrpTnms { get; set; } = null!;
        public virtual DbSet<OnyMailKulGrpVeri> OnyMailKulGrpVeris { get; set; } = null!;
        public virtual DbSet<OnyMailListe> OnyMailListes { get; set; } = null!;
        public virtual DbSet<OnyMailParam> OnyMailParams { get; set; } = null!;
        public virtual DbSet<OnyMailSartlar> OnyMailSartlars { get; set; } = null!;
        public virtual DbSet<OnyMailSayi> OnyMailSayis { get; set; } = null!;
        public virtual DbSet<OnyMailSrvGrp> OnyMailSrvGrps { get; set; } = null!;
        public virtual DbSet<OnyMailZmnGrpTnm> OnyMailZmnGrpTnms { get; set; } = null!;
        public virtual DbSet<OnyMailZmnGrpVeri> OnyMailZmnGrpVeris { get; set; } = null!;
        public virtual DbSet<OnyMesai> OnyMesais { get; set; } = null!;
        public virtual DbSet<OnyMesaiGercek> OnyMesaiGerceks { get; set; } = null!;
        public virtual DbSet<OnyMesaiGercekTemp> OnyMesaiGercekTemps { get; set; } = null!;
        public virtual DbSet<OnyMesaiTemp> OnyMesaiTemps { get; set; } = null!;
        public virtual DbSet<OnyParametre> OnyParametres { get; set; } = null!;
        public virtual DbSet<OnyPersonelProtokol> OnyPersonelProtokols { get; set; } = null!;
        public virtual DbSet<OnySaatizin> OnySaatizins { get; set; } = null!;
        public virtual DbSet<OnySaatizinTemp> OnySaatizinTemps { get; set; } = null!;
        public virtual DbSet<OnyTaksi> OnyTaksis { get; set; } = null!;
        public virtual DbSet<OnyTaksiTemp> OnyTaksiTemps { get; set; } = null!;
        public virtual DbSet<OnyVardiya> OnyVardiyas { get; set; } = null!;
        public virtual DbSet<OnyVardiyaTemp> OnyVardiyaTemps { get; set; } = null!;
        public virtual DbSet<OnyVekalet> OnyVekalets { get; set; } = null!;
        public virtual DbSet<OnyYemekTanim> OnyYemekTanims { get; set; } = null!;
        public virtual DbSet<OnyZyrYmkTnm> OnyZyrYmkTnms { get; set; } = null!;
        public virtual DbSet<Oteleme> Otelemes { get; set; } = null!;
        public virtual DbSet<OtomailRpdisardum> OtomailRpdisarda { get; set; } = null!;
        public virtual DbSet<OtomailRpeksikhar> OtomailRpeksikhars { get; set; } = null!;
        public virtual DbSet<OtomailRpgecerken> OtomailRpgecerkens { get; set; } = null!;
        public virtual DbSet<OtomailRpgelmeyen> OtomailRpgelmeyens { get; set; } = null!;
        public virtual DbSet<OtomailRpgirisciki> OtomailRpgiriscikis { get; set; } = null!;
        public virtual DbSet<OtomailRpgunizin> OtomailRpgunizins { get; set; } = null!;
        public virtual DbSet<OtomailRpicerde> OtomailRpicerdes { get; set; } = null!;
        public virtual DbSet<OtomailRpsaatizin> OtomailRpsaatizins { get; set; } = null!;
        public virtual DbSet<Otomaildepart> Otomaildeparts { get; set; } = null!;
        public virtual DbSet<Otomailparam> Otomailparams { get; set; } = null!;
        public virtual DbSet<Otomailyetki> Otomailyetkis { get; set; } = null!;
        public virtual DbSet<OtopuanMail> OtopuanMails { get; set; } = null!;
        public virtual DbSet<OtopuanParam> OtopuanParams { get; set; } = null!;
        public virtual DbSet<Otorapor> Otorapors { get; set; } = null!;
        public virtual DbSet<Otorpkolon> Otorpkolons { get; set; } = null!;
        public virtual DbSet<Otorpparam> Otorpparams { get; set; } = null!;
        public virtual DbSet<Overtime> Overtimes { get; set; } = null!;
        public virtual DbSet<PasifDonem> PasifDonems { get; set; } = null!;
        public virtual DbSet<Perarsiv1> Perarsiv1s { get; set; } = null!;
        public virtual DbSet<Personel> Personels { get; set; } = null!;
        public virtual DbSet<Personel1> Personel1s { get; set; } = null!;
        public virtual DbSet<PersonelAmir> PersonelAmirs { get; set; } = null!;
        public virtual DbSet<Personelamir1> Personelamirs1 { get; set; } = null!;
        public virtual DbSet<Personelovertime> Personelovertimes { get; set; } = null!;
        public virtual DbSet<Personelshift> Personelshifts { get; set; } = null!;
        public virtual DbSet<Pertipi> Pertipis { get; set; } = null!;
        public virtual DbSet<Pertran> Pertrans { get; set; } = null!;
        public virtual DbSet<Pertransalt> Pertransalts { get; set; } = null!;
        public virtual DbSet<Pervardiya1> Pervardiya1s { get; set; } = null!;
        public virtual DbSet<Perversion> Perversions { get; set; } = null!;
        public virtual DbSet<PgsDnkParam> PgsDnkParams { get; set; } = null!;
        public virtual DbSet<PntListe> PntListes { get; set; } = null!;
        public virtual DbSet<PntListealt> PntListealts { get; set; } = null!;
        public virtual DbSet<Postatil> Postatils { get; set; } = null!;
        public virtual DbSet<Postavar> Postavars { get; set; } = null!;
        public virtual DbSet<Postum> Posta { get; set; } = null!;
        public virtual DbSet<Prgparam> Prgparams { get; set; } = null!;
        public virtual DbSet<Puancal> Puancals { get; set; } = null!;
        public virtual DbSet<Puanlama1> Puanlama1s { get; set; } = null!;
        public virtual DbSet<Puantaj1> Puantaj1s { get; set; } = null!;
        public virtual DbSet<PuantajEsnekTarih> PuantajEsnekTarihs { get; set; } = null!;
        public virtual DbSet<PuantajLog> PuantajLogs { get; set; } = null!;
        public virtual DbSet<PuantajToleransLog> PuantajToleransLogs { get; set; } = null!;
        public virtual DbSet<Puanturu> Puanturus { get; set; } = null!;
        public virtual DbSet<Rapor> Rapors { get; set; } = null!;
        public virtual DbSet<RaporHareket> RaporHarekets { get; set; } = null!;
        public virtual DbSet<Refidlog> Refidlogs { get; set; } = null!;
        public virtual DbSet<RpOzelrapor> RpOzelrapors { get; set; } = null!;
        public virtual DbSet<Rpalan> Rpalans { get; set; } = null!;
        public virtual DbSet<Rpalanstd> Rpalanstds { get; set; } = null!;
        public virtual DbSet<Rpgrup> Rpgrups { get; set; } = null!;
        public virtual DbSet<Rppreview> Rppreviews { get; set; } = null!;
        public virtual DbSet<RprForm> RprForms { get; set; } = null!;
        public virtual DbSet<RprFormat> RprFormats { get; set; } = null!;
        public virtual DbSet<RprGunizin> RprGunizins { get; set; } = null!;
        public virtual DbSet<RprKulform> RprKulforms { get; set; } = null!;
        public virtual DbSet<RprKulgrup> RprKulgrups { get; set; } = null!;
        public virtual DbSet<RprKulgrupchz> RprKulgrupchzs { get; set; } = null!;
        public virtual DbSet<RprKullanici> RprKullanicis { get; set; } = null!;
        public virtual DbSet<RprKulliste> RprKullistes { get; set; } = null!;
        public virtual DbSet<RprListe> RprListes { get; set; } = null!;
        public virtual DbSet<RprLog> RprLogs { get; set; } = null!;
        public virtual DbSet<RprMailparam> RprMailparams { get; set; } = null!;
        public virtual DbSet<RprMola> RprMolas { get; set; } = null!;
        public virtual DbSet<RprNeden> RprNedens { get; set; } = null!;
        public virtual DbSet<RprNobet> RprNobets { get; set; } = null!;
        public virtual DbSet<RprSaatizin> RprSaatizins { get; set; } = null!;
        public virtual DbSet<RprToplam> RprToplams { get; set; } = null!;
        public virtual DbSet<RprVersiyon> RprVersiyons { get; set; } = null!;
        public virtual DbSet<RprYetkicihaz> RprYetkicihazs { get; set; } = null!;
        public virtual DbSet<RprYetkidepart> RprYetkideparts { get; set; } = null!;
        public virtual DbSet<RprYetkisicil> RprYetkisicils { get; set; } = null!;
        public virtual DbSet<RprYetkisirket> RprYetkisirkets { get; set; } = null!;
        public virtual DbSet<RprYmk> RprYmks { get; set; } = null!;
        public virtual DbSet<Rprfiltre> Rprfiltres { get; set; } = null!;
        public virtual DbSet<Rprfiltred> Rprfiltreds { get; set; } = null!;
        public virtual DbSet<Rprtablo> Rprtablos { get; set; } = null!;
        public virtual DbSet<Rpsorgu> Rpsorgus { get; set; } = null!;
        public virtual DbSet<Rptablo> Rptablos { get; set; } = null!;
        public virtual DbSet<Saatizin1> Saatizin1s { get; set; } = null!;
        public virtual DbSet<Seminer1> Seminer1s { get; set; } = null!;
        public virtual DbSet<Serbesttatil1> Serbesttatil1s { get; set; } = null!;
        public virtual DbSet<Serdinlenme> Serdinlenmes { get; set; } = null!;
        public virtual DbSet<Serizin> Serizins { get; set; } = null!;
        public virtual DbSet<Servi> Servis { get; set; } = null!;
        public virtual DbSet<ShfVersiyon> ShfVersiyons { get; set; } = null!;
        public virtual DbSet<Shfgunizin> Shfgunizins { get; set; } = null!;
        public virtual DbSet<Shfhareket> Shfharekets { get; set; } = null!;
        public virtual DbSet<Shfkullanici> Shfkullanicis { get; set; } = null!;
        public virtual DbSet<Shflog> Shflogs { get; set; } = null!;
        public virtual DbSet<Shfmesai> Shfmesais { get; set; } = null!;
        public virtual DbSet<Shfonay> Shfonays { get; set; } = null!;
        public virtual DbSet<Shfsaatizin> Shfsaatizins { get; set; } = null!;
        public virtual DbSet<Shfyedek> Shfyedeks { get; set; } = null!;
        public virtual DbSet<Shfyetkidepart> Shfyetkideparts { get; set; } = null!;
        public virtual DbSet<Shfyetkivardiya> Shfyetkivardiyas { get; set; } = null!;
        public virtual DbSet<Shift> Shifts { get; set; } = null!;
        public virtual DbSet<Sifrekural> Sifrekurals { get; set; } = null!;
        public virtual DbSet<Sirket> Sirkets { get; set; } = null!;
        public virtual DbSet<Sisgk> Sisgks { get; set; } = null!;
        public virtual DbSet<Sismesai> Sismesais { get; set; } = null!;
        public virtual DbSet<Sisparam> Sisparams { get; set; } = null!;
        public virtual DbSet<Sistem> Sistems { get; set; } = null!;
        public virtual DbSet<Sisveri> Sisveris { get; set; } = null!;
        public virtual DbSet<Stdrapor> Stdrapors { get; set; } = null!;
        public virtual DbSet<Sube> Subes { get; set; } = null!;
        public virtual DbSet<Tablo> Tablos { get; set; } = null!;
        public virtual DbSet<Takvim> Takvims { get; set; } = null!;
        public virtual DbSet<Tarihler> Tarihlers { get; set; } = null!;
        public virtual DbSet<TblShiftPlu> TblShiftPlus { get; set; } = null!;
        public virtual DbSet<Terminal> Terminals { get; set; } = null!;
        public virtual DbSet<Thpuan1> Thpuan1s { get; set; } = null!;
        public virtual DbSet<TmpKartsorgu> TmpKartsorgus { get; set; } = null!;
        public virtual DbSet<TmpPerliste> TmpPerlistes { get; set; } = null!;
        public virtual DbSet<Translog> Translogs { get; set; } = null!;
        public virtual DbSet<Ucret1> Ucret1s { get; set; } = null!;
        public virtual DbSet<Varcali> Varcalis { get; set; } = null!;
        public virtual DbSet<Vardiya> Vardiyas { get; set; } = null!;
        public virtual DbSet<VardiyaMecburiZaman> VardiyaMecburiZamen { get; set; } = null!;
        public virtual DbSet<Vargrup> Vargrups { get; set; } = null!;
        public virtual DbSet<Varhaked> Varhakeds { get; set; } = null!;
        public virtual DbSet<VarhakedZaman> VarhakedZamen { get; set; } = null!;
        public virtual DbSet<Vartol> Vartols { get; set; } = null!;
        public virtual DbSet<VartolTerminal> VartolTerminals { get; set; } = null!;
        public virtual DbSet<Vartran> Vartrans { get; set; } = null!;
        public virtual DbSet<Vpdetail> Vpdetails { get; set; } = null!;
        public virtual DbSet<Vwtakvim1> Vwtakvim1s { get; set; } = null!;
        public virtual DbSet<WrDildeger> WrDildegers { get; set; } = null!;
        public virtual DbSet<WrDiller> WrDillers { get; set; } = null!;
        public virtual DbSet<WrDiltext> WrDiltexts { get; set; } = null!;
        public virtual DbSet<WrLogPer> WrLogPers { get; set; } = null!;
        public virtual DbSet<WrLogTbl> WrLogTbls { get; set; } = null!;
        public virtual DbSet<WrSpDeger> WrSpDegers { get; set; } = null!;
        public virtual DbSet<WrUserYetki> WrUserYetkis { get; set; } = null!;
        public virtual DbSet<WrVersion> WrVersions { get; set; } = null!;
        public virtual DbSet<Yabdil1> Yabdil1s { get; set; } = null!;
        public virtual DbSet<YdkGksHareketBo> YdkGksHareketBos { get; set; } = null!;
        public virtual DbSet<YdkPersonel122032021> YdkPersonel122032021s { get; set; } = null!;
        public virtual DbSet<Yetkiaylikonay> Yetkiaylikonays { get; set; } = null!;
        public virtual DbSet<Yetkidepart> Yetkideparts { get; set; } = null!;
        public virtual DbSet<Yetkiform> Yetkiforms { get; set; } = null!;
        public virtual DbSet<Yetkikayit> Yetkikayits { get; set; } = null!;
        public virtual DbSet<Yetkikod> Yetkikods { get; set; } = null!;
        public virtual DbSet<Yetkimenu> Yetkimenus { get; set; } = null!;
        public virtual DbSet<Yetkisirket> Yetkisirkets { get; set; } = null!;
        public virtual DbSet<Yetkitablo> Yetkitablos { get; set; } = null!;
        public virtual DbSet<Yiliz> Yilizs { get; set; } = null!;
        public virtual DbSet<YilizMahsuptar> YilizMahsuptars { get; set; } = null!;
        public virtual DbSet<Yilizhesap1> Yilizhesap1s { get; set; } = null!;
        public virtual DbSet<Yilizhuk> Yilizhuks { get; set; } = null!;
        public virtual DbSet<Yilizkdm> Yilizkdms { get; set; } = null!;
        public virtual DbSet<Yilizkul> Yilizkuls { get; set; } = null!;
        public virtual DbSet<Yilizpar> Yilizpars { get; set; } = null!;
        public virtual DbSet<YilizparIznkod> YilizparIznkods { get; set; } = null!;
        public virtual DbSet<YnCihazGrup> YnCihazGrups { get; set; } = null!;
        public virtual DbSet<YnGrupCihaz> YnGrupCihazs { get; set; } = null!;
        public virtual DbSet<YnIzin> YnIzins { get; set; } = null!;
        public virtual DbSet<YnMola> YnMolas { get; set; } = null!;
        public virtual DbSet<YnParametre> YnParametres { get; set; } = null!;
        public virtual DbSet<YnPer> YnPers { get; set; } = null!;
        public virtual DbSet<YnPerView> YnPerViews { get; set; } = null!;
        public virtual DbSet<YnRapor> YnRapors { get; set; } = null!;
        public virtual DbSet<YnUser> YnUsers { get; set; } = null!;
        public virtual DbSet<YnUserYetki> YnUserYetkis { get; set; } = null!;
        public virtual DbSet<YnVersiyon> YnVersiyons { get; set; } = null!;
        public virtual DbSet<YnView> YnViews { get; set; } = null!;
        public virtual DbSet<YnViewUser> YnViewUsers { get; set; } = null!;
        public virtual DbSet<YnYetki> YnYetkis { get; set; } = null!;
        public virtual DbSet<YnYmk> YnYmks { get; set; } = null!;
        public virtual DbSet<Ytdepbaz> Ytdepbazs { get; set; } = null!;
        public virtual DbSet<Ytgrper> Ytgrpers { get; set; } = null!;
        public virtual DbSet<Ytgrup> Ytgrups { get; set; } = null!;
        public virtual DbSet<Ytgrupbaz> Ytgrupbazs { get; set; } = null!;
        public virtual DbSet<Ytperbaz> Ytperbazs { get; set; } = null!;
        public virtual DbSet<Yukumlu1> Yukumlu1s { get; set; } = null!;
        public virtual DbSet<Yuvardgl> Yuvardgls { get; set; } = null!;
        public virtual DbSet<Yuvarlama> Yuvarlamas { get; set; } = null!;
        public virtual DbSet<Zilzaman> Zilzamen { get; set; } = null!;
        public virtual DbSet<Zmndlm> Zmndlms { get; set; } = null!;
        public virtual DbSet<Zmngrp> Zmngrps { get; set; } = null!;
        public virtual DbSet<ZyEhliyet> ZyEhliyets { get; set; } = null!;
        public virtual DbSet<ZyFoto> ZyFotos { get; set; } = null!;
        public virtual DbSet<ZyGelenevrak> ZyGelenevraks { get; set; } = null!;
        public virtual DbSet<ZyGidenevrak> ZyGidenevraks { get; set; } = null!;
        public virtual DbSet<ZyHareket> ZyHarekets { get; set; } = null!;
        public virtual DbSet<ZyKayit> ZyKayits { get; set; } = null!;
        public virtual DbSet<ZyKimlik> ZyKimliks { get; set; } = null!;
        public virtual DbSet<ZyKulchzgrp> ZyKulchzgrps { get; set; } = null!;
        public virtual DbSet<ZyKullanici> ZyKullanicis { get; set; } = null!;
        public virtual DbSet<ZyKulzmngrp> ZyKulzmngrps { get; set; } = null!;
        public virtual DbSet<ZyLog> ZyLogs { get; set; } = null!;
        public virtual DbSet<ZyMailbilgi> ZyMailbilgis { get; set; } = null!;
        public virtual DbSet<ZyMailliste> ZyMaillistes { get; set; } = null!;
        public virtual DbSet<ZyMailparam> ZyMailparams { get; set; } = null!;
        public virtual DbSet<ZyPiziChz> ZyPiziChzs { get; set; } = null!;
        public virtual DbSet<ZyPizikulchzgrp> ZyPizikulchzgrps { get; set; } = null!;
        public virtual DbSet<ZyPiziyetki> ZyPiziyetkis { get; set; } = null!;
        public virtual DbSet<ZyRuhsat> ZyRuhsats { get; set; } = null!;
        public virtual DbSet<ZyTanim> ZyTanims { get; set; } = null!;
        public virtual DbSet<ZyVersiyon> ZyVersiyons { get; set; } = null!;
        public virtual DbSet<ZyYetki> ZyYetkis { get; set; } = null!;
        public virtual DbSet<ZyZiyaretci> ZyZiyaretcis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.1.79;Database=PersonelCI;User Id=kutluhan;Password=helloWorld2023.;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Turkish_CI_AS");

            modelBuilder.Entity<Aciklama>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Aciklama1, e.Turu });

                entity.ToTable("ACIKLAMA");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Aciklama1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<Adres1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ADRES1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Adres)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("ADRES");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gadres)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("GADRES");

                entity.Property(e => e.Gemail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GEMAIL");

                entity.Property(e => e.Ggsm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("GGSM");

                entity.Property(e => e.Gil)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("GIL");

                entity.Property(e => e.Gilce)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GILCE");

                entity.Property(e => e.Gpskodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GPSKODU")
                    .IsFixedLength();

                entity.Property(e => e.Gsm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("GSM");

                entity.Property(e => e.Gtel1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("GTEL1");

                entity.Property(e => e.Gtel2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("GTEL2");

                entity.Property(e => e.Il)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("IL");

                entity.Property(e => e.Ilce)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ILCE");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Pskodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PSKODU")
                    .IsFixedLength();

                entity.Property(e => e.Tel1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TEL1");

                entity.Property(e => e.Tel2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TEL2");
            });

            modelBuilder.Entity<Aile1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("AILE1");

                entity.HasIndex(e => e.Prsicil, "AILE1_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Dogtar)
                    .HasColumnType("datetime")
                    .HasColumnName("DOGTAR");

                entity.Property(e => e.Dogyer)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DOGYER");

                entity.Property(e => e.Erkek).HasColumnName("ERKEK");

                entity.Property(e => e.Evtar)
                    .HasColumnType("datetime")
                    .HasColumnName("EVTAR");

                entity.Property(e => e.Kiz).HasColumnName("KIZ");

                entity.Property(e => e.Ogrenim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OGRENIM")
                    .IsFixedLength();

                entity.Property(e => e.Osoyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OSOYADI");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");
            });

            modelBuilder.Entity<Alan>(entity =>
            {
                entity.HasKey(e => new { e.Tbadi, e.Adi });

                entity.ToTable("ALAN");

                entity.HasIndex(e => e.Idno, "ALAN_IDX1");

                entity.Property(e => e.Tbadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TBADI");

                entity.Property(e => e.Adi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Izahat)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");

                entity.Property(e => e.Keyalan)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("KEYALAN");

                entity.Property(e => e.Lkeyalan)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LKEYALAN")
                    .IsFixedLength();

                entity.Property(e => e.Llistalan)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LLISTALAN");

                entity.Property(e => e.Ltablo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LTABLO")
                    .IsFixedLength();

                entity.Property(e => e.Sec)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SEC")
                    .IsFixedLength();

                entity.Property(e => e.SpAlan)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SP_ALAN");

                entity.Property(e => e.SpTbadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SP_TBADI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPI")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Altdepart>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Dpkodu, e.Adkodu });

                entity.ToTable("ALTDEPART");

                entity.HasIndex(e => new { e.Srkodu, e.Dpkodu, e.Adkodu }, "IDX_YN_01");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Dpkodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DPKODU");

                entity.Property(e => e.Adkodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADKODU");

                entity.Property(e => e.Adadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADADI");

                entity.Property(e => e.Derece).HasColumnName("DERECE");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Udkodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UDKODU");
            });

            modelBuilder.Entity<Araba1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ARABA1");

                entity.HasIndex(e => new { e.Prsicil, e.Plaka }, "ARABA1_IDX1")
                    .IsUnique();

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Marka)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MARKA");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MODEL");

                entity.Property(e => e.Plaka)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PLAKA")
                    .IsFixedLength();

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Yili).HasColumnName("YILI");
            });

            modelBuilder.Entity<Aypuan1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("AYPUAN1");

                entity.HasIndex(e => new { e.Prsicil, e.Yil, e.Ay, e.Clkodu }, "AYPUAN1_IDX1");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Ay).HasColumnName("AY");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Drcno).HasColumnName("DRCNO");

                entity.Property(e => e.Ondsure)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("ONDSURE");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Sure)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SURE")
                    .IsFixedLength();

                entity.Property(e => e.Topgun)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("TOPGUN");

                entity.Property(e => e.Yil).HasColumnName("YIL");
            });

            modelBuilder.Entity<Banka>(entity =>
            {
                entity.HasKey(e => e.Kodu);

                entity.ToTable("BANKA");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KODU");

                entity.Property(e => e.Banka1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BANKA");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<BankaSube>(entity =>
            {
                entity.HasKey(e => new { e.BankaKodu, e.Kodu });

                entity.ToTable("BANKA_SUBE");

                entity.Property(e => e.BankaKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BANKA_KODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KODU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Sube)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SUBE");
            });

            modelBuilder.Entity<BioVeriyolu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BIO_VERIYOLU");

                entity.Property(e => e.BasAy).HasColumnName("BAS_AY");

                entity.Property(e => e.BasDak).HasColumnName("BAS_DAK");

                entity.Property(e => e.BasGun).HasColumnName("BAS_GUN");

                entity.Property(e => e.BasKapi).HasColumnName("BAS_KAPI");

                entity.Property(e => e.BasKart).HasColumnName("BAS_KART");

                entity.Property(e => e.BasNeden).HasColumnName("BAS_NEDEN");

                entity.Property(e => e.BasSaat).HasColumnName("BAS_SAAT");

                entity.Property(e => e.BasYil).HasColumnName("BAS_YIL");

                entity.Property(e => e.BitAy).HasColumnName("BIT_AY");

                entity.Property(e => e.BitDak).HasColumnName("BIT_DAK");

                entity.Property(e => e.BitGun).HasColumnName("BIT_GUN");

                entity.Property(e => e.BitKapi).HasColumnName("BIT_KAPI");

                entity.Property(e => e.BitKart).HasColumnName("BIT_KART");

                entity.Property(e => e.BitNeden).HasColumnName("BIT_NEDEN");

                entity.Property(e => e.BitSaat).HasColumnName("BIT_SAAT");

                entity.Property(e => e.BitYil).HasColumnName("BIT_YIL");

                entity.Property(e => e.Kaynak)
                    .HasMaxLength(150)
                    .HasColumnName("KAYNAK")
                    .IsFixedLength();

                entity.Property(e => e.Yedek)
                    .HasMaxLength(150)
                    .HasColumnName("YEDEK")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Birim>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.BirimKodu });

                entity.ToTable("BIRIM");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.BirimKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIRIM_KODU");

                entity.Property(e => e.BirimAdi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BIRIM_ADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<BlkSebep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BLK_SEBEP");

                entity.Property(e => e.Adi)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ADI")
                    .IsFixedLength();

                entity.Property(e => e.Kodu).HasColumnName("KODU");
            });

            modelBuilder.Entity<Blokehareket>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("BLOKEHAREKET");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Cihaz).HasColumnName("CIHAZ");

                entity.Property(e => e.Keycode).HasColumnName("KEYCODE");

                entity.Property(e => e.Sebep).HasColumnName("SEBEP");

                entity.Property(e => e.Yon).HasColumnName("YON");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<Bolum>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("BOLUM");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KODU")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<Bordrobaslik>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("BORDROBASLIK");

                entity.HasIndex(e => e.Btkodu, "BORDROBASLIK_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Aladi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ALADI")
                    .IsFixedLength();

                entity.Property(e => e.Bilgi)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BILGI")
                    .HasDefaultValueSql("('DATA')")
                    .IsFixedLength();

                entity.Property(e => e.Btkodu).HasColumnName("BTKODU");

                entity.Property(e => e.Deger)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("DEGER");

                entity.Property(e => e.Satir).HasColumnName("SATIR");

                entity.Property(e => e.Sutun).HasColumnName("SUTUN");

                entity.Property(e => e.Tbadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TBADI")
                    .IsFixedLength();

                entity.Property(e => e.Uzunluk).HasColumnName("UZUNLUK");
            });

            modelBuilder.Entity<Bordrosatir>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("BORDROSATIR");

                entity.HasIndex(e => e.Btkodu, "BORDROSATIR_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Aladi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ALADI")
                    .IsFixedLength();

                entity.Property(e => e.Bilgi)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BILGI")
                    .HasDefaultValueSql("('DATA')")
                    .IsFixedLength();

                entity.Property(e => e.Btkodu).HasColumnName("BTKODU");

                entity.Property(e => e.Deger)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEGER")
                    .IsFixedLength();

                entity.Property(e => e.Onchar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONCHAR")
                    .IsFixedLength();

                entity.Property(e => e.Sutun).HasColumnName("SUTUN");

                entity.Property(e => e.Tbadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TBADI")
                    .IsFixedLength();

                entity.Property(e => e.Uzunluk).HasColumnName("UZUNLUK");
            });

            modelBuilder.Entity<Bordrotanim>(entity =>
            {
                entity.HasKey(e => e.Kodu);

                entity.ToTable("BORDROTANIM");

                entity.Property(e => e.Kodu)
                    .ValueGeneratedNever()
                    .HasColumnName("KODU");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Izahat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");

                entity.Property(e => e.Strbasla)
                    .HasColumnName("STRBASLA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Turu)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .HasDefaultValueSql("('YATAY')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Calisdgl>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("CALISDGL");

                entity.HasIndex(e => e.Clkodu, "CALISDGL_IDX1");

                entity.HasIndex(e => e.Kodu, "CALISDGL_IDX2");

                entity.HasIndex(e => new { e.Clkodu, e.Kodu }, "CALISDGL_IDX3");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Altlmt)
                    .HasColumnType("datetime")
                    .HasColumnName("ALTLMT");

                entity.Property(e => e.Carpan).HasColumnName("CARPAN");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Durum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DURUM")
                    .IsFixedLength();

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Ustlmt)
                    .HasColumnType("datetime")
                    .HasColumnName("USTLMT");
            });

            modelBuilder.Entity<Calisma>(entity =>
            {
                entity.HasKey(e => e.Kodu);

                entity.ToTable("CALISMA");

                entity.HasIndex(e => e.Idno, "CALISMA_IDX1")
                    .IsUnique();

                entity.HasIndex(e => e.Tipi, "CALISMA_IDX2");

                entity.Property(e => e.Kodu)
                    .ValueGeneratedNever()
                    .HasColumnName("KODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Altlim)
                    .HasColumnType("datetime")
                    .HasColumnName("ALTLIM");

                entity.Property(e => e.Calismahesapla).HasColumnName("CALISMAHESAPLA");

                entity.Property(e => e.Carpan).HasColumnName("CARPAN");

                entity.Property(e => e.Cmtgunver)
                    .HasColumnName("CMTGUNVER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cmtsaatver)
                    .HasColumnName("CMTSAATVER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cmtver)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CMTVER")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.DnkDerece).HasColumnName("DNK_DERECE");

                entity.Property(e => e.EntClkodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ENT_CLKODU");

                entity.Property(e => e.Gntgunver)
                    .HasColumnName("GNTGUNVER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gntsaatver)
                    .HasColumnName("GNTSAATVER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gntver)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("GNTVER")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Hftgunver)
                    .HasColumnName("HFTGUNVER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hftsaatver)
                    .HasColumnName("HFTSAATVER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hftver)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HFTVER")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Maxclim)
                    .HasColumnType("datetime")
                    .HasColumnName("MAXCLIM");

                entity.Property(e => e.Mecbur)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MECBUR")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Minclim)
                    .HasColumnType("datetime")
                    .HasColumnName("MINCLIM");

                entity.Property(e => e.NedenDevam).HasColumnName("NEDEN_DEVAM");

                entity.Property(e => e.Onay)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ONAY")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.RaporKodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RAPOR_KODU");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPI")
                    .IsFixedLength();

                entity.Property(e => e.Ustlim)
                    .HasColumnType("datetime")
                    .HasColumnName("USTLIM");

                entity.Property(e => e.Yuvarla).HasColumnName("YUVARLA");
            });

            modelBuilder.Entity<CalismaSaatizinZorunlusaat>(entity =>
            {
                entity.HasKey(e => e.Indo);

                entity.ToTable("CALISMA_SAATIZIN_ZORUNLUSAAT");

                entity.Property(e => e.Indo).HasColumnName("INDO");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");
            });

            modelBuilder.Entity<Calismablg1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("CALISMABLG1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Askdur)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("ASKDUR")
                    .IsFixedLength();

                entity.Property(e => e.Asksebep)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ASKSEBEP");

                entity.Property(e => e.Asktect)
                    .HasColumnType("datetime")
                    .HasColumnName("ASKTECT");

                entity.Property(e => e.Ckstar)
                    .HasColumnType("datetime")
                    .HasColumnName("CKSTAR");

                entity.Property(e => e.Emekli).HasColumnName("EMEKLI");

                entity.Property(e => e.Ogrdur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OGRDUR");

                entity.Property(e => e.Otrtar)
                    .HasColumnType("datetime")
                    .HasColumnName("OTRTAR");

                entity.Property(e => e.Otrulke)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OTRULKE");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Sagprb)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("SAGPRB");

                entity.Property(e => e.Sktdrc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SKTDRC")
                    .IsFixedLength();

                entity.Property(e => e.Sskno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SSKNO");

                entity.Property(e => e.Ssktar)
                    .HasColumnType("datetime")
                    .HasColumnName("SSKTAR");

                entity.Property(e => e.Tasno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TASNO");

                entity.Property(e => e.Verda)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("VERDA");

                entity.Property(e => e.Vrkmno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VRKMNO");
            });

            modelBuilder.Entity<Calisonay>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("CALISONAY");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Degistir)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEGISTIR")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength();

                entity.Property(e => e.Ekle)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EKLE")
                    .HasDefaultValueSql("('H')");

                entity.Property(e => e.Kodu).HasColumnName("KODU");
            });

            modelBuilder.Entity<Calsurelimit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CALSURELIMIT");

                entity.HasIndex(e => e.Clkodu, "IX_CALSURELIMIT");

                entity.Property(e => e.Altlimit)
                    .HasColumnType("datetime")
                    .HasColumnName("ALTLIMIT");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Ustlimit)
                    .HasColumnType("datetime")
                    .HasColumnName("USTLIMIT");

                entity.Property(e => e.Varsure)
                    .HasColumnType("datetime")
                    .HasColumnName("VARSURE");
            });

            modelBuilder.Entity<Cihaz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIHAZ");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Adres).HasColumnName("ADRES");

                entity.Property(e => e.Cihazno).HasColumnName("CIHAZNO");

                entity.Property(e => e.Cihazturu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZTURU");

                entity.Property(e => e.Ipno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPNO");

                entity.Property(e => e.Kullanim)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANIM");

                entity.Property(e => e.Num).HasColumnName("NUM");

                entity.Property(e => e.Portno).HasColumnName("PORTNO");
            });

            modelBuilder.Entity<Cihazgrup>(entity =>
            {
                entity.HasKey(e => e.Num);

                entity.ToTable("CIHAZGRUP");

                entity.Property(e => e.Num).HasColumnName("NUM");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Sirket).HasColumnName("SIRKET");

                entity.Property(e => e.Ziyaretci).HasColumnName("ZIYARETCI");
            });

            modelBuilder.Entity<Cikissebep>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("CIKISSEBEP");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KODU")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Cocuk1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("COCUK1");

                entity.HasIndex(e => new { e.Prsicil, e.Adi, e.Dogtar }, "COCUK1_IDX1")
                    .IsUnique();

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Bolum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BOLUM")
                    .IsFixedLength();

                entity.Property(e => e.Cins)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CINS")
                    .IsFixedLength();

                entity.Property(e => e.Dogtar)
                    .HasColumnType("datetime")
                    .HasColumnName("DOGTAR");

                entity.Property(e => e.Okkodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OKKODU")
                    .IsFixedLength();

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");
            });

            modelBuilder.Entity<DenklestirmeLog>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("DENKLESTIRME_LOG");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Ay).HasColumnName("AY");

                entity.Property(e => e.Fmclkodu).HasColumnName("FMCLKODU");

                entity.Property(e => e.Fmkalansure)
                    .HasColumnType("datetime")
                    .HasColumnName("FMKALANSURE");

                entity.Property(e => e.Fmorjsure)
                    .HasColumnType("datetime")
                    .HasColumnName("FMORJSURE");

                entity.Property(e => e.Fmtarih)
                    .HasColumnType("datetime")
                    .HasColumnName("FMTARIH");

                entity.Property(e => e.IslemZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLEM_ZAMANI")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Iznclkodu).HasColumnName("IZNCLKODU");

                entity.Property(e => e.Iznkalansure)
                    .HasColumnType("datetime")
                    .HasColumnName("IZNKALANSURE");

                entity.Property(e => e.Iznorjsure)
                    .HasColumnType("datetime")
                    .HasColumnName("IZNORJSURE");

                entity.Property(e => e.Izntarih)
                    .HasColumnType("datetime")
                    .HasColumnName("IZNTARIH");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Yil).HasColumnName("YIL");
            });

            modelBuilder.Entity<DenklestirmeParam>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("DENKLESTIRME_PARAM");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Deger)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEGER");

                entity.Property(e => e.DnkSure).HasColumnName("DNK_SURE");

                entity.Property(e => e.DnkSureKontrol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DNK_SURE_KONTROL");

                entity.Property(e => e.Kriter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KRITER");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<DenklestirmeParamDetay>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("DENKLESTIRME_PARAM_DETAY");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Clturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLTURU");

                entity.Property(e => e.DnkSure).HasColumnName("DNK_SURE");

                entity.Property(e => e.DnkSureturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DNK_SURETURU");

                entity.Property(e => e.Islemturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ISLEMTURU");

                entity.Property(e => e.Iznturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZNTURU");

                entity.Property(e => e.Katsayi).HasColumnName("KATSAYI");

                entity.Property(e => e.PrmIdno).HasColumnName("PRM_IDNO");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<DenklestirmePuantaj>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Prsicil, e.Tarih, e.Clkodu });

                entity.ToTable("DENKLESTIRME_PUANTAJ");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");
            });

            modelBuilder.Entity<Departman>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("DEPARTMAN");

                entity.HasIndex(e => new { e.Srkodu, e.Kodu }, "IDX_YN_01");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("KODU")
                    .IsFixedLength();

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Harekleme)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HAREKLEME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.NormKadro).HasColumnName("NORM_KADRO");

                entity.Property(e => e.Sirket)
                    .HasColumnName("SIRKET")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Dernek1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("DERNEK1");

                entity.HasIndex(e => new { e.Prsicil, e.Dernek }, "DERNEK1_IDX1")
                    .IsUnique();

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Dernek)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DERNEK");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");
            });

            modelBuilder.Entity<Devamsiz>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("DEVAMSIZ");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.HtPazar)
                    .HasColumnName("HT_PAZAR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Htkodu).HasColumnName("HTKODU");

                entity.Property(e => e.Islem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISLEM")
                    .IsFixedLength();

                entity.Property(e => e.Pertip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP")
                    .IsFixedLength();

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");
            });

            modelBuilder.Entity<Devamsizke>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("DEVAMSIZKES");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Bagno).HasColumnName("BAGNO");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Islemturu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISLEMTURU");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<Donem>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("DONEM");

                entity.HasIndex(e => new { e.Srkodu, e.Adi }, "DONEM_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Aktif)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("('EVET')")
                    .IsFixedLength();

                entity.Property(e => e.Ilktarih)
                    .HasColumnType("datetime")
                    .HasColumnName("ILKTARIH");

                entity.Property(e => e.Sontarih)
                    .HasColumnType("datetime")
                    .HasColumnName("SONTARIH");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<Durak>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.ServisKodu, e.DurakKodu });

                entity.ToTable("DURAK");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.ServisKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERVIS_KODU");

                entity.Property(e => e.DurakKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DURAK_KODU");

                entity.Property(e => e.DurakAdi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DURAK_ADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<Dusunce1>(entity =>
            {
                entity.HasKey(e => new { e.Idno, e.Prsicil });

                entity.ToTable("DUSUNCE1");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Dusunce)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("DUSUNCE");
            });

            modelBuilder.Entity<Egitim1>(entity =>
            {
                entity.HasKey(e => new { e.Prsicil, e.Okkodu });

                entity.ToTable("EGITIM1");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Okkodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OKKODU")
                    .IsFixedLength();

                entity.Property(e => e.Basyil).HasColumnName("BASYIL");

                entity.Property(e => e.Bityil).HasColumnName("BITYIL");

                entity.Property(e => e.Bolum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOLUM");

                entity.Property(e => e.Derece).HasColumnName("DERECE");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Sehir)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SEHIR");
            });

            modelBuilder.Entity<Ehlpsp1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("EHLPSP1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Ehlcns)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EHLCNS")
                    .IsFixedLength();

                entity.Property(e => e.Ehlno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EHLNO")
                    .IsFixedLength();

                entity.Property(e => e.Ehltar)
                    .HasColumnType("datetime")
                    .HasColumnName("EHLTAR");

                entity.Property(e => e.Ehlyer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EHLYER");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Pspbtt)
                    .HasColumnType("datetime")
                    .HasColumnName("PSPBTT");

                entity.Property(e => e.Pspcns)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PSPCNS")
                    .IsFixedLength();

                entity.Property(e => e.Pspno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PSPNO")
                    .IsFixedLength();

                entity.Property(e => e.Pspvrt)
                    .HasColumnType("datetime")
                    .HasColumnName("PSPVRT");

                entity.Property(e => e.Pspyer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSPYER");
            });

            modelBuilder.Entity<Elbise1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ELBISE1");

                entity.HasIndex(e => new { e.Prsicil, e.Elturu, e.Tarih }, "ELBISE1_IDX1")
                    .IsUnique();

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Beden)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BEDEN")
                    .IsFixedLength();

                entity.Property(e => e.Elturu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELTURU");

                entity.Property(e => e.Miktar).HasColumnName("MIKTAR");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Verndn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VERNDN");
            });

            modelBuilder.Entity<Elbisebeden>(entity =>
            {
                entity.HasKey(e => new { e.Idno, e.Srkodu });

                entity.ToTable("ELBISEBEDEN");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Beden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BEDEN")
                    .IsFixedLength();

                entity.Property(e => e.Izahat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");
            });

            modelBuilder.Entity<Elbiseblg1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ELBISEBLG1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Beden)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BEDEN")
                    .IsFixedLength();

                entity.Property(e => e.Elturu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELTURU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");
            });

            modelBuilder.Entity<Elbiseturu>(entity =>
            {
                entity.HasKey(e => new { e.Idno, e.Srkodu });

                entity.ToTable("ELBISETURU");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Izahat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");

                entity.Property(e => e.Turu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<Esnekgrup>(entity =>
            {
                entity.HasKey(e => new { e.Kodu, e.Srkodu });

                entity.ToTable("ESNEKGRUP");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");
            });

            modelBuilder.Entity<Esnekvardiya>(entity =>
            {
                entity.HasKey(e => new { e.Kodu, e.Grup });

                entity.ToTable("ESNEKVARDIYA");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Grup).HasColumnName("GRUP");
            });

            modelBuilder.Entity<Filtre>(entity =>
            {
                entity.HasKey(e => new { e.Adi, e.Form });

                entity.ToTable("FILTRE");

                entity.Property(e => e.Adi)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Form)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FORM")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Izahat)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");

                entity.Property(e => e.Ordersql)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSQL");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPI")
                    .HasDefaultValueSql("('USER')")
                    .IsFixedLength();

                entity.Property(e => e.Wheresql)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("WHERESQL");
            });

            modelBuilder.Entity<Filtred>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("FILTRED");

                entity.HasIndex(e => new { e.Fidno, e.Tadi, e.Alan }, "FILTRED_IDX1");

                entity.HasIndex(e => e.Idno, "FILTRED_IDX2");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Alan)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ALAN")
                    .IsFixedLength();

                entity.Property(e => e.Baglama)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BAGLAMA")
                    .IsFixedLength();

                entity.Property(e => e.Deger1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER1");

                entity.Property(e => e.Deger2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER2");

                entity.Property(e => e.Fidno).HasColumnName("FIDNO");

                entity.Property(e => e.Kriter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KRITER");

                entity.Property(e => e.Siralama).HasColumnName("SIRALAMA");

                entity.Property(e => e.Tadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TADI")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Fmdenk>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Pertipi });

                entity.ToTable("FMDENK");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Pertipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIPI")
                    .IsFixedLength();

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Aysure).HasColumnName("AYSURE");

                entity.Property(e => e.Dahil)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DAHIL")
                    .HasDefaultValueSql("('Evet')");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<Fmdenkalt>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Pertipi, e.Clkodu });

                entity.ToTable("FMDENKALT");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Pertipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIPI");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Aktar).HasColumnName("AKTAR");

                entity.Property(e => e.Carpan)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("CARPAN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TIPI");
            });

            modelBuilder.Entity<Fmkontrol>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("FMKONTROL");

                entity.HasIndex(e => new { e.Srkodu, e.Pertipi }, "FMKONTROL_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Bakclkodu).HasColumnName("BAKCLKODU");

                entity.Property(e => e.Ekclkodu).HasColumnName("EKCLKODU");

                entity.Property(e => e.Fmkd1).HasColumnName("FMKD1");

                entity.Property(e => e.Fmkd2).HasColumnName("FMKD2");

                entity.Property(e => e.Fmkd3).HasColumnName("FMKD3");

                entity.Property(e => e.Kontrol)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KONTROL")
                    .IsFixedLength();

                entity.Property(e => e.Limit).HasColumnName("LIMIT");

                entity.Property(e => e.Pertipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIPI")
                    .IsFixedLength();

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<Fmned>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("FMNED");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KODU")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Form>(entity =>
            {
                entity.HasKey(e => e.Adi);

                entity.ToTable("FORM");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Izahat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");
            });

            modelBuilder.Entity<Formtablo>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("FORMTABLO");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Alias1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ALIAS1")
                    .IsFixedLength();

                entity.Property(e => e.Alias2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ALIAS2")
                    .IsFixedLength();

                entity.Property(e => e.Durum)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DURUM")
                    .IsFixedLength();

                entity.Property(e => e.Fadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FADI")
                    .IsFixedLength();

                entity.Property(e => e.Ltadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LTADI")
                    .IsFixedLength();

                entity.Property(e => e.Tadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TADI")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Foto1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("FOTO1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Foto)
                    .HasColumnType("image")
                    .HasColumnName("FOTO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");
            });

            modelBuilder.Entity<Gayrimen1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GAYRIMEN1");

                entity.HasIndex(e => new { e.Prsicil, e.Turu, e.Kullanim, e.Alani, e.Aciklama }, "GAYRIMEN1_IDX1")
                    .IsUnique();

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Alani)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ALANI")
                    .IsFixedLength();

                entity.Property(e => e.Kullanim)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("KULLANIM");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Turu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Gecicikart>(entity =>
            {
                entity.HasKey(e => e.Keycode);

                entity.ToTable("GECICIKART");

                entity.Property(e => e.Keycode)
                    .ValueGeneratedNever()
                    .HasColumnName("KEYCODE");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Durum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DURUM")
                    .HasDefaultValueSql("('EVET')");

                entity.Property(e => e.No)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NO");

                entity.Property(e => e.Sirket)
                    .HasColumnName("SIRKET")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GksBlokeharMailadre>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_BLOKEHAR_MAILADRES");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");
            });

            modelBuilder.Entity<GksBlokehareket>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_BLOKEHAREKET");

                entity.HasIndex(e => new { e.Keycode, e.ZamanTrh, e.Cihaz }, "GKS_BLOKEHAREKET_IDX1");

                entity.HasIndex(e => new { e.PiIdno, e.ZamanTrh, e.Cihaz }, "GKS_BLOKEHAREKET_IDX2");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Cihaz).HasColumnName("CIHAZ");

                entity.Property(e => e.Gecisturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GECISTURU");

                entity.Property(e => e.Keycode).HasColumnName("KEYCODE");

                entity.Property(e => e.PiIdno).HasColumnName("PI_IDNO");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.ToplaTar)
                    .HasColumnType("datetime")
                    .HasColumnName("TOPLA_TAR");

                entity.Property(e => e.Yon).HasColumnName("YON");

                entity.Property(e => e.ZamanTrh)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN_TRH");
            });

            modelBuilder.Entity<GksBlokemail>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_BLOKEMAIL");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Cihaz).HasColumnName("CIHAZ");

                entity.Property(e => e.IslemZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLEM_ZAMANI");

                entity.Property(e => e.Keycode).HasColumnName("KEYCODE");

                entity.Property(e => e.Mail)
                    .HasColumnName("MAIL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<GksCihaz>(entity =>
            {
                entity.HasKey(e => e.CihazNo);

                entity.ToTable("GKS_CIHAZ");

                entity.HasIndex(e => new { e.Srkodu, e.CihazNo }, "IDX_YN_01");

                entity.Property(e => e.CihazNo)
                    .ValueGeneratedNever()
                    .HasColumnName("CIHAZ_NO");

                entity.Property(e => e.Adres).HasColumnName("ADRES");

                entity.Property(e => e.AlarmCihazno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALARM_CIHAZNO")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.AlarmKontrol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ALARM_KONTROL");

                entity.Property(e => e.Antipassback)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ANTIPASSBACK")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.ArdisikKartKnt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ARDISIK_KART_KNT");

                entity.Property(e => e.ArdisikSure)
                    .HasColumnName("ARDISIK_SURE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AsansorKarti)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ASANSOR_KARTI");

                entity.Property(e => e.BolgeAdresi).HasColumnName("BOLGE_ADRESI");

                entity.Property(e => e.BolgeKodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BOLGE_KODU");

                entity.Property(e => e.CalismaModu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CALISMA_MODU");

                entity.Property(e => e.CihazAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZ_ADI");

                entity.Property(e => e.CihazDili)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZ_DILI");

                entity.Property(e => e.CihazTuru)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZ_TURU");

                entity.Property(e => e.ClientIpAdresi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_IP_ADRESI");

                entity.Property(e => e.ClientTcpPort).HasColumnName("CLIENT_TCP_PORT");

                entity.Property(e => e.ClientUdpPort).HasColumnName("CLIENT_UDP_PORT");

                entity.Property(e => e.CokluPersonel)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COKLU_PERSONEL");

                entity.Property(e => e.Converter)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CONVERTER");

                entity.Property(e => e.EkranArkaIsikSuresi).HasColumnName("EKRAN_ARKA_ISIK_SURESI");

                entity.Property(e => e.EkranParlakligi).HasColumnName("EKRAN_PARLAKLIGI");

                entity.Property(e => e.HaberlesmeHizi).HasColumnName("HABERLESME_HIZI");

                entity.Property(e => e.HareketIndex).HasColumnName("HAREKET_INDEX");

                entity.Property(e => e.HareketZaman)
                    .HasColumnType("datetime")
                    .HasColumnName("HAREKET_ZAMAN");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.IpAdresi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADRESI");

                entity.Property(e => e.KapiAdresi).HasColumnName("KAPI_ADRESI");

                entity.Property(e => e.KartKeyKontrol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("KART_KEY_KONTROL");

                entity.Property(e => e.KartSifreKontrol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("KART_SIFRE_KONTROL");

                entity.Property(e => e.KartTekrariKnt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KART_TEKRARI_KNT");

                entity.Property(e => e.KartYetki)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KART_YETKI");

                entity.Property(e => e.KartyetkiGrupkodu).HasColumnName("KARTYETKI_GRUPKODU");

                entity.Property(e => e.MacAdresi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MAC_ADRESI");

                entity.Property(e => e.NedenKontrol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN_KONTROL");

                entity.Property(e => e.OkuyucuTipi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OKUYUCU_TIPI");

                entity.Property(e => e.OlumsuzMesajSure).HasColumnName("OLUMSUZ_MESAJ_SURE");

                entity.Property(e => e.OnlineTimeout).HasColumnName("ONLINE_TIMEOUT");

                entity.Property(e => e.OptikGiris)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OPTIK_GIRIS");

                entity.Property(e => e.OptikGirisAcil)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OPTIK_GIRIS_ACIL");

                entity.Property(e => e.OptikGirisKapi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OPTIK_GIRIS_KAPI");

                entity.Property(e => e.OptikGirisTurnike)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OPTIK_GIRIS_TURNIKE");

                entity.Property(e => e.OptikGirisYangin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OPTIK_GIRIS_YANGIN");

                entity.Property(e => e.ParametreSet)
                    .HasColumnName("PARAMETRE_SET")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParmakHassasiyeti).HasColumnName("PARMAK_HASSASIYETI");

                entity.Property(e => e.PerislemIdD)
                    .HasColumnName("PERISLEM_ID_D")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PerislemIdI)
                    .HasColumnName("PERISLEM_ID_I")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PingSuresi).HasColumnName("PING_SURESI");

                entity.Property(e => e.Port).HasColumnName("PORT");

                entity.Property(e => e.RandomEnd)
                    .HasColumnName("RANDOM_END")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RandomStart)
                    .HasColumnName("RANDOM_START")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RoleModu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_MODU")
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.RoleSuresi).HasColumnName("ROLE_SURESI");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIFRE");

                entity.Property(e => e.SistemSesSeviyesi).HasColumnName("SISTEM_SES_SEVIYESI");

                entity.Property(e => e.SistemSesi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SISTEM_SESI");

                entity.Property(e => e.SmartRoleModu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SMART_ROLE_MODU");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.TekrarSure)
                    .HasColumnName("TEKRAR_SURE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tema)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TEMA");

                entity.Property(e => e.TtfsmAdresi).HasColumnName("TTFSM_ADRESI");

                entity.Property(e => e.TtlTimeout).HasColumnName("TTL_TIMEOUT");

                entity.Property(e => e.TusSesi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TUS_SESI");

                entity.Property(e => e.TusTakimiArkaIsikSuresi).HasColumnName("TUS_TAKIMI_ARKA_ISIK_SURESI");

                entity.Property(e => e.TusTakimiKontrol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TUS_TAKIMI_KONTROL");

                entity.Property(e => e.UdpPort).HasColumnName("UDP_PORT");

                entity.Property(e => e.Yetkilendirme)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YETKILENDIRME");

                entity.Property(e => e.YetkilendirmeGrubu)
                    .HasColumnName("YETKILENDIRME_GRUBU")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Yon)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("YON");
            });

            modelBuilder.Entity<GksCihazBolge>(entity =>
            {
                entity.HasKey(e => e.BolgeKodu);

                entity.ToTable("GKS_CIHAZ_BOLGE");

                entity.Property(e => e.BolgeKodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BOLGE_KODU");

                entity.Property(e => e.BolgeAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOLGE_ADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<GksCihazPrinter>(entity =>
            {
                entity.HasKey(e => e.CihazNo);

                entity.ToTable("GKS_CIHAZ_PRINTER");

                entity.Property(e => e.CihazNo)
                    .ValueGeneratedNever()
                    .HasColumnName("CIHAZ_NO");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Printer)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRINTER");

                entity.Property(e => e.PrinterIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRINTER_IP");

                entity.Property(e => e.PrinterPort).HasColumnName("PRINTER_PORT");
            });

            modelBuilder.Entity<GksCihazReader>(entity =>
            {
                entity.HasKey(e => e.CihazNo);

                entity.ToTable("GKS_CIHAZ_READER");

                entity.Property(e => e.CihazNo)
                    .ValueGeneratedNever()
                    .HasColumnName("CIHAZ_NO");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Rdr0).HasColumnName("RDR0");

                entity.Property(e => e.Rdr0No).HasColumnName("RDR0_NO");

                entity.Property(e => e.Rdr1).HasColumnName("RDR1");

                entity.Property(e => e.Rdr1No).HasColumnName("RDR1_NO");

                entity.Property(e => e.Rdr2).HasColumnName("RDR2");

                entity.Property(e => e.Rdr2No).HasColumnName("RDR2_NO");

                entity.Property(e => e.Rdr3).HasColumnName("RDR3");

                entity.Property(e => e.Rdr3No).HasColumnName("RDR3_NO");

                entity.Property(e => e.Rdr4).HasColumnName("RDR4");

                entity.Property(e => e.Rdr4No).HasColumnName("RDR4_NO");

                entity.Property(e => e.Rdr5).HasColumnName("RDR5");

                entity.Property(e => e.Rdr5No).HasColumnName("RDR5_NO");

                entity.Property(e => e.Rdr6).HasColumnName("RDR6");

                entity.Property(e => e.Rdr6No).HasColumnName("RDR6_NO");

                entity.Property(e => e.Rdr7).HasColumnName("RDR7");

                entity.Property(e => e.Rdr7No).HasColumnName("RDR7_NO");

                entity.Property(e => e.Rdr8).HasColumnName("RDR8");

                entity.Property(e => e.Rdr8No).HasColumnName("RDR8_NO");

                entity.Property(e => e.Rdr9).HasColumnName("RDR9");

                entity.Property(e => e.Rdr9No).HasColumnName("RDR9_NO");
            });

            modelBuilder.Entity<GksCihazReaderId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GKS_CIHAZ_READER_IDS");

                entity.Property(e => e.Adres1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADRES1");

                entity.Property(e => e.Adres2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADRES2");

                entity.Property(e => e.Antipassback1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ANTIPASSBACK1");

                entity.Property(e => e.Antipassback2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ANTIPASSBACK2");

                entity.Property(e => e.ArdisikKartKnt1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ARDISIK_KART_KNT1");

                entity.Property(e => e.ArdisikKartKnt2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ARDISIK_KART_KNT2");

                entity.Property(e => e.Auxedge1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUXEDGE1");

                entity.Property(e => e.Auxedge2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUXEDGE2");

                entity.Property(e => e.CalismaModu1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CALISMA_MODU1");

                entity.Property(e => e.CalismaModu2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CALISMA_MODU2");

                entity.Property(e => e.CihazAdi1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZ_ADI1");

                entity.Property(e => e.CihazAdi2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZ_ADI2");

                entity.Property(e => e.CihazNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZ_NO");

                entity.Property(e => e.CihazTuru1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZ_TURU1");

                entity.Property(e => e.CihazTuru2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZ_TURU2");

                entity.Property(e => e.Emgedge1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMGEDGE1");

                entity.Property(e => e.Emgedge2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMGEDGE2");

                entity.Property(e => e.Energysaver1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENERGYSAVER1");

                entity.Property(e => e.Energysaver2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENERGYSAVER2");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.KartTekrariKnt1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KART_TEKRARI_KNT1");

                entity.Property(e => e.KartTekrariKnt2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KART_TEKRARI_KNT2");

                entity.Property(e => e.OnlineTimeout1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONLINE_TIMEOUT1");

                entity.Property(e => e.OnlineTimeout2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONLINE_TIMEOUT2");

                entity.Property(e => e.OpticalInput1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPTICAL_INPUT1");

                entity.Property(e => e.OpticalInput2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPTICAL_INPUT2");

                entity.Property(e => e.ReaderCihazno1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("READER_CIHAZNO1");

                entity.Property(e => e.ReaderCihazno2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("READER_CIHAZNO2");

                entity.Property(e => e.Rexedge1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REXEDGE1");

                entity.Property(e => e.Rexedge2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REXEDGE2");

                entity.Property(e => e.RoleModu1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_MODU1");

                entity.Property(e => e.RoleModu2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_MODU2");

                entity.Property(e => e.RoleSuresi1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_SURESI1");

                entity.Property(e => e.RoleSuresi2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_SURESI2");

                entity.Property(e => e.Statedge1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATEDGE1");

                entity.Property(e => e.Statedge2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATEDGE2");

                entity.Property(e => e.TagInterval1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TAG_INTERVAL1");

                entity.Property(e => e.TagInterval2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TAG_INTERVAL2");

                entity.Property(e => e.TekrarSure1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TEKRAR_SURE1");

                entity.Property(e => e.TekrarSure2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TEKRAR_SURE2");

                entity.Property(e => e.Yetkilendirme1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YETKILENDIRME1");

                entity.Property(e => e.Yetkilendirme2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YETKILENDIRME2");

                entity.Property(e => e.Yon1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YON1");

                entity.Property(e => e.Yon2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YON2");
            });

            modelBuilder.Entity<GksCihazReaderLocker>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GKS_CIHAZ_READER_LOCKER");

                entity.Property(e => e.CihazNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZ_NO");

                entity.Property(e => e.DolapNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOLAP_NO");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PortNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PORT_NO");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<GksCihazReaderLockerPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GKS_CIHAZ_READER_LOCKER_PERSONEL");

                entity.Property(e => e.DolapNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOLAP_NO");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<GksCihazYetkilendirmeGrup>(entity =>
            {
                entity.HasKey(e => e.GrupKodu);

                entity.ToTable("GKS_CIHAZ_YETKILENDIRME_GRUP");

                entity.Property(e => e.GrupKodu)
                    .ValueGeneratedNever()
                    .HasColumnName("GRUP_KODU");

                entity.Property(e => e.GrupAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_ADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<GksCihazYetkilendirmeZaman>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GKS_CIHAZ_YETKILENDIRME_ZAMAN");

                entity.Property(e => e.Baszaman)
                    .HasColumnType("datetime")
                    .HasColumnName("BASZAMAN");

                entity.Property(e => e.GrupKodu).HasColumnName("GRUP_KODU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Yetkilendirme)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YETKILENDIRME");
            });

            modelBuilder.Entity<GksCihazgrup>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.GrupKodu });

                entity.ToTable("GKS_CIHAZGRUP");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.GrupKodu).HasColumnName("GRUP_KODU");

                entity.Property(e => e.GcKontrol)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("GC_KONTROL");

                entity.Property(e => e.GrupAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_ADI");

                entity.Property(e => e.GrupTuru)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_TURU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<GksCihazislemLog>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_CIHAZISLEM_LOG");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.CihazNo).HasColumnName("CIHAZ_NO");

                entity.Property(e => e.IpAdresi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADRESI");

                entity.Property(e => e.Islem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ISLEM");

                entity.Property(e => e.IslemZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLEM_ZAMANI");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Sonuc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SONUC");
            });

            modelBuilder.Entity<GksFace>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_FACE");

                entity.HasIndex(e => e.PiIdno, "GKS_FACE_IDX1");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Face)
                    .HasColumnType("text")
                    .HasColumnName("FACE");

                entity.Property(e => e.PiIdno).HasColumnName("PI_IDNO");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<GksGeciciHareket>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_GECICI_HAREKET");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Cihaz).HasColumnName("CIHAZ");

                entity.Property(e => e.Gecisturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GECISTURU");

                entity.Property(e => e.Keycode).HasColumnName("KEYCODE");

                entity.Property(e => e.Nedenkodu).HasColumnName("NEDENKODU");

                entity.Property(e => e.PiIdno).HasColumnName("PI_IDNO");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.ToplaTar)
                    .HasColumnType("datetime")
                    .HasColumnName("TOPLA_TAR");

                entity.Property(e => e.Turu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TURU");

                entity.Property(e => e.Yon).HasColumnName("YON");

                entity.Property(e => e.ZamanTrh)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN_TRH");
            });

            modelBuilder.Entity<GksGeciciKart>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kartno });

                entity.ToTable("GKS_GECICI_KART");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.KartId).HasColumnName("KART_ID");
            });

            modelBuilder.Entity<GksGrupcihaz>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.GrupKodu, e.CihazNo });

                entity.ToTable("GKS_GRUPCIHAZ");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.GrupKodu).HasColumnName("GRUP_KODU");

                entity.Property(e => e.CihazNo).HasColumnName("CIHAZ_NO");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<GksHaberlesmeParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GKS_HABERLESME_PARAM");

                entity.Property(e => e.ClientPortBiopass).HasColumnName("CLIENT_PORT_BIOPASS");

                entity.Property(e => e.ClientPortCezeri).HasColumnName("CLIENT_PORT_CEZERI");

                entity.Property(e => e.ClientPortDiger).HasColumnName("CLIENT_PORT_DIGER");

                entity.Property(e => e.ClientPortIdstar).HasColumnName("CLIENT_PORT_IDSTAR");

                entity.Property(e => e.MaxThread).HasColumnName("MAX_THREAD");

                entity.Property(e => e.OnlineBekleme).HasColumnName("ONLINE_BEKLEME");

                entity.Property(e => e.OnlineTekrarsay).HasColumnName("ONLINE_TEKRARSAY");

                entity.Property(e => e.OnlineTimeout).HasColumnName("ONLINE_TIMEOUT");

                entity.Property(e => e.PiBekleme).HasColumnName("PI_BEKLEME");

                entity.Property(e => e.PiMaxthread).HasColumnName("PI_MAXTHREAD");

                entity.Property(e => e.PiPort).HasColumnName("PI_PORT");

                entity.Property(e => e.PiServer)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PI_SERVER");

                entity.Property(e => e.Timeout).HasColumnName("TIMEOUT");

                entity.Property(e => e.TtlTimeout).HasColumnName("TTL_TIMEOUT");
            });

            modelBuilder.Entity<GksHareket>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_HAREKET");

                entity.HasIndex(e => new { e.Keycode, e.ZamanTrh, e.Cihaz }, "GKS_HAREKET_IDX1");

                entity.HasIndex(e => new { e.PiIdno, e.ZamanTrh, e.Cihaz }, "GKS_HAREKET_IDX2");

                entity.HasIndex(e => new { e.Yon, e.ZamanTrh }, "IDX_YN_01");

                entity.HasIndex(e => new { e.Yon, e.Srkodu, e.ZamanTrh }, "IDX_YN_02");

                entity.HasIndex(e => new { e.Srkodu, e.ZamanTrh }, "IDX_YN_03");

                entity.HasIndex(e => new { e.Cihaz, e.Srkodu, e.ZamanTrh }, "IDX_YN_04");

                entity.HasIndex(e => e.Srkodu, "IDX_YN_05");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Cihaz).HasColumnName("CIHAZ");

                entity.Property(e => e.Gecisturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GECISTURU");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Keycode).HasColumnName("KEYCODE");

                entity.Property(e => e.Nedenkodu).HasColumnName("NEDENKODU");

                entity.Property(e => e.PiIdno).HasColumnName("PI_IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.ToplaTar)
                    .HasColumnType("datetime")
                    .HasColumnName("TOPLA_TAR");

                entity.Property(e => e.Yon).HasColumnName("YON");

                entity.Property(e => e.ZamanTrh)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN_TRH");
            });

            modelBuilder.Entity<GksHareketResim>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_HAREKET_RESIM");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.CihazNo).HasColumnName("CIHAZ_NO");

                entity.Property(e => e.Resim)
                    .HasColumnType("image")
                    .HasColumnName("RESIM");

                entity.Property(e => e.ZamanTrh)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN_TRH");
            });

            modelBuilder.Entity<GksHareketZyr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GKS_HAREKET_ZYR");

                entity.Property(e => e.Cihaz).HasColumnName("CIHAZ");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Nedenkodu).HasColumnName("NEDENKODU");

                entity.Property(e => e.PiIdno).HasColumnName("PI_IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Yon).HasColumnName("YON");

                entity.Property(e => e.ZamanTrh)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN_TRH");
            });

            modelBuilder.Entity<GksKapiDurum>(entity =>
            {
                entity.HasKey(e => new { e.IpAdresi, e.CihazNo });

                entity.ToTable("GKS_KAPI_DURUM");

                entity.Property(e => e.IpAdresi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADRESI");

                entity.Property(e => e.CihazNo).HasColumnName("CIHAZ_NO");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Reader1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("READER1");

                entity.Property(e => e.Reader1Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("READER1_ZAMAN");

                entity.Property(e => e.Reader2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("READER2");

                entity.Property(e => e.Reader2Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("READER2_ZAMAN");
            });

            modelBuilder.Entity<GksKapiLog>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_KAPI_LOG");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Adres).HasColumnName("ADRES");

                entity.Property(e => e.CihazNo).HasColumnName("CIHAZ_NO");

                entity.Property(e => e.Durum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DURUM");

                entity.Property(e => e.DurumKodu).HasColumnName("DURUM_KODU");

                entity.Property(e => e.IpAdresi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADRESI");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<GksKartlar>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_KARTLAR");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Keycode).HasColumnName("KEYCODE");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPI")
                    .HasDefaultValueSql("('PER')");
            });

            modelBuilder.Entity<GksKartlarLog>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_KARTLAR_LOG");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.IslemTuru)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ISLEM_TURU");

                entity.Property(e => e.IslemZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLEM_ZAMANI");

                entity.Property(e => e.Keycode).HasColumnName("KEYCODE");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<GksKisitlama>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_KISITLAMA");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Bittarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTARIH");

                entity.Property(e => e.Cihazgrup).HasColumnName("CIHAZGRUP");

                entity.Property(e => e.Sayi)
                    .HasColumnName("SAYI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Turu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<GksKisitlamaParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GKS_KISITLAMA_PARAM");

                entity.Property(e => e.Baslama)
                    .HasColumnType("datetime")
                    .HasColumnName("BASLAMA");

                entity.Property(e => e.Bitis)
                    .HasColumnType("datetime")
                    .HasColumnName("BITIS");

                entity.Property(e => e.Departman)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMAN");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Kredi).HasColumnName("KREDI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<GksKrediLog>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_KREDI_LOG");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Bittarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTARIH");

                entity.Property(e => e.IslemZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLEM_ZAMANI");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.ToplamKredi).HasColumnName("TOPLAM_KREDI");

                entity.Property(e => e.YuklenenKredi).HasColumnName("YUKLENEN_KREDI");
            });

            modelBuilder.Entity<GksKrediParam>(entity =>
            {
                entity.HasKey(e => new { e.KontrolAlan, e.KontrolDeger });

                entity.ToTable("GKS_KREDI_PARAM");

                entity.Property(e => e.KontrolAlan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KONTROL_ALAN");

                entity.Property(e => e.KontrolDeger)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KONTROL_DEGER");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.KontrolGunu).HasColumnName("KONTROL_GUNU");

                entity.Property(e => e.KontrolTuru)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KONTROL_TURU");

                entity.Property(e => e.Kredi).HasColumnName("KREDI");
            });

            modelBuilder.Entity<GksKullanici>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_KULLANICI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Admin)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ADMIN");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SIFRE");
            });

            modelBuilder.Entity<GksKullanicicihaz>(entity =>
            {
                entity.HasKey(e => new { e.Kullanici, e.CihazNo });

                entity.ToTable("GKS_KULLANICICIHAZ");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.CihazNo).HasColumnName("CIHAZ_NO");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<GksKullaniciyetki>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_KULLANICIYETKI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Degistir)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DEGISTIR");

                entity.Property(e => e.Dpkodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DPKODU");

                entity.Property(e => e.Ekle)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EKLE");

                entity.Property(e => e.Goster)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GOSTER");

                entity.Property(e => e.Islem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ISLEM");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Menu)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MENU");

                entity.Property(e => e.Sil)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Yetkituru)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YETKITURU");
            });

            modelBuilder.Entity<GksMenu>(entity =>
            {
                entity.HasKey(e => e.Menu);

                entity.ToTable("GKS_MENU");

                entity.Property(e => e.Menu)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MENU");

                entity.Property(e => e.Button)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BUTTON");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.MenuAciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MENU_ACIKLAMA");
            });

            modelBuilder.Entity<GksMesaj>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.MesajNo });

                entity.ToTable("GKS_MESAJ");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.MesajNo).HasColumnName("MESAJ_NO");

                entity.Property(e => e.Baslama)
                    .HasColumnType("datetime")
                    .HasColumnName("BASLAMA");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.MesajTuru)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MESAJ_TURU");

                entity.Property(e => e.Okundu).HasColumnName("OKUNDU");

                entity.Property(e => e.Satir1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SATIR1");

                entity.Property(e => e.Satir2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SATIR2");

                entity.Property(e => e.Satir3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SATIR3");

                entity.Property(e => e.Satir4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SATIR4");

                entity.Property(e => e.Satir5)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SATIR5");

                entity.Property(e => e.Sure).HasColumnName("SURE");

                entity.Property(e => e.SureTuru)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SURE_TURU");
            });

            modelBuilder.Entity<GksNeden>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.NedenKodu });

                entity.ToTable("GKS_NEDEN");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.NedenKodu).HasColumnName("NEDEN_KODU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<GksNedenKarti>(entity =>
            {
                entity.HasKey(e => e.KartId);

                entity.ToTable("GKS_NEDEN_KARTI");

                entity.Property(e => e.KartId)
                    .ValueGeneratedNever()
                    .HasColumnName("KART_ID");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.NedenKodu).HasColumnName("NEDEN_KODU");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<GksOnlineHarindex>(entity =>
            {
                entity.HasKey(e => e.CihazNo);

                entity.ToTable("GKS_ONLINE_HARINDEX");

                entity.Property(e => e.CihazNo)
                    .ValueGeneratedNever()
                    .HasColumnName("CIHAZ_NO");

                entity.Property(e => e.HareketIndex)
                    .HasColumnName("HAREKET_INDEX")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<GksParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GKS_PARAM");

                entity.Property(e => e.ArdisikLimit)
                    .HasColumnType("datetime")
                    .HasColumnName("ARDISIK_LIMIT");

                entity.Property(e => e.BilgitoplamaKontrolsure).HasColumnName("BILGITOPLAMA_KONTROLSURE");

                entity.Property(e => e.BilgitoplamaZamankontrol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BILGITOPLAMA_ZAMANKONTROL");

                entity.Property(e => e.CihazResimgoster)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZ_RESIMGOSTER");

                entity.Property(e => e.Cikisonayi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIKISONAYI");

                entity.Property(e => e.CikistaCalistir)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CIKISTA_CALISTIR");

                entity.Property(e => e.GecisEngelleme)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GECIS_ENGELLEME");

                entity.Property(e => e.GecisKisitlama)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GECIS_KISITLAMA");

                entity.Property(e => e.GecisYetkituru)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GECIS_YETKITURU");

                entity.Property(e => e.GuncellemePeriyod)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_PERIYOD");

                entity.Property(e => e.HareketSakla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("HAREKET_SAKLA");

                entity.Property(e => e.HareketSirala)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("HAREKET_SIRALA");

                entity.Property(e => e.KartIdTersle)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KART_ID_TERSLE");

                entity.Property(e => e.KartSil)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KART_SIL");

                entity.Property(e => e.KartnoUzn)
                    .HasColumnName("KARTNO_UZN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KullaniciCihazyetki)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI_CIHAZYETKI");

                entity.Property(e => e.MailEnablessl)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_ENABLESSL");

                entity.Property(e => e.MailGonderen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_GONDEREN");

                entity.Property(e => e.MailKullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_KULLANICI");

                entity.Property(e => e.MailPort).HasColumnName("MAIL_PORT");

                entity.Property(e => e.MailServer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_SERVER");

                entity.Property(e => e.MailSifre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_SIFRE");

                entity.Property(e => e.MasterIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MASTER_IP");

                entity.Property(e => e.MasterKnt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASTER_KNT")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.MaxThread).HasColumnName("MAX_THREAD");

                entity.Property(e => e.PersonelIslem)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERSONEL_ISLEM");

                entity.Property(e => e.PersonelListeModu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PERSONEL_LISTE_MODU");

                entity.Property(e => e.PiVersion).HasColumnName("PI_VERSION");

                entity.Property(e => e.ResimAl)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RESIM_AL");

                entity.Property(e => e.SaatFormat)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SAAT_FORMAT");

                entity.Property(e => e.SaklamaSure).HasColumnName("SAKLAMA_SURE");

                entity.Property(e => e.SaklamaSureBirimi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SAKLAMA_SURE_BIRIMI");

                entity.Property(e => e.Score).HasColumnName("SCORE");

                entity.Property(e => e.SecimModu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SECIM_MODU");

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SERVER_IP");

                entity.Property(e => e.ServerPort).HasColumnName("SERVER_PORT");

                entity.Property(e => e.SicilnoUzn)
                    .HasColumnName("SICILNO_UZN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TarihFormat)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TARIH_FORMAT");

                entity.Property(e => e.Threshold).HasColumnName("THRESHOLD");

                entity.Property(e => e.TuslaGcSecim)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TUSLA_GC_SECIM");

                entity.Property(e => e.TxtDosya)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TXT_DOSYA");

                entity.Property(e => e.TxtKaydet)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TXT_KAYDET");

                entity.Property(e => e.UdpPort).HasColumnName("UDP_PORT");

                entity.Property(e => e.YemekhaneGecisKontrol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YEMEKHANE_GECIS_KONTROL");

                entity.Property(e => e.YuklemeOnay)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YUKLEME_ONAY");
            });

            modelBuilder.Entity<GksParmakizi>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_PARMAKIZI");

                entity.HasIndex(e => e.PiIdno, "GKS_PARMAKIZI_IDX1");

                entity.HasIndex(e => e.Version, "GKS_PARMAKIZI_IDX2");

                entity.HasIndex(e => new { e.PiIdno, e.Version }, "GKS_PARMAKIZI_IDX3");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Pi0)
                    .HasColumnType("text")
                    .HasColumnName("PI0");

                entity.Property(e => e.Pi1)
                    .HasColumnType("text")
                    .HasColumnName("PI1");

                entity.Property(e => e.Pi2)
                    .HasColumnType("text")
                    .HasColumnName("PI2");

                entity.Property(e => e.Pi3)
                    .HasColumnType("text")
                    .HasColumnName("PI3");

                entity.Property(e => e.Pi4)
                    .HasColumnType("text")
                    .HasColumnName("PI4");

                entity.Property(e => e.Pi5)
                    .HasColumnType("text")
                    .HasColumnName("PI5");

                entity.Property(e => e.Pi6)
                    .HasColumnType("text")
                    .HasColumnName("PI6");

                entity.Property(e => e.Pi7)
                    .HasColumnType("text")
                    .HasColumnName("PI7");

                entity.Property(e => e.Pi8)
                    .HasColumnType("text")
                    .HasColumnName("PI8");

                entity.Property(e => e.Pi9)
                    .HasColumnType("text")
                    .HasColumnName("PI9");

                entity.Property(e => e.PiIdno).HasColumnName("PI_IDNO");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TIPI");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((9))");
            });

            modelBuilder.Entity<GksPerislem>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_PERISLEM");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Aktif)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AKTIF");

                entity.Property(e => e.CihazNo).HasColumnName("CIHAZ_NO");

                entity.Property(e => e.Depart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEPART");

                entity.Property(e => e.Iscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISCIKT");

                entity.Property(e => e.Isgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISGIRT");

                entity.Property(e => e.Islemturu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ISLEMTURU");

                entity.Property(e => e.Keycode).HasColumnName("KEYCODE");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.PiCardid).HasColumnName("PI_CARDID");

                entity.Property(e => e.PiIdno).HasColumnName("PI_IDNO");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SIFRE");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Yetkituru).HasColumnName("YETKITURU");
            });

            modelBuilder.Entity<GksPlaka>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_PLAKA");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Aktif).HasColumnName("AKTIF");

                entity.Property(e => e.Plaka)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PLAKA");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<GksSonhareket>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GKS_SONHAREKET");

                entity.Property(e => e.Cihaz).HasColumnName("CIHAZ");

                entity.Property(e => e.GrupKodu).HasColumnName("GRUP_KODU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Keycode).HasColumnName("KEYCODE");

                entity.Property(e => e.Nedenkodu).HasColumnName("NEDENKODU");

                entity.Property(e => e.PiIdno).HasColumnName("PI_IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.ToplaTar)
                    .HasColumnType("datetime")
                    .HasColumnName("TOPLA_TAR");

                entity.Property(e => e.Yon).HasColumnName("YON");

                entity.Property(e => e.ZamanTrh)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN_TRH");
            });

            modelBuilder.Entity<GksSyncCihazgrup>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Grupkodu });

                entity.ToTable("GKS_SYNC_CIHAZGRUP");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Grupkodu).HasColumnName("GRUPKODU");

                entity.Property(e => e.Grupadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUPADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SERVER_IP");
            });

            modelBuilder.Entity<GksSyncGrupcihaz>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.GrupKodu, e.CihazNo });

                entity.ToTable("GKS_SYNC_GRUPCIHAZ");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.GrupKodu).HasColumnName("GRUP_KODU");

                entity.Property(e => e.CihazNo).HasColumnName("CIHAZ_NO");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Sil)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SIL");

                entity.Property(e => e.Topla)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TOPLA");

                entity.Property(e => e.Yukle)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("YUKLE");

                entity.Property(e => e.YuklemeTuru)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YUKLEME_TURU")
                    .HasDefaultValueSql("('Tümü')");

                entity.Property(e => e.ZamanAyari)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ZAMAN_AYARI");
            });

            modelBuilder.Entity<GksSyncGrupzaman>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_SYNC_GRUPZAMAN");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.GrupKodu).HasColumnName("GRUP_KODU");

                entity.Property(e => e.Gun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GUN");

                entity.Property(e => e.Gunkodu).HasColumnName("GUNKODU");

                entity.Property(e => e.Saat)
                    .HasColumnType("datetime")
                    .HasColumnName("SAAT");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<GksSyncLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GKS_SYNC_LOG");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.BlokeHareket).HasColumnName("BLOKE_HAREKET");

                entity.Property(e => e.CihazNo).HasColumnName("CIHAZ_NO");

                entity.Property(e => e.GecerliHareket).HasColumnName("GECERLI_HAREKET");

                entity.Property(e => e.IslemTuru)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ISLEM_TURU");

                entity.Property(e => e.IslemZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLEM_ZAMANI");

                entity.Property(e => e.PersonelSayisi).HasColumnName("PERSONEL_SAYISI");

                entity.Property(e => e.Sonuc).HasColumnName("SONUC");

                entity.Property(e => e.TanimliZaman)
                    .HasColumnType("datetime")
                    .HasColumnName("TANIMLI_ZAMAN");

                entity.Property(e => e.ToplamHareket).HasColumnName("TOPLAM_HAREKET");
            });

            modelBuilder.Entity<GksSyncMailcihaz>(entity =>
            {
                entity.HasKey(e => new { e.MailIdno, e.CihazNo });

                entity.ToTable("GKS_SYNC_MAILCIHAZ");

                entity.Property(e => e.MailIdno).HasColumnName("MAIL_IDNO");

                entity.Property(e => e.CihazNo).HasColumnName("CIHAZ_NO");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<GksSyncMailliste>(entity =>
            {
                entity.HasKey(e => e.MailAdresi);

                entity.ToTable("GKS_SYNC_MAILLISTE");

                entity.Property(e => e.MailAdresi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_ADRESI");

                entity.Property(e => e.Alici)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ALICI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<GksSyncTanim>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Zamangrup, e.Cihazgrup })
                    .HasName("PK_GKS_SYNCTANIM");

                entity.ToTable("GKS_SYNC_TANIM");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Zamangrup).HasColumnName("ZAMANGRUP");

                entity.Property(e => e.Cihazgrup).HasColumnName("CIHAZGRUP");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<GksSyncZamangrup>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Grupkodu });

                entity.ToTable("GKS_SYNC_ZAMANGRUP");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Grupkodu).HasColumnName("GRUPKODU");

                entity.Property(e => e.Grupadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUPADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<GksVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GKS_VERSION");

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VERSION");
            });

            modelBuilder.Entity<GksYetkitanim>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_YETKITANIM");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Cihazgrup).HasColumnName("CIHAZGRUP");

                entity.Property(e => e.Deger)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEGER");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Yetkituru)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("YETKITURU");

                entity.Property(e => e.Zamangrup).HasColumnName("ZAMANGRUP");
            });

            modelBuilder.Entity<GksYetkitanimAsansor>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_YETKITANIM_ASANSOR");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.CihazNo).HasColumnName("CIHAZ_NO");

                entity.Property(e => e.Deger)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEGER");

                entity.Property(e => e.Port1)
                    .HasColumnName("PORT1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port10)
                    .HasColumnName("PORT10")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port11)
                    .HasColumnName("PORT11")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port12)
                    .HasColumnName("PORT12")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port13)
                    .HasColumnName("PORT13")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port14)
                    .HasColumnName("PORT14")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port15)
                    .HasColumnName("PORT15")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port16)
                    .HasColumnName("PORT16")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port2)
                    .HasColumnName("PORT2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port3)
                    .HasColumnName("PORT3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port4)
                    .HasColumnName("PORT4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port5)
                    .HasColumnName("PORT5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port6)
                    .HasColumnName("PORT6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port7)
                    .HasColumnName("PORT7")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port8)
                    .HasColumnName("PORT8")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port9)
                    .HasColumnName("PORT9")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Yetkituru)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("YETKITURU");
            });

            modelBuilder.Entity<GksYtkCihazgrup>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Grupkodu });

                entity.ToTable("GKS_YTK_CIHAZGRUP");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Grupkodu).HasColumnName("GRUPKODU");

                entity.Property(e => e.Grupadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUPADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<GksYtkGrupcihaz>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.GrupKodu, e.CihazNo });

                entity.ToTable("GKS_YTK_GRUPCIHAZ");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.GrupKodu).HasColumnName("GRUP_KODU");

                entity.Property(e => e.CihazNo).HasColumnName("CIHAZ_NO");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<GksYtkGruppersonel>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_YTK_GRUPPERSONEL");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.GrupKodu).HasColumnName("GRUP_KODU");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<GksYtkGrupzaman>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GKS_YTK_GRUPZAMAN");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.GrupKodu).HasColumnName("GRUP_KODU");

                entity.Property(e => e.Gun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GUN");

                entity.Property(e => e.Gunkodu).HasColumnName("GUNKODU");

                entity.Property(e => e.Sayi).HasColumnName("SAYI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<GksYtkPersonelgrup>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Grupkodu });

                entity.ToTable("GKS_YTK_PERSONELGRUP");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Grupkodu).HasColumnName("GRUPKODU");

                entity.Property(e => e.Grupadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUPADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<GksYtkZamangrup>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Grupkodu });

                entity.ToTable("GKS_YTK_ZAMANGRUP");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Grupkodu).HasColumnName("GRUPKODU");

                entity.Property(e => e.Grupadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUPADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<Golgeprim>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Pertipi, e.Kaynakfm });

                entity.ToTable("GOLGEPRIM");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Pertipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIPI");

                entity.Property(e => e.Kaynakfm).HasColumnName("KAYNAKFM");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.Hedeffm).HasColumnName("HEDEFFM");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Limit)
                    .HasColumnType("datetime")
                    .HasColumnName("LIMIT");
            });

            modelBuilder.Entity<Gorev>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("GOREV");

                entity.HasIndex(e => new { e.Srkodu, e.Kodu }, "IDX_YN_01");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KODU");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<Grup>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.GrupKodu });

                entity.ToTable("GRUP");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.GrupKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_KODU");

                entity.Property(e => e.GrupAdi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_ADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<Grupcihazlari>(entity =>
            {
                entity.HasKey(e => e.Num);

                entity.ToTable("GRUPCIHAZLARI");

                entity.Property(e => e.Num).HasColumnName("NUM");

                entity.Property(e => e.Cihaz).HasColumnName("CIHAZ");

                entity.Property(e => e.Grup).HasColumnName("GRUP");
            });

            modelBuilder.Entity<Gunizin1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("GUNIZIN1");

                entity.HasIndex(e => new { e.Prsicil, e.Bastarih, e.Bittarih }, "GUNIZIN1_IDX1");

                entity.HasIndex(e => e.Linkid, "GUNIZIN1_IDX2");

                entity.HasIndex(e => new { e.Prsicil, e.Neden, e.Bastarih, e.Bittarih }, "Idx_Yn_1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Bittarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTARIH");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.Isbasi)
                    .HasColumnType("datetime")
                    .HasColumnName("ISBASI");

                entity.Property(e => e.Linkid).HasColumnName("LINKID");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN")
                    .IsFixedLength();

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Trnid).HasColumnName("TRNID");

                entity.Property(e => e.VekilSicilno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VEKIL_SICILNO");
            });

            modelBuilder.Entity<Haberci1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("HABERCI1");

                entity.HasIndex(e => e.Prsicil, "HABERCI1_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Gsm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("GSM");

                entity.Property(e => e.Il)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IL");

                entity.Property(e => e.Ilce)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ILCE");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Tel1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TEL1");

                entity.Property(e => e.Tel2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TEL2");
            });

            modelBuilder.Entity<Hareket1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("HAREKET1");

                entity.HasIndex(e => new { e.Barkod, e.Tarih, e.Zaman }, "HAREKET1_BARKOD_TARIH_ZAMAN");

                entity.HasIndex(e => new { e.Prsicil, e.Tarih }, "HAREKET1_PRSICIL,TARIH");

                entity.HasIndex(e => new { e.Prsicil, e.Tarih, e.Zaman }, "HAREKET1_PRSICIL_A_TARIH_A_ZAMAN_A");

                entity.HasIndex(e => new { e.Prsicil, e.Tarih, e.Zaman }, "HAREKET1_PRSICIL_A_TARIH_D_ZAMAN_D");

                entity.HasIndex(e => new { e.Prsicil, e.Tarih, e.Zaman, e.Gckodu, e.Neden, e.Termkodu }, "HAREKET1_PRSICIL_TARIH_ZAMAN_GCKODU_NEDEN_TERMKODU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Barkod)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BARKOD");

                entity.Property(e => e.Gckodu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GCKODU")
                    .IsFixedLength();

                entity.Property(e => e.HareketIdno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HAREKET_IDNO");

                entity.Property(e => e.Linkid).HasColumnName("LINKID");

                entity.Property(e => e.Neden).HasColumnName("NEDEN");

                entity.Property(e => e.Otarih)
                    .HasColumnType("datetime")
                    .HasColumnName("OTARIH");

                entity.Property(e => e.Ozaman)
                    .HasColumnType("datetime")
                    .HasColumnName("OZAMAN");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Sistem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SISTEM");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Termkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TERMKODU")
                    .IsFixedLength();

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<Hareketler>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("HAREKETLER");

                entity.HasIndex(e => new { e.Kartno, e.Sicil, e.Sirket, e.ZamanTrh, e.Yon, e.Nedenkodu, e.Cihaz }, "IDX_01");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Cihaz).HasColumnName("CIHAZ");

                entity.Property(e => e.Hartipi)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("HARTIPI")
                    .HasDefaultValueSql("('ORJ')");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Keycode).HasColumnName("KEYCODE");

                entity.Property(e => e.Mesaj).HasColumnName("MESAJ");

                entity.Property(e => e.Nedenkodu).HasColumnName("NEDENKODU");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Sicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICIL");

                entity.Property(e => e.Sirket).HasColumnName("SIRKET");

                entity.Property(e => e.ToplaTar)
                    .HasColumnType("datetime")
                    .HasColumnName("TOPLA_TAR");

                entity.Property(e => e.Yon)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YON");

                entity.Property(e => e.ZamanTrh)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN_TRH");
            });

            modelBuilder.Entity<Harlog1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("HARLOG1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Barkod)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BARKOD");

                entity.Property(e => e.Gckodu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GCKODU")
                    .IsFixedLength();

                entity.Property(e => e.Isltarih)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLTARIH");

                entity.Property(e => e.Islturu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ISLTURU");

                entity.Property(e => e.Islzaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLZAMAN");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI")
                    .IsFixedLength();

                entity.Property(e => e.Linkid).HasColumnName("LINKID");

                entity.Property(e => e.Neden)
                    .HasColumnName("NEDEN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NewBarkod)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NEW_BARKOD");

                entity.Property(e => e.NewGckodu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NEW_GCKODU")
                    .IsFixedLength();

                entity.Property(e => e.NewLinkid).HasColumnName("NEW_LINKID");

                entity.Property(e => e.NewNeden).HasColumnName("NEW_NEDEN");

                entity.Property(e => e.NewTarih)
                    .HasColumnType("datetime")
                    .HasColumnName("NEW_TARIH");

                entity.Property(e => e.NewTermkodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEW_TERMKODU");

                entity.Property(e => e.NewZaman)
                    .HasColumnType("datetime")
                    .HasColumnName("NEW_ZAMAN");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Termkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TERMKODU")
                    .IsFixedLength();

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<Hartemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HARTEMP");

                entity.HasIndex(e => new { e.Barkod, e.Tarih, e.Zaman }, "HARTEMP_IDX1");

                entity.Property(e => e.Barkod)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BARKOD");

                entity.Property(e => e.Gckodu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GCKODU")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.Kartid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("KARTID");

                entity.Property(e => e.Neden).HasColumnName("NEDEN");

                entity.Property(e => e.Refid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REFID");

                entity.Property(e => e.Sistem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SISTEM");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Termkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TERMKODU")
                    .IsFixedLength();

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<Hatagc>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("HATAGC");

                entity.HasIndex(e => new { e.Barkod, e.Izahat }, "HATAGC_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Barkod)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BARKOD");

                entity.Property(e => e.Gckodu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GCKODU")
                    .IsFixedLength();

                entity.Property(e => e.Izahat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");

                entity.Property(e => e.Kartid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("KARTID");

                entity.Property(e => e.Neden)
                    .HasColumnName("NEDEN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sistem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SISTEM");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Termkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TERMKODU")
                    .IsFixedLength();

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<Hobi1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("HOBI1");

                entity.HasIndex(e => e.Prsicil, "HOBI1_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Hobi)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("HOBI");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");
            });

            modelBuilder.Entity<Hpparam>(entity =>
            {
                entity.HasKey(e => new { e.Pertip, e.Srkodu });

                entity.ToTable("HPPARAM");

                entity.Property(e => e.Pertip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP")
                    .IsFixedLength();

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Calsaat)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("CALSAAT");

                entity.Property(e => e.Devlimit)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("DEVLIMIT");

                entity.Property(e => e.Gunlimit)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("GUNLIMIT");

                entity.Property(e => e.Haftalimit)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("HAFTALIMIT");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Tatil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TATIL");

                entity.Property(e => e.Ucsiz)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UCSIZ");
            });

            modelBuilder.Entity<Hpparamalt>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Hpkodu, e.Clkodu });

                entity.ToTable("HPPARAMALT");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Hpkodu).HasColumnName("HPKODU");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Sonuc)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SONUC");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TIPI");
            });

            modelBuilder.Entity<Hpuantaj1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("HPUANTAJ1");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Drcno).HasColumnName("DRCNO");

                entity.Property(e => e.GunHesapla)
                    .HasColumnName("GUN_HESAPLA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hafta).HasColumnName("HAFTA");

                entity.Property(e => e.Izahat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");

                entity.Property(e => e.Neden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Onay)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ONAY")
                    .IsFixedLength();

                entity.Property(e => e.Orjsure)
                    .HasColumnType("datetime")
                    .HasColumnName("ORJSURE");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Pskodu).HasColumnName("PSKODU");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<Htke>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("HTKES");

                entity.HasIndex(e => new { e.Srkodu, e.Pertip }, "HTKES_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Devamsiz).HasColumnName("DEVAMSIZ");

                entity.Property(e => e.Devir)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DEVIR")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Pertip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP")
                    .IsFixedLength();

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<Htkesdgl>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("HTKESDGL");

                entity.HasIndex(e => new { e.Srkodu, e.Pertip }, "HTKESDGL_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Pertip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP")
                    .IsFixedLength();

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<Iliski>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ILISKI");

                entity.HasIndex(e => new { e.Tablo1, e.Alan1, e.Tablo2, e.Alan2 }, "ILISKI_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Alan1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ALAN1")
                    .IsFixedLength();

                entity.Property(e => e.Alan2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ALAN2")
                    .IsFixedLength();

                entity.Property(e => e.Metod)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("METOD")
                    .IsFixedLength();

                entity.Property(e => e.Tablo1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TABLO1")
                    .IsFixedLength();

                entity.Property(e => e.Tablo2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TABLO2")
                    .IsFixedLength();

                entity.Property(e => e.Turu)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .IsFixedLength();
            });

            modelBuilder.Entity<IzinOnay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IZIN_ONAY");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Bittarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTARIH");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Isbasi)
                    .HasColumnType("datetime")
                    .HasColumnName("ISBASI");

                entity.Property(e => e.Linkid).HasColumnName("LINKID");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN")
                    .IsFixedLength();

                entity.Property(e => e.Onay1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY1")
                    .IsFixedLength();

                entity.Property(e => e.Onay1kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY1KL");

                entity.Property(e => e.Onay2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY2")
                    .IsFixedLength();

                entity.Property(e => e.Onay2kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY2KL");

                entity.Property(e => e.Onay3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY3");

                entity.Property(e => e.Onay3kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY3KL");

                entity.Property(e => e.Onay4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY4")
                    .IsFixedLength();

                entity.Property(e => e.Onay4kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY4KL");

                entity.Property(e => e.Onay5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY5")
                    .IsFixedLength();

                entity.Property(e => e.Onay5kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY5KL");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Trnid).HasColumnName("TRNID");
            });

            modelBuilder.Entity<IzinOnaySaat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IZIN_ONAY_SAAT");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN")
                    .IsFixedLength();

                entity.Property(e => e.Onay1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY1")
                    .IsFixedLength();

                entity.Property(e => e.Onay1kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY1KL");

                entity.Property(e => e.Onay2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY2")
                    .IsFixedLength();

                entity.Property(e => e.Onay2kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY2KL");

                entity.Property(e => e.Onay3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY3")
                    .IsFixedLength();

                entity.Property(e => e.Onay3kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY3KL");

                entity.Property(e => e.Onay4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY4")
                    .IsFixedLength();

                entity.Property(e => e.Onay4kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY4KL");

                entity.Property(e => e.Onay5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY5")
                    .IsFixedLength();

                entity.Property(e => e.Onay5kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY5KL");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Saat)
                    .HasColumnType("datetime")
                    .HasColumnName("SAAT");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Trnid).HasColumnName("TRNID");
            });

            modelBuilder.Entity<Izindagit>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("IZINDAGIT");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Clkodu1).HasColumnName("CLKODU1");

                entity.Property(e => e.Clkodu2).HasColumnName("CLKODU2");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.Gun2).HasColumnName("GUN2");

                entity.Property(e => e.Sec)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEC");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<Izinlimit>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("IZINLIMIT");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.AylikLimitSure)
                    .HasColumnName("AYLIK_LIMIT_SURE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AylikPuantaj).HasColumnName("AYLIK_PUANTAJ");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.GunlukLimitSure)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNLUK_LIMIT_SURE");

                entity.Property(e => e.GunlukPuantaj).HasColumnName("GUNLUK_PUANTAJ");

                entity.Property(e => e.IzinGiris).HasColumnName("IZIN_GIRIS");

                entity.Property(e => e.IzinTuru)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZIN_TURU");

                entity.Property(e => e.LimitSure).HasColumnName("LIMIT_SURE");

                entity.Property(e => e.ParcaliKullanim).HasColumnName("PARCALI_KULLANIM");

                entity.Property(e => e.PersonelGrubu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERSONEL_GRUBU");

                entity.Property(e => e.Saat)
                    .HasColumnType("datetime")
                    .HasColumnName("SAAT");

                entity.Property(e => e.Sec)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEC");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tip)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TIP")
                    .IsFixedLength();

                entity.Property(e => e.Trnclkodu).HasColumnName("TRNCLKODU");

                entity.Property(e => e.YenilemePeriyodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YENILEME_PERIYODU");

                entity.Property(e => e.YillikIzinKontrol).HasColumnName("YILLIK_IZIN_KONTROL");
            });

            modelBuilder.Entity<IzinlimitGrupdetay>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("IZINLIMIT_GRUPDETAY");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Deger)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEGER");

                entity.Property(e => e.GrupKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_KODU");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<IzinlimitPergrup>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.GrupKodu });

                entity.ToTable("IZINLIMIT_PERGRUP");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.GrupKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_KODU");

                entity.Property(e => e.GrupAdi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_ADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<Izinlog1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("IZINLOG1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Baslama)
                    .HasColumnType("datetime")
                    .HasColumnName("BASLAMA");

                entity.Property(e => e.Bitis)
                    .HasColumnType("datetime")
                    .HasColumnName("BITIS");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.Isbasi)
                    .HasColumnType("datetime")
                    .HasColumnName("ISBASI");

                entity.Property(e => e.Islsaati)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLSAATI");

                entity.Property(e => e.Isltarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLTARIHI");

                entity.Property(e => e.Islturu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ISLTURU");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Linkid).HasColumnName("LINKID");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN")
                    .IsFixedLength();

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Saat)
                    .HasColumnType("datetime")
                    .HasColumnName("SAAT");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.VekilSicilno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VEKIL_SICILNO");
            });

            modelBuilder.Entity<Izneden>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("IZNEDEN");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KODU")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<Kadro>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("KADRO");

                entity.HasIndex(e => new { e.Srkodu, e.Kodu }, "IDX_YN_01");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KODU")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Kariyer1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("KARIYER1");

                entity.HasIndex(e => new { e.Prsicil, e.Firma, e.Girtar, e.Ciktar }, "KARIYER1_IDX1")
                    .IsUnique();

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Ayrndn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AYRNDN");

                entity.Property(e => e.Ciktar)
                    .HasColumnType("datetime")
                    .HasColumnName("CIKTAR");

                entity.Property(e => e.Firma)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRMA");

                entity.Property(e => e.Girtar)
                    .HasColumnType("datetime")
                    .HasColumnName("GIRTAR");

                entity.Property(e => e.Gorev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GOREV");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Ucret).HasColumnName("UCRET");
            });

            modelBuilder.Entity<Kartlar>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("KARTLAR");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Atamatarih)
                    .HasColumnType("datetime")
                    .HasColumnName("ATAMATARIH");

                entity.Property(e => e.Atcustomer).HasColumnName("ATCUSTOMER");

                entity.Property(e => e.Customerdef)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERDEF");

                entity.Property(e => e.Durum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DURUM");

                entity.Property(e => e.Keycode).HasColumnName("KEYCODE");

                entity.Property(e => e.Persicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PERSICIL");

                entity.Property(e => e.Persirket).HasColumnName("PERSIRKET");

                entity.Property(e => e.Pizikeycode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PIZIKEYCODE");

                entity.Property(e => e.Sonkulltarih)
                    .HasColumnType("datetime")
                    .HasColumnName("SONKULLTARIH");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPI")
                    .HasDefaultValueSql("('PER')");
            });

            modelBuilder.Entity<Kimlik1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("KIMLIK1");

                entity.HasIndex(e => new { e.Prsicil, e.Tckmno }, "IDXKIM")
                    .IsUnique();

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Aileno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AILENO")
                    .IsFixedLength();

                entity.Property(e => e.Anne)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ANNE");

                entity.Property(e => e.Baba)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BABA");

                entity.Property(e => e.Ciltno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CILTNO")
                    .IsFixedLength();

                entity.Property(e => e.Cinsyt)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CINSYT")
                    .IsFixedLength();

                entity.Property(e => e.Czno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CZNO")
                    .IsFixedLength();

                entity.Property(e => e.Czseri)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CZSERI")
                    .IsFixedLength();

                entity.Property(e => e.Dini)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DINI")
                    .IsFixedLength();

                entity.Property(e => e.Dogil)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DOGIL");

                entity.Property(e => e.Dogilce)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DOGILCE");

                entity.Property(e => e.Dogtar)
                    .HasColumnType("datetime")
                    .HasColumnName("DOGTAR");

                entity.Property(e => e.Il)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IL");

                entity.Property(e => e.Ilce)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ILCE");

                entity.Property(e => e.Kangrb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KANGRB")
                    .IsFixedLength();

                entity.Property(e => e.Kayitno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KAYITNO");

                entity.Property(e => e.Koy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("KOY");

                entity.Property(e => e.Mahalle)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MAHALLE");

                entity.Property(e => e.Medhal)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MEDHAL")
                    .IsFixedLength();

                entity.Property(e => e.Onsoy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONSOY");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Sirano)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIRANO")
                    .IsFixedLength();

                entity.Property(e => e.Tckmno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TCKMNO");

                entity.Property(e => e.Uyruk)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UYRUK")
                    .IsFixedLength();

                entity.Property(e => e.Verned)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VERNED");

                entity.Property(e => e.Vertar)
                    .HasColumnType("datetime")
                    .HasColumnName("VERTAR");

                entity.Property(e => e.Veryer)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("VERYER");
            });

            modelBuilder.Entity<KntAypuan1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("KNT_AYPUAN1");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Ay).HasColumnName("AY");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Drcno).HasColumnName("DRCNO");

                entity.Property(e => e.Ondsure)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("ONDSURE");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Sure)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SURE")
                    .IsFixedLength();

                entity.Property(e => e.Topgun)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("TOPGUN");

                entity.Property(e => e.Yil).HasColumnName("YIL");
            });

            modelBuilder.Entity<KntGunizin1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("KNT_GUNIZIN1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Bittarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTARIH");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.Isbasi)
                    .HasColumnType("datetime")
                    .HasColumnName("ISBASI");

                entity.Property(e => e.Linkid).HasColumnName("LINKID");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN")
                    .IsFixedLength();

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Trnid).HasColumnName("TRNID");

                entity.Property(e => e.VekilSicilno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VEKIL_SICILNO");
            });

            modelBuilder.Entity<KntHareket1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("KNT_HAREKET1");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Barkod)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BARKOD");

                entity.Property(e => e.Gckodu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GCKODU")
                    .IsFixedLength();

                entity.Property(e => e.Linkid).HasColumnName("LINKID");

                entity.Property(e => e.Neden).HasColumnName("NEDEN");

                entity.Property(e => e.Otarih)
                    .HasColumnType("datetime")
                    .HasColumnName("OTARIH");

                entity.Property(e => e.Ozaman)
                    .HasColumnType("datetime")
                    .HasColumnName("OZAMAN");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Sistem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SISTEM");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Termkodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TERMKODU");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<KntParam>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("KNT_PARAM");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.AylikKontrolCmt).HasColumnName("AYLIK_KONTROL_CMT");

                entity.Property(e => e.AylikKontrolGt).HasColumnName("AYLIK_KONTROL_GT");

                entity.Property(e => e.AylikKontrolHi).HasColumnName("AYLIK_KONTROL_HI");

                entity.Property(e => e.AylikKontrolHt).HasColumnName("AYLIK_KONTROL_HT");

                entity.Property(e => e.AylikLimitCmt).HasColumnName("AYLIK_LIMIT_CMT");

                entity.Property(e => e.AylikLimitGt).HasColumnName("AYLIK_LIMIT_GT");

                entity.Property(e => e.AylikLimitHi).HasColumnName("AYLIK_LIMIT_HI");

                entity.Property(e => e.AylikLimitHt).HasColumnName("AYLIK_LIMIT_HT");

                entity.Property(e => e.CalisilanCmt).HasColumnName("CALISILAN_CMT");

                entity.Property(e => e.CalisilanGt).HasColumnName("CALISILAN_GT");

                entity.Property(e => e.CalisilanHi).HasColumnName("CALISILAN_HI");

                entity.Property(e => e.CalisilanHt).HasColumnName("CALISILAN_HT");

                entity.Property(e => e.ClkoduCmt).HasColumnName("CLKODU_CMT");

                entity.Property(e => e.ClkoduDvm).HasColumnName("CLKODU_DVM");

                entity.Property(e => e.ClkoduGt).HasColumnName("CLKODU_GT");

                entity.Property(e => e.ClkoduHt).HasColumnName("CLKODU_HT");

                entity.Property(e => e.ClkoduNrm).HasColumnName("CLKODU_NRM");

                entity.Property(e => e.ClkoduSsk).HasColumnName("CLKODU_SSK");

                entity.Property(e => e.DereceliMesaiDagilim).HasColumnName("DERECELI_MESAI_DAGILIM");

                entity.Property(e => e.EksikGunFmyaz).HasColumnName("EKSIK_GUN_FMYAZ");

                entity.Property(e => e.FazlaClkoduCmt).HasColumnName("FAZLA_CLKODU_CMT");

                entity.Property(e => e.FazlaClkoduGt).HasColumnName("FAZLA_CLKODU_GT");

                entity.Property(e => e.FazlaClkoduHi).HasColumnName("FAZLA_CLKODU_HI");

                entity.Property(e => e.FazlaClkoduHt).HasColumnName("FAZLA_CLKODU_HT");

                entity.Property(e => e.FmcmtOrj).HasColumnName("FMCMT_ORJ");

                entity.Property(e => e.FmgtOrj).HasColumnName("FMGT_ORJ");

                entity.Property(e => e.FmhtOrj).HasColumnName("FMHT_ORJ");

                entity.Property(e => e.FmkoduCmt).HasColumnName("FMKODU_CMT");

                entity.Property(e => e.FmkoduGt).HasColumnName("FMKODU_GT");

                entity.Property(e => e.FmkoduGt2).HasColumnName("FMKODU_GT2");

                entity.Property(e => e.FmkoduHi).HasColumnName("FMKODU_HI");

                entity.Property(e => e.FmkoduHt).HasColumnName("FMKODU_HT");

                entity.Property(e => e.GercekCalismaSuresi).HasColumnName("GERCEK_CALISMA_SURESI");

                entity.Property(e => e.GercekGunlukIzin).HasColumnName("GERCEK_GUNLUK_IZIN");

                entity.Property(e => e.GercekSaatlikIzin).HasColumnName("GERCEK_SAATLIK_IZIN");

                entity.Property(e => e.GunlukLimitCmt).HasColumnName("GUNLUK_LIMIT_CMT");

                entity.Property(e => e.GunlukLimitCmt2).HasColumnName("GUNLUK_LIMIT_CMT2");

                entity.Property(e => e.GunlukLimitCmtMax).HasColumnName("GUNLUK_LIMIT_CMT_MAX");

                entity.Property(e => e.GunlukLimitGt).HasColumnName("GUNLUK_LIMIT_GT");

                entity.Property(e => e.GunlukLimitGt2).HasColumnName("GUNLUK_LIMIT_GT2");

                entity.Property(e => e.GunlukLimitGtMax).HasColumnName("GUNLUK_LIMIT_GT_MAX");

                entity.Property(e => e.GunlukLimitHi).HasColumnName("GUNLUK_LIMIT_HI");

                entity.Property(e => e.GunlukLimitHt).HasColumnName("GUNLUK_LIMIT_HT");

                entity.Property(e => e.GunlukLimitHt2).HasColumnName("GUNLUK_LIMIT_HT2");

                entity.Property(e => e.GunlukLimitHtMax).HasColumnName("GUNLUK_LIMIT_HT_MAX");

                entity.Property(e => e.HaftalikKontrolCmt).HasColumnName("HAFTALIK_KONTROL_CMT");

                entity.Property(e => e.HaftalikKontrolGt).HasColumnName("HAFTALIK_KONTROL_GT");

                entity.Property(e => e.HaftalikKontrolHi).HasColumnName("HAFTALIK_KONTROL_HI");

                entity.Property(e => e.HaftalikKontrolHt).HasColumnName("HAFTALIK_KONTROL_HT");

                entity.Property(e => e.HaftalikLimitCmt).HasColumnName("HAFTALIK_LIMIT_CMT");

                entity.Property(e => e.HaftalikLimitGt).HasColumnName("HAFTALIK_LIMIT_GT");

                entity.Property(e => e.HaftalikLimitHi).HasColumnName("HAFTALIK_LIMIT_HI");

                entity.Property(e => e.HaftalikLimitHt).HasColumnName("HAFTALIK_LIMIT_HT");

                entity.Property(e => e.HaftalikToplamCalisma).HasColumnName("HAFTALIK_TOPLAM_CALISMA");

                entity.Property(e => e.HaftalikVardiyaKontrol).HasColumnName("HAFTALIK_VARDIYA_KONTROL");

                entity.Property(e => e.IzinKodu).HasColumnName("IZIN_KODU");

                entity.Property(e => e.IzinSuresi)
                    .HasColumnType("datetime")
                    .HasColumnName("IZIN_SURESI");

                entity.Property(e => e.KatsayiCmt).HasColumnName("KATSAYI_CMT");

                entity.Property(e => e.KatsayiGt).HasColumnName("KATSAYI_GT");

                entity.Property(e => e.KatsayiHi).HasColumnName("KATSAYI_HI");

                entity.Property(e => e.KatsayiHt).HasColumnName("KATSAYI_HT");

                entity.Property(e => e.KontrolCmt).HasColumnName("KONTROL_CMT");

                entity.Property(e => e.KontrolGt).HasColumnName("KONTROL_GT");

                entity.Property(e => e.KontrolHi).HasColumnName("KONTROL_HI");

                entity.Property(e => e.KontrolHt).HasColumnName("KONTROL_HT");

                entity.Property(e => e.OrjinalAylikMesai).HasColumnName("ORJINAL_AYLIK_MESAI");

                entity.Property(e => e.PersonelBazliMesai).HasColumnName("PERSONEL_BAZLI_MESAI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.TekVardiyayiDuzenleme).HasColumnName("TEK_VARDIYAYI_DUZENLEME");

                entity.Property(e => e.TumMesaileriDagit).HasColumnName("TUM_MESAILERI_DAGIT");

                entity.Property(e => e.TumMesaileriGunduzeDagit).HasColumnName("TUM_MESAILERI_GUNDUZE_DAGIT");

                entity.Property(e => e.VardiyaDuzenle).HasColumnName("VARDIYA_DUZENLE");

                entity.Property(e => e.VrdKnt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VRD_KNT");

                entity.Property(e => e.VrdSure)
                    .HasColumnType("datetime")
                    .HasColumnName("VRD_SURE");
            });

            modelBuilder.Entity<KntPersonelFm1>(entity =>
            {
                entity.HasKey(e => new { e.Sicilno, e.Ay, e.Yil });

                entity.ToTable("KNT_PERSONEL_FM1");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Ay).HasColumnName("AY");

                entity.Property(e => e.Yil).HasColumnName("YIL");

                entity.Property(e => e.AylikLimitCmt)
                    .HasColumnName("AYLIK_LIMIT_CMT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AylikLimitGt)
                    .HasColumnName("AYLIK_LIMIT_GT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AylikLimitHi)
                    .HasColumnName("AYLIK_LIMIT_HI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AylikLimitHt)
                    .HasColumnName("AYLIK_LIMIT_HT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<KntPervardiya>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("KNT_PERVARDIYA");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Bittarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTARIH");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<KntPuantaj1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("KNT_PUANTAJ1");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Drcno).HasColumnName("DRCNO");

                entity.Property(e => e.Izahat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");

                entity.Property(e => e.Neden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Onay)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ONAY")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Orjsure)
                    .HasColumnType("datetime")
                    .HasColumnName("ORJSURE");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Pskodu).HasColumnName("PSKODU");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<KntSaatizin1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("KNT_SAATIZIN1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN")
                    .IsFixedLength();

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Saat)
                    .HasColumnType("datetime")
                    .HasColumnName("SAAT");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Trnid).HasColumnName("TRNID");
            });

            modelBuilder.Entity<KntVardiya>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("KNT_VARDIYA");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.NewVrkodu).HasColumnName("NEW_VRKODU");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<KodBazliYetkili>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("KOD_BAZLI_YETKILI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Kod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KOD");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.HasKey(e => e.Adi);

                entity.ToTable("KULLANICI");

                entity.HasIndex(e => new { e.Adi, e.Sifre }, "KULLANICI_IDX1");

                entity.Property(e => e.Adi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ADI")
                    .IsFixedLength();

                entity.Property(e => e.Adisoyadi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADISOYADI");

                entity.Property(e => e.Admin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADMIN")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength();

                entity.Property(e => e.AylikOnayDerece).HasColumnName("AYLIK_ONAY_DERECE");

                entity.Property(e => e.Derece)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DERECE")
                    .IsFixedLength();

                entity.Property(e => e.Dil).HasColumnName("DIL");

                entity.Property(e => e.DomainUsername)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_USERNAME");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.ExcelTransfer).HasColumnName("EXCEL_TRANSFER");

                entity.Property(e => e.Explorer)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("EXPLORER")
                    .IsFixedLength();

                entity.Property(e => e.FmOnay).HasColumnName("FM_ONAY");

                entity.Property(e => e.Font).HasColumnName("FONT");

                entity.Property(e => e.GunlukIzinOnay).HasColumnName("GUNLUK_IZIN_ONAY");

                entity.Property(e => e.HaftaTatiliOnay).HasColumnName("HAFTA_TATILI_ONAY");

                entity.Property(e => e.HareketEklemeOnay).HasColumnName("HAREKET_EKLEME_ONAY");

                entity.Property(e => e.HareketGecmisislem)
                    .HasColumnName("HAREKET_GECMISISLEM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HareketTablo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HAREKET_TABLO");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Izahat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");

                entity.Property(e => e.KodBazliYetki).HasColumnName("KOD_BAZLI_YETKI");

                entity.Property(e => e.Ntadi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NTADI");

                entity.Property(e => e.OfflineCalisma).HasColumnName("OFFLINE_CALISMA");

                entity.Property(e => e.OnySifre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONY_SIFRE");

                entity.Property(e => e.Outlook)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OUTLOOK")
                    .IsFixedLength();

                entity.Property(e => e.PostUser).HasColumnName("POST_USER");

                entity.Property(e => e.PuantajTablo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PUANTAJ_TABLO");

                entity.Property(e => e.SaatlikIzinOnay).HasColumnName("SAATLIK_IZIN_ONAY");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIFRE")
                    .IsFixedLength();

                entity.Property(e => e.Stylesheet)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STYLESHEET");

                entity.Property(e => e.TaksiUcretiOnay).HasColumnName("TAKSI_UCRETI_ONAY");

                entity.Property(e => e.Theme)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("THEME");

                entity.Property(e => e.Toolbar)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TOOLBAR")
                    .IsFixedLength();

                entity.Property(e => e.VardiyaOnay).HasColumnName("VARDIYA_ONAY");

                entity.Property(e => e.Vekil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VEKIL");
            });

            modelBuilder.Entity<Lisan>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("LISAN");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KODU")
                    .IsFixedLength();

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Idno).HasColumnName("IDNO");
            });

            modelBuilder.Entity<Logtablo>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("LOGTABLO");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Logdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LOGDATE");

                entity.Property(e => e.Loggrup)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOGGRUP");

                entity.Property(e => e.Lognewrec)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("LOGNEWREC");

                entity.Property(e => e.Logoldrec)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("LOGOLDREC");

                entity.Property(e => e.Logtype)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LOGTYPE");

                entity.Property(e => e.Loguser)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOGUSER");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<LokasyonToleran>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("LOKASYON_TOLERANS");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.CikisLokasyon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIKIS_LOKASYON");

                entity.Property(e => e.GirisLokasyon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GIRIS_LOKASYON");

                entity.Property(e => e.Tolerans)
                    .HasColumnType("datetime")
                    .HasColumnName("TOLERANS");
            });

            modelBuilder.Entity<LokasyonToleransCihaz>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("LOKASYON_TOLERANS_CIHAZ");

                entity.HasIndex(e => e.Cihaz, "LOKASYON_TOLERANS_CIHAZ_CIHAZ_NO");

                entity.HasIndex(e => new { e.Cihaz, e.Turu }, "LOKASYON_TOLERANS_CIHAZ_CIHAZ_NO_TURU");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Cihaz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZ");

                entity.Property(e => e.ToleransIdno).HasColumnName("TOLERANS_IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<Maildepart>(entity =>
            {
                entity.HasKey(e => new { e.Yetkili, e.Srkodu, e.Kodu });

                entity.ToTable("MAILDEPART");

                entity.Property(e => e.Yetkili)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("YETKILI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("KODU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<Mailkod>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Yetkili, e.Turu, e.Kodu });

                entity.ToTable("MAILKOD");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Yetkili)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("YETKILI");

                entity.Property(e => e.Turu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TURU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KODU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<Mailparam>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("MAILPARAM");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KODU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Adresi)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ADRESI");

                entity.Property(e => e.Grup)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GRUP");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");
            });

            modelBuilder.Entity<Mailuser>(entity =>
            {
                entity.HasKey(e => e.Kullanici);

                entity.ToTable("MAILUSER");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Mailadress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAILADRESS");

                entity.Property(e => e.Maillogin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MAILLOGIN");

                entity.Property(e => e.Mailpassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAILPASSWORD");

                entity.Property(e => e.Mailport)
                    .HasColumnName("MAILPORT")
                    .HasDefaultValueSql("((25))");

                entity.Property(e => e.Mailserver)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAILSERVER");

                entity.Property(e => e.Mailssl).HasColumnName("MAILSSL");

                entity.Property(e => e.Mailuser1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAILUSER");
            });

            modelBuilder.Entity<MasrafMerkezi>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("MASRAF_MERKEZI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("KODU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.Adi);

                entity.ToTable("MENU");

                entity.HasIndex(e => e.Anamenu, "MENU_IDX1");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Aizahat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AIZAHAT");

                entity.Property(e => e.Anamenu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ANAMENU");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Izahat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");
            });

            modelBuilder.Entity<Mesai>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("MESAI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Pertip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP")
                    .IsFixedLength();

                entity.Property(e => e.Sira).HasColumnName("SIRA");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<MesaiKesinti>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Pertip });

                entity.ToTable("MESAI_KESINTI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Pertip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<MesaiKesintiparam>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Pertip, e.Clkodu, e.Turu });

                entity.ToTable("MESAI_KESINTIPARAM");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Pertip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Turu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TURU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Sira).HasColumnName("SIRA");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");
            });

            modelBuilder.Entity<MesaiOnay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MESAI_ONAY");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Neden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Onay1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY1")
                    .IsFixedLength();

                entity.Property(e => e.Onay1kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY1KL");

                entity.Property(e => e.Onay2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY2")
                    .IsFixedLength();

                entity.Property(e => e.Onay2kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY2KL");

                entity.Property(e => e.Onay3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY3")
                    .IsFixedLength();

                entity.Property(e => e.Onay3kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY3KL");

                entity.Property(e => e.Onay4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY4")
                    .IsFixedLength();

                entity.Property(e => e.Onay4kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY4KL");

                entity.Property(e => e.Onay5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY5")
                    .IsFixedLength();

                entity.Property(e => e.Onay5kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY5KL");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");
            });

            modelBuilder.Entity<Mesaike>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("MESAIKES");

                entity.HasIndex(e => e.Bagno, "MESAIKES_IDX1");

                entity.HasIndex(e => e.Sira, "MESAIKES_IDX2");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Bagno).HasColumnName("BAGNO");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Islem)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ISLEM")
                    .IsFixedLength();

                entity.Property(e => e.Sira).HasColumnName("SIRA");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<Meslek>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("MESLEK");

                entity.HasIndex(e => new { e.Srkodu, e.Kodu }, "IDX_YN_01");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KODU")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<NormKadro>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("NORM_KADRO");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Alan1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALAN1");

                entity.Property(e => e.Alan2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALAN2");

                entity.Property(e => e.Deger1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER1");

                entity.Property(e => e.Deger1adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER1ADI");

                entity.Property(e => e.Deger2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER2");

                entity.Property(e => e.Deger2adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER2ADI");

                entity.Property(e => e.NormKadro1).HasColumnName("NORM_KADRO");

                entity.Property(e => e.NormKadroAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NORM_KADRO_ADI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");
            });

            modelBuilder.Entity<NormKadroArsiv>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("NORM_KADRO_ARSIV");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.NormKadro).HasColumnName("NORM_KADRO");

                entity.Property(e => e.NormKadroAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NORM_KADRO_ADI");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");
            });

            modelBuilder.Entity<Okul>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("OKUL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KODU")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<OnyDonemler>(entity =>
            {
                entity.HasKey(e => new { e.Grupkod, e.Srkodu, e.Bastarih, e.Bittarih, e.Sontarih });

                entity.ToTable("ONY_DONEMLER");

                entity.Property(e => e.Grupkod).HasColumnName("GRUPKOD");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Bittarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTARIH");

                entity.Property(e => e.Sontarih)
                    .HasColumnType("datetime")
                    .HasColumnName("SONTARIH");

                entity.Property(e => e.Grupadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUPADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<OnyGrpFmnedTnm>(entity =>
            {
                entity.HasKey(e => e.GrpKodu);

                entity.ToTable("ONY_GRP_FMNED_TNM");

                entity.Property(e => e.GrpKodu)
                    .ValueGeneratedNever()
                    .HasColumnName("GRP_KODU");

                entity.Property(e => e.GrpAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRP_ADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<OnyGrpFmnedVeri>(entity =>
            {
                entity.HasKey(e => new { e.GrupKodu, e.IzinKodu });

                entity.ToTable("ONY_GRP_FMNED_VERI");

                entity.Property(e => e.GrupKodu).HasColumnName("GRUP_KODU");

                entity.Property(e => e.IzinKodu).HasColumnName("IZIN_KODU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.IzinAdi)
                    .HasMaxLength(10)
                    .HasColumnName("IZIN_ADI")
                    .IsFixedLength();
            });

            modelBuilder.Entity<OnyGrpIzinTnm>(entity =>
            {
                entity.HasKey(e => e.GrpKodu);

                entity.ToTable("ONY_GRP_IZIN_TNM");

                entity.Property(e => e.GrpKodu)
                    .ValueGeneratedNever()
                    .HasColumnName("GRP_KODU");

                entity.Property(e => e.GrpAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRP_ADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<OnyGrpIzinVeri>(entity =>
            {
                entity.HasKey(e => new { e.GrupKodu, e.IzinKodu });

                entity.ToTable("ONY_GRP_IZIN_VERI");

                entity.Property(e => e.GrupKodu).HasColumnName("GRUP_KODU");

                entity.Property(e => e.IzinKodu).HasColumnName("IZIN_KODU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.IzinAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZIN_ADI");
            });

            modelBuilder.Entity<OnyGrpKulTnm>(entity =>
            {
                entity.HasKey(e => new { e.GrpKodu, e.Turu })
                    .HasName("PK_ONY_GRP_KUL_TNM_1");

                entity.ToTable("ONY_GRP_KUL_TNM");

                entity.Property(e => e.GrpKodu).HasColumnName("GRP_KODU");

                entity.Property(e => e.Turu)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TURU");

                entity.Property(e => e.GrpAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRP_ADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<OnyGrpKulVeri>(entity =>
            {
                entity.HasKey(e => new { e.GrpKodu, e.Kladi, e.Turu })
                    .HasName("PK_ONY_GRP_KUL_VERI_1");

                entity.ToTable("ONY_GRP_KUL_VERI");

                entity.Property(e => e.GrpKodu).HasColumnName("GRP_KODU");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Turu)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TURU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(10)
                    .HasColumnName("ACIKLAMA")
                    .IsFixedLength();

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<OnyGrpTanimlar>(entity =>
            {
                entity.HasKey(e => new { e.KulGrupKodu, e.IslemTuru });

                entity.ToTable("ONY_GRP_TANIMLAR");

                entity.Property(e => e.KulGrupKodu).HasColumnName("KUL_GRUP_KODU");

                entity.Property(e => e.IslemTuru)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ISLEM_TURU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.KulGrupAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KUL_GRUP_ADI");

                entity.Property(e => e.TnmGrupAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TNM_GRUP_ADI");

                entity.Property(e => e.TnmGrupKodu).HasColumnName("TNM_GRUP_KODU");
            });

            modelBuilder.Entity<OnyGunizin>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ONY_GUNIZIN");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Bittarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTARIH");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.Isbasi)
                    .HasColumnType("datetime")
                    .HasColumnName("ISBASI");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Onay1).HasColumnName("ONAY1");

                entity.Property(e => e.Onay10).HasColumnName("ONAY10");

                entity.Property(e => e.Onay10kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY10KL");

                entity.Property(e => e.Onay1kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY1KL");

                entity.Property(e => e.Onay2).HasColumnName("ONAY2");

                entity.Property(e => e.Onay2kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY2KL");

                entity.Property(e => e.Onay3).HasColumnName("ONAY3");

                entity.Property(e => e.Onay3kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY3KL");

                entity.Property(e => e.Onay4).HasColumnName("ONAY4");

                entity.Property(e => e.Onay4kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY4KL");

                entity.Property(e => e.Onay5).HasColumnName("ONAY5");

                entity.Property(e => e.Onay5kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY5KL");

                entity.Property(e => e.Onay6).HasColumnName("ONAY6");

                entity.Property(e => e.Onay6kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY6KL");

                entity.Property(e => e.Onay7).HasColumnName("ONAY7");

                entity.Property(e => e.Onay7kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY7KL");

                entity.Property(e => e.Onay8).HasColumnName("ONAY8");

                entity.Property(e => e.Onay8kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY8KL");

                entity.Property(e => e.Onay9).HasColumnName("ONAY9");

                entity.Property(e => e.Onay9kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY9KL");

                entity.Property(e => e.Post).HasColumnName("POST");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Ret)
                    .HasColumnName("RET")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Sebep2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP2");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<OnyGunizinTemp>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Srkodu, e.Prsicil, e.Neden, e.Bastarih });

                entity.ToTable("ONY_GUNIZIN_TEMP");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Bittarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTARIH");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Isbasi)
                    .HasColumnType("datetime")
                    .HasColumnName("ISBASI");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Sebep2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP2");
            });

            modelBuilder.Entity<OnyLog>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ONY_LOG");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Deger)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEGER");

                entity.Property(e => e.Islem)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ISLEM")
                    .HasDefaultValueSql("('INSERT')");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Tablo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TABLO");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OnyLogGunizin>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ONY_LOG_GUNIZIN");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Bittarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTARIH");

                entity.Property(e => e.Derece).HasColumnName("DERECE");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.Isbasi)
                    .HasColumnType("datetime")
                    .HasColumnName("ISBASI");

                entity.Property(e => e.IslemZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLEM_ZAMANI");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Onay).HasColumnName("ONAY");

                entity.Property(e => e.OnyIdno).HasColumnName("ONY_IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Sebep2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP2");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<OnyLogMesai>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ONY_LOG_MESAI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Baszaman)
                    .HasColumnType("datetime")
                    .HasColumnName("BASZAMAN");

                entity.Property(e => e.Bitzaman)
                    .HasColumnType("datetime")
                    .HasColumnName("BITZAMAN");

                entity.Property(e => e.Derece).HasColumnName("DERECE");

                entity.Property(e => e.DonusSaati)
                    .HasColumnType("datetime")
                    .HasColumnName("DONUS_SAATI");

                entity.Property(e => e.DonusServisKullanim).HasColumnName("DONUS_SERVIS_KULLANIM");

                entity.Property(e => e.DonusServisi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DONUS_SERVISI");

                entity.Property(e => e.GelisSaati)
                    .HasColumnType("datetime")
                    .HasColumnName("GELIS_SAATI");

                entity.Property(e => e.GelisServisKullanim).HasColumnName("GELIS_SERVIS_KULLANIM");

                entity.Property(e => e.GelisServisi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GELIS_SERVISI");

                entity.Property(e => e.IslemZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLEM_ZAMANI");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Neden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Onay).HasColumnName("ONAY");

                entity.Property(e => e.OnyIdno).HasColumnName("ONY_IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Yemekyer).HasColumnName("YEMEKYER");
            });

            modelBuilder.Entity<OnyLogMesaiGercek>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ONY_LOG_MESAI_GERCEK");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Derece).HasColumnName("DERECE");

                entity.Property(e => e.Fmkodu).HasColumnName("FMKODU");

                entity.Property(e => e.IslemZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLEM_ZAMANI");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Neden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Onay).HasColumnName("ONAY");

                entity.Property(e => e.OnyIdno).HasColumnName("ONY_IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");
            });

            modelBuilder.Entity<OnyLogSaatizin>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ONY_LOG_SAATIZIN");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Derece).HasColumnName("DERECE");

                entity.Property(e => e.IslemZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLEM_ZAMANI");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Onay).HasColumnName("ONAY");

                entity.Property(e => e.OnyIdno).HasColumnName("ONY_IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Saat)
                    .HasColumnType("datetime")
                    .HasColumnName("SAAT");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Sebep2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP2");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");
            });

            modelBuilder.Entity<OnyLogTaksi>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ONY_LOG_TAKSI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Derece).HasColumnName("DERECE");

                entity.Property(e => e.IslemZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLEM_ZAMANI");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Neden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Onay).HasColumnName("ONAY");

                entity.Property(e => e.OnyIdno).HasColumnName("ONY_IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Ucret).HasColumnName("UCRET");
            });

            modelBuilder.Entity<OnyLogVardiya>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ONY_LOG_VARDIYA");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Derece).HasColumnName("DERECE");

                entity.Property(e => e.IslemZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLEM_ZAMANI");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Onay).HasColumnName("ONAY");

                entity.Property(e => e.OnyIdno).HasColumnName("ONY_IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<OnyMailGrp>(entity =>
            {
                entity.HasKey(e => new { e.ZmnGrp, e.KulGrp });

                entity.ToTable("ONY_MAIL_GRP");

                entity.Property(e => e.ZmnGrp).HasColumnName("ZMN_GRP");

                entity.Property(e => e.KulGrp).HasColumnName("KUL_GRP");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<OnyMailKodlar>(entity =>
            {
                entity.HasKey(e => new { e.Tanim, e.Kodu });

                entity.ToTable("ONY_MAIL_KODLAR");

                entity.Property(e => e.Tanim)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TANIM");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Deger)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<OnyMailKulGrpTnm>(entity =>
            {
                entity.HasKey(e => e.Adi)
                    .HasName("PK_ONY_MAIL_KUL_VERI");

                entity.ToTable("ONY_MAIL_KUL_GRP_TNM");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.No).HasColumnName("NO");
            });

            modelBuilder.Entity<OnyMailKulGrpVeri>(entity =>
            {
                entity.HasKey(e => new { e.No, e.Adi, e.KulIdno, e.KonuIdno, e.MailIdno })
                    .HasName("PK_ONY_MAIL_KUL_GRUP");

                entity.ToTable("ONY_MAIL_KUL_GRP_VERI");

                entity.Property(e => e.No).HasColumnName("NO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.KulIdno).HasColumnName("KUL_IDNO");

                entity.Property(e => e.KonuIdno).HasColumnName("KONU_IDNO");

                entity.Property(e => e.MailIdno).HasColumnName("MAIL_IDNO");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.KonuAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KONU_ADI");

                entity.Property(e => e.KulAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KUL_ADI");

                entity.Property(e => e.MailIcerik)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_ICERIK");
            });

            modelBuilder.Entity<OnyMailListe>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ONY_MAIL_LISTE");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Durum)
                    .HasColumnName("DURUM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Islem)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("ISLEM");

                entity.Property(e => e.KlAdi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("KL_ADI");

                entity.Property(e => e.KlDerece).HasColumnName("KL_DERECE");

                entity.Property(e => e.KlMail)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("KL_MAIL");

                entity.Property(e => e.KlTipi)
                    .HasMaxLength(10)
                    .HasColumnName("KL_TIPI")
                    .IsFixedLength();

                entity.Property(e => e.LogIdno).HasColumnName("LOG_IDNO");

                entity.Property(e => e.Mailtipi)
                    .HasColumnName("MAILTIPI")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Onay).HasColumnName("ONAY");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Sayi)
                    .HasColumnName("SAYI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<OnyMailParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONY_MAIL_PARAM");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HOSTNAME");

                entity.Property(e => e.MailAdresi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_ADRESI");

                entity.Property(e => e.MailKonusu)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_KONUSU");

                entity.Property(e => e.Mailgonder)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAILGONDER");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Portno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PORTNO");

                entity.Property(e => e.SartMail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SART_MAIL");

                entity.Property(e => e.SartOnay)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SART_ONAY");

                entity.Property(e => e.SartRet)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SART_RET");

                entity.Property(e => e.Sayi).HasColumnName("SAYI");

                entity.Property(e => e.Ssl)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SSL");

                entity.Property(e => e.Username)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<OnyMailSartlar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONY_MAIL_SARTLAR");

                entity.Property(e => e.Derece).HasColumnName("DERECE");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Kimler)
                    .HasMaxLength(10)
                    .HasColumnName("KIMLER")
                    .IsFixedLength();

                entity.Property(e => e.Onaylar)
                    .HasMaxLength(10)
                    .HasColumnName("ONAYLAR")
                    .IsFixedLength();

                entity.Property(e => e.Retler)
                    .HasMaxLength(10)
                    .HasColumnName("RETLER")
                    .IsFixedLength();
            });

            modelBuilder.Entity<OnyMailSayi>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ONY_MAIL_SAYI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.IdnoGun)
                    .HasColumnName("IDNO_GUN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdnoMesai)
                    .HasColumnName("IDNO_MESAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdnoMesaiGercek)
                    .HasColumnName("IDNO_MESAI_GERCEK")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdnoSaat)
                    .HasColumnName("IDNO_SAAT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdnoTaksi)
                    .HasColumnName("IDNO_TAKSI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdnoVrd)
                    .HasColumnName("IDNO_VRD")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OnyMailSrvGrp>(entity =>
            {
                entity.HasKey(e => new { e.ZmnNo, e.KulNo });

                entity.ToTable("ONY_MAIL_SRV_GRP");

                entity.Property(e => e.ZmnNo).HasColumnName("ZMN_NO");

                entity.Property(e => e.KulNo).HasColumnName("KUL_NO");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.KulAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KUL_ADI");

                entity.Property(e => e.ZmnAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZMN_ADI");
            });

            modelBuilder.Entity<OnyMailZmnGrpTnm>(entity =>
            {
                entity.HasKey(e => new { e.No, e.Adi })
                    .HasName("PK_ONY_MAIL_ZMN_GRP_TNM_1");

                entity.ToTable("ONY_MAIL_ZMN_GRP_TNM");

                entity.Property(e => e.No).HasColumnName("NO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(10)
                    .HasColumnName("ADI")
                    .IsFixedLength();

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<OnyMailZmnGrpVeri>(entity =>
            {
                entity.HasKey(e => new { e.Adi, e.No, e.ZmnBaslik, e.ZmnTuru, e.ZmnDeger, e.VktTuru, e.VktDeger })
                    .HasName("PK_ONY_MAIL_ZMN_GRUP");

                entity.ToTable("ONY_MAIL_ZMN_GRP_VERI");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.No).HasColumnName("NO");

                entity.Property(e => e.ZmnBaslik)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZMN_BASLIK");

                entity.Property(e => e.ZmnTuru)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZMN_TURU");

                entity.Property(e => e.ZmnDeger)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZMN_DEGER");

                entity.Property(e => e.VktTuru)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VKT_TURU");

                entity.Property(e => e.VktDeger)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VKT_DEGER");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<OnyMesai>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Prsicil, e.Tarih });

                entity.ToTable("ONY_MESAI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Baszaman)
                    .HasColumnType("datetime")
                    .HasColumnName("BASZAMAN");

                entity.Property(e => e.Bitzaman)
                    .HasColumnType("datetime")
                    .HasColumnName("BITZAMAN");

                entity.Property(e => e.DonusSaati)
                    .HasColumnType("datetime")
                    .HasColumnName("DONUS_SAATI");

                entity.Property(e => e.DonusServisKullanim).HasColumnName("DONUS_SERVIS_KULLANIM");

                entity.Property(e => e.DonusServisi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DONUS_SERVISI");

                entity.Property(e => e.GelisSaati)
                    .HasColumnType("datetime")
                    .HasColumnName("GELIS_SAATI");

                entity.Property(e => e.GelisServisKullanim).HasColumnName("GELIS_SERVIS_KULLANIM");

                entity.Property(e => e.GelisServisi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GELIS_SERVISI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Neden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Onay1).HasColumnName("ONAY1");

                entity.Property(e => e.Onay10).HasColumnName("ONAY10");

                entity.Property(e => e.Onay10kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY10KL");

                entity.Property(e => e.Onay1kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY1KL");

                entity.Property(e => e.Onay2).HasColumnName("ONAY2");

                entity.Property(e => e.Onay2kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY2KL");

                entity.Property(e => e.Onay3).HasColumnName("ONAY3");

                entity.Property(e => e.Onay3kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY3KL");

                entity.Property(e => e.Onay4).HasColumnName("ONAY4");

                entity.Property(e => e.Onay4kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY4KL");

                entity.Property(e => e.Onay5).HasColumnName("ONAY5");

                entity.Property(e => e.Onay5kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY5KL");

                entity.Property(e => e.Onay6).HasColumnName("ONAY6");

                entity.Property(e => e.Onay6kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY6KL");

                entity.Property(e => e.Onay7).HasColumnName("ONAY7");

                entity.Property(e => e.Onay7kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY7KL");

                entity.Property(e => e.Onay8).HasColumnName("ONAY8");

                entity.Property(e => e.Onay8kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY8KL");

                entity.Property(e => e.Onay9).HasColumnName("ONAY9");

                entity.Property(e => e.Onay9kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY9KL");

                entity.Property(e => e.Post).HasColumnName("POST");

                entity.Property(e => e.Ret)
                    .HasColumnName("RET")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");

                entity.Property(e => e.Yemekyer).HasColumnName("YEMEKYER");
            });

            modelBuilder.Entity<OnyMesaiGercek>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Prsicil, e.Tarih, e.Fmkodu });

                entity.ToTable("ONY_MESAI_GERCEK");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Fmkodu).HasColumnName("FMKODU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.GlnSure)
                    .HasColumnType("datetime")
                    .HasColumnName("GLN_SURE");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.MesaiTipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MESAI_TIPI")
                    .HasDefaultValueSql("('GERCEK')");

                entity.Property(e => e.Neden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Onay1).HasColumnName("ONAY1");

                entity.Property(e => e.Onay10).HasColumnName("ONAY10");

                entity.Property(e => e.Onay10kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY10KL");

                entity.Property(e => e.Onay1kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY1KL");

                entity.Property(e => e.Onay2).HasColumnName("ONAY2");

                entity.Property(e => e.Onay2kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY2KL");

                entity.Property(e => e.Onay3).HasColumnName("ONAY3");

                entity.Property(e => e.Onay3kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY3KL");

                entity.Property(e => e.Onay4).HasColumnName("ONAY4");

                entity.Property(e => e.Onay4kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY4KL");

                entity.Property(e => e.Onay5).HasColumnName("ONAY5");

                entity.Property(e => e.Onay5kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY5KL");

                entity.Property(e => e.Onay6).HasColumnName("ONAY6");

                entity.Property(e => e.Onay6kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY6KL");

                entity.Property(e => e.Onay7).HasColumnName("ONAY7");

                entity.Property(e => e.Onay7kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY7KL");

                entity.Property(e => e.Onay8).HasColumnName("ONAY8");

                entity.Property(e => e.Onay8kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY8KL");

                entity.Property(e => e.Onay9).HasColumnName("ONAY9");

                entity.Property(e => e.Onay9kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY9KL");

                entity.Property(e => e.OnySure)
                    .HasColumnType("datetime")
                    .HasColumnName("ONY_SURE");

                entity.Property(e => e.Post)
                    .HasColumnName("POST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ret)
                    .HasColumnName("RET")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OnyMesaiGercekTemp>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Prsicil, e.Tarih, e.Fmkodu });

                entity.ToTable("ONY_MESAI_GERCEK_TEMP");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Fmkodu).HasColumnName("FMKODU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.GlnSure)
                    .HasColumnType("datetime")
                    .HasColumnName("GLN_SURE");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Neden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.OnySure)
                    .HasColumnType("datetime")
                    .HasColumnName("ONY_SURE");
            });

            modelBuilder.Entity<OnyMesaiTemp>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Srkodu, e.Prsicil, e.Tarih });

                entity.ToTable("ONY_MESAI_TEMP");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Bittarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTARIH");

                entity.Property(e => e.DonusSaati)
                    .HasColumnType("datetime")
                    .HasColumnName("DONUS_SAATI");

                entity.Property(e => e.DonusServisKullanim).HasColumnName("DONUS_SERVIS_KULLANIM");

                entity.Property(e => e.DonusServisi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DONUS_SERVISI");

                entity.Property(e => e.GelisSaati)
                    .HasColumnType("datetime")
                    .HasColumnName("GELIS_SAATI");

                entity.Property(e => e.GelisServisKullanim).HasColumnName("GELIS_SERVIS_KULLANIM");

                entity.Property(e => e.GelisServisi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GELIS_SERVISI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Neden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");

                entity.Property(e => e.Yemekyer).HasColumnName("YEMEKYER");
            });

            modelBuilder.Entity<OnyParametre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONY_PARAMETRE");

                entity.Property(e => e.FmBaslamaBitis)
                    .HasColumnName("FM_BASLAMA_BITIS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FmOnay).HasColumnName("FM_ONAY");

                entity.Property(e => e.FmOnayDegisiklik).HasColumnName("FM_ONAY_DEGISIKLIK");

                entity.Property(e => e.FmYemekyer)
                    .HasColumnName("FM_YEMEKYER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GunlukIzinOnay).HasColumnName("GUNLUK_IZIN_ONAY");

                entity.Property(e => e.GunlukIzinOnayDegisiklik).HasColumnName("GUNLUK_IZIN_ONAY_DEGISIKLIK");

                entity.Property(e => e.HareketOnay).HasColumnName("HAREKET_ONAY");

                entity.Property(e => e.HareketOnayDegisiklik).HasColumnName("HAREKET_ONAY_DEGISIKLIK");

                entity.Property(e => e.IzinliKisiLimiti).HasColumnName("IZINLI_KISI_LIMITI");

                entity.Property(e => e.IzinliKisiSayisiKontrolu).HasColumnName("IZINLI_KISI_SAYISI_KONTROLU");

                entity.Property(e => e.MesaiOnayModu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MESAI_ONAY_MODU");

                entity.Property(e => e.OnaySiralama).HasColumnName("ONAY_SIRALAMA");

                entity.Property(e => e.PersonelBazliCalisma).HasColumnName("PERSONEL_BAZLI_CALISMA");

                entity.Property(e => e.ProtokolKullanim).HasColumnName("PROTOKOL_KULLANIM");

                entity.Property(e => e.SaatlikIzinOnay).HasColumnName("SAATLIK_IZIN_ONAY");

                entity.Property(e => e.SaatlikIzinOnayDegisiklik).HasColumnName("SAATLIK_IZIN_ONAY_DEGISIKLIK");

                entity.Property(e => e.ServisPlanlama).HasColumnName("SERVIS_PLANLAMA");

                entity.Property(e => e.TaksiUcretiOnay).HasColumnName("TAKSI_UCRETI_ONAY");

                entity.Property(e => e.TaksiUcretiOnayDegisiklik).HasColumnName("TAKSI_UCRETI_ONAY_DEGISIKLIK");

                entity.Property(e => e.VadiyaOnayDegisiklik).HasColumnName("VADIYA_ONAY_DEGISIKLIK");

                entity.Property(e => e.VardiyaOnay).HasColumnName("VARDIYA_ONAY");

                entity.Property(e => e.YmkModulDurumu).HasColumnName("YMK_MODUL_DURUMU");
            });

            modelBuilder.Entity<OnyPersonelProtokol>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Prsicil })
                    .HasName("PK_PERSONEL_PROTOKOL");

                entity.ToTable("ONY_PERSONEL_PROTOKOL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.ProtokolBasimZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("PROTOKOL_BASIM_ZAMANI");

                entity.Property(e => e.ProtokolDurumu).HasColumnName("PROTOKOL_DURUMU");

                entity.Property(e => e.ProtokolOnayZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("PROTOKOL_ONAY_ZAMANI");
            });

            modelBuilder.Entity<OnySaatizin>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Prsicil, e.Tarih });

                entity.ToTable("ONY_SAATIZIN");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Onay1).HasColumnName("ONAY1");

                entity.Property(e => e.Onay10).HasColumnName("ONAY10");

                entity.Property(e => e.Onay10kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY10KL");

                entity.Property(e => e.Onay1kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY1KL");

                entity.Property(e => e.Onay2).HasColumnName("ONAY2");

                entity.Property(e => e.Onay2kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY2KL");

                entity.Property(e => e.Onay3).HasColumnName("ONAY3");

                entity.Property(e => e.Onay3kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY3KL");

                entity.Property(e => e.Onay4).HasColumnName("ONAY4");

                entity.Property(e => e.Onay4kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY4KL");

                entity.Property(e => e.Onay5).HasColumnName("ONAY5");

                entity.Property(e => e.Onay5kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY5KL");

                entity.Property(e => e.Onay6).HasColumnName("ONAY6");

                entity.Property(e => e.Onay6kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY6KL");

                entity.Property(e => e.Onay7).HasColumnName("ONAY7");

                entity.Property(e => e.Onay7kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY7KL");

                entity.Property(e => e.Onay8).HasColumnName("ONAY8");

                entity.Property(e => e.Onay8kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY8KL");

                entity.Property(e => e.Onay9).HasColumnName("ONAY9");

                entity.Property(e => e.Onay9kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY9KL");

                entity.Property(e => e.Post).HasColumnName("POST");

                entity.Property(e => e.Ret)
                    .HasColumnName("RET")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Saat)
                    .HasColumnType("datetime")
                    .HasColumnName("SAAT");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Sebep2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP2");
            });

            modelBuilder.Entity<OnySaatizinTemp>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Srkodu, e.Prsicil, e.Neden, e.Tarih });

                entity.ToTable("ONY_SAATIZIN_TEMP");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Saat)
                    .HasColumnType("datetime")
                    .HasColumnName("SAAT");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Sebep2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP2");
            });

            modelBuilder.Entity<OnyTaksi>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Prsicil, e.Tarih, e.Fmkodu });

                entity.ToTable("ONY_TAKSI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Fmkodu).HasColumnName("FMKODU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.GlnSure)
                    .HasColumnType("datetime")
                    .HasColumnName("GLN_SURE");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Neden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Onay1).HasColumnName("ONAY1");

                entity.Property(e => e.Onay10).HasColumnName("ONAY10");

                entity.Property(e => e.Onay10kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY10KL");

                entity.Property(e => e.Onay1kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY1KL");

                entity.Property(e => e.Onay2).HasColumnName("ONAY2");

                entity.Property(e => e.Onay2kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY2KL");

                entity.Property(e => e.Onay3).HasColumnName("ONAY3");

                entity.Property(e => e.Onay3kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY3KL");

                entity.Property(e => e.Onay4).HasColumnName("ONAY4");

                entity.Property(e => e.Onay4kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY4KL");

                entity.Property(e => e.Onay5).HasColumnName("ONAY5");

                entity.Property(e => e.Onay5kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY5KL");

                entity.Property(e => e.Onay6).HasColumnName("ONAY6");

                entity.Property(e => e.Onay6kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY6KL");

                entity.Property(e => e.Onay7).HasColumnName("ONAY7");

                entity.Property(e => e.Onay7kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY7KL");

                entity.Property(e => e.Onay8).HasColumnName("ONAY8");

                entity.Property(e => e.Onay8kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY8KL");

                entity.Property(e => e.Onay9).HasColumnName("ONAY9");

                entity.Property(e => e.Onay9kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY9KL");

                entity.Property(e => e.Post)
                    .HasColumnName("POST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ret)
                    .HasColumnName("RET")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sure).HasColumnName("SURE");

                entity.Property(e => e.Ucret).HasColumnName("UCRET");
            });

            modelBuilder.Entity<OnyTaksiTemp>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Prsicil, e.Tarih, e.Fmkodu });

                entity.ToTable("ONY_TAKSI_TEMP");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Fmkodu).HasColumnName("FMKODU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.GlnSure)
                    .HasColumnType("datetime")
                    .HasColumnName("GLN_SURE");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Neden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Sure).HasColumnName("SURE");

                entity.Property(e => e.Ucret).HasColumnName("UCRET");
            });

            modelBuilder.Entity<OnyVardiya>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ONY_VARDIYA");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Onay1).HasColumnName("ONAY1");

                entity.Property(e => e.Onay10).HasColumnName("ONAY10");

                entity.Property(e => e.Onay10kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY10KL");

                entity.Property(e => e.Onay1kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY1KL");

                entity.Property(e => e.Onay2).HasColumnName("ONAY2");

                entity.Property(e => e.Onay2kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY2KL");

                entity.Property(e => e.Onay3).HasColumnName("ONAY3");

                entity.Property(e => e.Onay3kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY3KL");

                entity.Property(e => e.Onay4).HasColumnName("ONAY4");

                entity.Property(e => e.Onay4kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY4KL");

                entity.Property(e => e.Onay5).HasColumnName("ONAY5");

                entity.Property(e => e.Onay5kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY5KL");

                entity.Property(e => e.Onay6).HasColumnName("ONAY6");

                entity.Property(e => e.Onay6kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY6KL");

                entity.Property(e => e.Onay7).HasColumnName("ONAY7");

                entity.Property(e => e.Onay7kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY7KL");

                entity.Property(e => e.Onay8).HasColumnName("ONAY8");

                entity.Property(e => e.Onay8kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY8KL");

                entity.Property(e => e.Onay9).HasColumnName("ONAY9");

                entity.Property(e => e.Onay9kl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY9KL");

                entity.Property(e => e.Post)
                    .HasColumnName("POST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<OnyVardiyaTemp>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("ONY_VARDIYA_TEMP");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<OnyVekalet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONY_VEKALET");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Bittarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTARIH");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Isim)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ISIM");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Vekiladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VEKILADI");

                entity.Property(e => e.Vekilisim)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VEKILISIM");
            });

            modelBuilder.Entity<OnyYemekTanim>(entity =>
            {
                entity.HasKey(e => e.Idno)
                    .HasName("PK_ONY_YEMEK_TANIM_1");

                entity.ToTable("ONY_YEMEK_TANIM");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");
            });

            modelBuilder.Entity<OnyZyrYmkTnm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONY_ZYR_YMK_TNM");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.YmkKodu).HasColumnName("YMK_KODU");

                entity.Property(e => e.ZySicil).HasColumnName("ZY_SICIL");
            });

            modelBuilder.Entity<Oteleme>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Pertip, e.Clkodu });

                entity.ToTable("OTELEME");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Pertip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Cmt)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CMT")
                    .IsFixedLength();

                entity.Property(e => e.Gtatil)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("GTATIL")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Htatil)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HTATIL")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");
            });

            modelBuilder.Entity<OtomailRpdisardum>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("OTOMAIL_RPDISARDA");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Adadadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADADADI");

                entity.Property(e => e.Csturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CSTURU");

                entity.Property(e => e.Dpadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPADI");

                entity.Property(e => e.Grturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRTURU");

                entity.Property(e => e.Hrgckodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HRGCKODU");

                entity.Property(e => e.Hrtarih)
                    .HasColumnType("datetime")
                    .HasColumnName("HRTARIH");

                entity.Property(e => e.Hrtermkodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HRTERMKODU");

                entity.Property(e => e.Hrzaman)
                    .HasColumnType("datetime")
                    .HasColumnName("HRZAMAN");

                entity.Property(e => e.Kdturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KDTURU");

                entity.Property(e => e.Mmturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MMTURU");

                entity.Property(e => e.Msturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSTURU");

                entity.Property(e => e.Pradi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRADI");

                entity.Property(e => e.Praltdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRALTDEPART");

                entity.Property(e => e.Praltdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRALTDEPTAR");

                entity.Property(e => e.Prcikndn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRCIKNDN");

                entity.Property(e => e.Prdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRDEPART");

                entity.Property(e => e.Prdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRDEPTAR");

                entity.Property(e => e.Prgmyaka)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGMYAKA");

                entity.Property(e => e.Prgorev)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGOREV");

                entity.Property(e => e.Priscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISCIKT");

                entity.Property(e => e.Prisgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISGIRT");

                entity.Property(e => e.Prkadro)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRKADRO");

                entity.Property(e => e.Prkartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRKARTNO");

                entity.Property(e => e.Prkod1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD1");

                entity.Property(e => e.Prkod2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD2");

                entity.Property(e => e.Prkrttar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRKRTTAR");

                entity.Property(e => e.Prmasraf)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMASRAF");

                entity.Property(e => e.Prmasraftar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRMASRAFTAR");

                entity.Property(e => e.Prmesai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRMESAI");

                entity.Property(e => e.Prmeslek)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMESLEK");

                entity.Property(e => e.Prpertip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRPERTIP");

                entity.Property(e => e.Prposta).HasColumnName("PRPOSTA");

                entity.Property(e => e.Prpostar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRPOSTAR");

                entity.Property(e => e.Prpuantb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRPUANTB");

                entity.Property(e => e.Prservis)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRSERVIS");

                entity.Property(e => e.Prsicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICILNO");

                entity.Property(e => e.Prsoyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRSOYADI");

                entity.Property(e => e.Prtpgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRTPGIRT");

                entity.Property(e => e.Psadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSADI");

                entity.Property(e => e.Ptturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PTTURU");

                entity.Property(e => e.Srturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SRTURU");
            });

            modelBuilder.Entity<OtomailRpeksikhar>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("OTOMAIL_RPEKSIKHAR");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Adadadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADADADI");

                entity.Property(e => e.Cikis)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CIKIS");

                entity.Property(e => e.Ciktarih)
                    .HasColumnType("datetime")
                    .HasColumnName("CIKTARIH");

                entity.Property(e => e.Cikzaman)
                    .HasColumnType("datetime")
                    .HasColumnName("CIKZAMAN");

                entity.Property(e => e.Csturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CSTURU");

                entity.Property(e => e.Ctermkodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CTERMKODU");

                entity.Property(e => e.Dpadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPADI");

                entity.Property(e => e.Giris)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GIRIS");

                entity.Property(e => e.Girtarih)
                    .HasColumnType("datetime")
                    .HasColumnName("GIRTARIH");

                entity.Property(e => e.Girzaman)
                    .HasColumnType("datetime")
                    .HasColumnName("GIRZAMAN");

                entity.Property(e => e.Grturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRTURU");

                entity.Property(e => e.Gtermkodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GTERMKODU");

                entity.Property(e => e.Kdturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KDTURU");

                entity.Property(e => e.Mmturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MMTURU");

                entity.Property(e => e.Msturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSTURU");

                entity.Property(e => e.Pradi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRADI");

                entity.Property(e => e.Praltdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRALTDEPART");

                entity.Property(e => e.Praltdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRALTDEPTAR");

                entity.Property(e => e.Prcikndn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRCIKNDN");

                entity.Property(e => e.Prdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRDEPART");

                entity.Property(e => e.Prdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRDEPTAR");

                entity.Property(e => e.Prgmyaka)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGMYAKA");

                entity.Property(e => e.Prgorev)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGOREV");

                entity.Property(e => e.Priscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISCIKT");

                entity.Property(e => e.Prisgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISGIRT");

                entity.Property(e => e.Prkadro)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRKADRO");

                entity.Property(e => e.Prkartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRKARTNO");

                entity.Property(e => e.Prkod1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD1");

                entity.Property(e => e.Prkod2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD2");

                entity.Property(e => e.Prkrttar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRKRTTAR");

                entity.Property(e => e.Prmasraf)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMASRAF");

                entity.Property(e => e.Prmasraftar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRMASRAFTAR");

                entity.Property(e => e.Prmesai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRMESAI");

                entity.Property(e => e.Prmeslek)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMESLEK");

                entity.Property(e => e.Prpertip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRPERTIP");

                entity.Property(e => e.Prposta).HasColumnName("PRPOSTA");

                entity.Property(e => e.Prpostar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRPOSTAR");

                entity.Property(e => e.Prpuantb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRPUANTB");

                entity.Property(e => e.Prservis)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRSERVIS");

                entity.Property(e => e.Prsicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICILNO");

                entity.Property(e => e.Prsoyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRSOYADI");

                entity.Property(e => e.Prtpgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRTPGIRT");

                entity.Property(e => e.Psadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSADI");

                entity.Property(e => e.Ptturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PTTURU");

                entity.Property(e => e.Srturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SRTURU");
            });

            modelBuilder.Entity<OtomailRpgecerken>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("OTOMAIL_RPGECERKEN");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Adadadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADADADI");

                entity.Property(e => e.Cikkapi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIKKAPI");

                entity.Property(e => e.Ciktarih)
                    .HasColumnType("datetime")
                    .HasColumnName("CIKTARIH");

                entity.Property(e => e.Cikzaman)
                    .HasColumnType("datetime")
                    .HasColumnName("CIKZAMAN");

                entity.Property(e => e.Csturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CSTURU");

                entity.Property(e => e.Dpadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPADI");

                entity.Property(e => e.Gckodu1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GCKODU1");

                entity.Property(e => e.Gckodu2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GCKODU2");

                entity.Property(e => e.Girkapi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GIRKAPI");

                entity.Property(e => e.Girtarih)
                    .HasColumnType("datetime")
                    .HasColumnName("GIRTARIH");

                entity.Property(e => e.Girzaman)
                    .HasColumnType("datetime")
                    .HasColumnName("GIRZAMAN");

                entity.Property(e => e.Grturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRTURU");

                entity.Property(e => e.Kdturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KDTURU");

                entity.Property(e => e.Mmturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MMTURU");

                entity.Property(e => e.Msturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSTURU");

                entity.Property(e => e.Pradi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRADI");

                entity.Property(e => e.Praltdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRALTDEPART");

                entity.Property(e => e.Praltdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRALTDEPTAR");

                entity.Property(e => e.Prcikndn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRCIKNDN");

                entity.Property(e => e.Prdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRDEPART");

                entity.Property(e => e.Prdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRDEPTAR");

                entity.Property(e => e.Prgmyaka)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGMYAKA");

                entity.Property(e => e.Prgorev)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGOREV");

                entity.Property(e => e.Priscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISCIKT");

                entity.Property(e => e.Prisgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISGIRT");

                entity.Property(e => e.Prkadro)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRKADRO");

                entity.Property(e => e.Prkartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRKARTNO");

                entity.Property(e => e.Prkod1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD1");

                entity.Property(e => e.Prkod2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD2");

                entity.Property(e => e.Prkrttar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRKRTTAR");

                entity.Property(e => e.Prmasraf)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMASRAF");

                entity.Property(e => e.Prmasraftar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRMASRAFTAR");

                entity.Property(e => e.Prmesai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRMESAI");

                entity.Property(e => e.Prmeslek)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMESLEK");

                entity.Property(e => e.Prpertip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRPERTIP");

                entity.Property(e => e.Prposta).HasColumnName("PRPOSTA");

                entity.Property(e => e.Prpostar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRPOSTAR");

                entity.Property(e => e.Prpuantb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRPUANTB");

                entity.Property(e => e.Prservis)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRSERVIS");

                entity.Property(e => e.Prsicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICILNO");

                entity.Property(e => e.Prsoyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRSOYADI");

                entity.Property(e => e.Prtpgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRTPGIRT");

                entity.Property(e => e.Psadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSADI");

                entity.Property(e => e.Ptturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PTTURU");

                entity.Property(e => e.Srturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SRTURU");

                entity.Property(e => e.Vradi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VRADI");

                entity.Property(e => e.Vrkodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VRKODU");
            });

            modelBuilder.Entity<OtomailRpgelmeyen>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("OTOMAIL_RPGELMEYEN");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Adadadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADADADI");

                entity.Property(e => e.Csturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CSTURU");

                entity.Property(e => e.Dpadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPADI");

                entity.Property(e => e.Grturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRTURU");

                entity.Property(e => e.Izkodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IZKODU");

                entity.Property(e => e.Izturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZTURU");

                entity.Property(e => e.Kdturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KDTURU");

                entity.Property(e => e.Mmturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MMTURU");

                entity.Property(e => e.Msturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSTURU");

                entity.Property(e => e.Pradi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRADI");

                entity.Property(e => e.Praltdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRALTDEPART");

                entity.Property(e => e.Praltdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRALTDEPTAR");

                entity.Property(e => e.Prcikndn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRCIKNDN");

                entity.Property(e => e.Prdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRDEPART");

                entity.Property(e => e.Prdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRDEPTAR");

                entity.Property(e => e.Prgmyaka)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGMYAKA");

                entity.Property(e => e.Prgorev)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGOREV");

                entity.Property(e => e.Priscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISCIKT");

                entity.Property(e => e.Prisgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISGIRT");

                entity.Property(e => e.Prkadro)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRKADRO");

                entity.Property(e => e.Prkartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRKARTNO");

                entity.Property(e => e.Prkod1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD1");

                entity.Property(e => e.Prkod2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD2");

                entity.Property(e => e.Prkrttar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRKRTTAR");

                entity.Property(e => e.Prmasraf)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMASRAF");

                entity.Property(e => e.Prmasraftar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRMASRAFTAR");

                entity.Property(e => e.Prmesai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRMESAI");

                entity.Property(e => e.Prmeslek)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMESLEK");

                entity.Property(e => e.Prpertip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRPERTIP");

                entity.Property(e => e.Prposta).HasColumnName("PRPOSTA");

                entity.Property(e => e.Prpostar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRPOSTAR");

                entity.Property(e => e.Prpuantb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRPUANTB");

                entity.Property(e => e.Prservis)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRSERVIS");

                entity.Property(e => e.Prsicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICILNO");

                entity.Property(e => e.Prsoyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRSOYADI");

                entity.Property(e => e.Prtpgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRTPGIRT");

                entity.Property(e => e.Psadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSADI");

                entity.Property(e => e.Ptturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PTTURU");

                entity.Property(e => e.Srturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SRTURU");

                entity.Property(e => e.Tkposta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TKPOSTA");

                entity.Property(e => e.Tkpostar)
                    .HasColumnType("datetime")
                    .HasColumnName("TKPOSTAR");
            });

            modelBuilder.Entity<OtomailRpgirisciki>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("OTOMAIL_RPGIRISCIKIS");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Adadadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADADADI");

                entity.Property(e => e.Ckapi1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI1");

                entity.Property(e => e.Ckapi10)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI10");

                entity.Property(e => e.Ckapi11)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI11");

                entity.Property(e => e.Ckapi12)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI12");

                entity.Property(e => e.Ckapi13)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI13");

                entity.Property(e => e.Ckapi14)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI14");

                entity.Property(e => e.Ckapi15)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI15");

                entity.Property(e => e.Ckapi2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI2");

                entity.Property(e => e.Ckapi3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI3");

                entity.Property(e => e.Ckapi4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI4");

                entity.Property(e => e.Ckapi5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI5");

                entity.Property(e => e.Ckapi6)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI6");

                entity.Property(e => e.Ckapi7)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI7");

                entity.Property(e => e.Ckapi8)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI8");

                entity.Property(e => e.Ckapi9)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CKAPI9");

                entity.Property(e => e.Cneden1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN1");

                entity.Property(e => e.Cneden10)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN10");

                entity.Property(e => e.Cneden11)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN11");

                entity.Property(e => e.Cneden12)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN12");

                entity.Property(e => e.Cneden13)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN13");

                entity.Property(e => e.Cneden14)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN14");

                entity.Property(e => e.Cneden15)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN15");

                entity.Property(e => e.Cneden2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN2");

                entity.Property(e => e.Cneden3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN3");

                entity.Property(e => e.Cneden4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN4");

                entity.Property(e => e.Cneden5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN5");

                entity.Property(e => e.Cneden6)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN6");

                entity.Property(e => e.Cneden7)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN7");

                entity.Property(e => e.Cneden8)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN8");

                entity.Property(e => e.Cneden9)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNEDEN9");

                entity.Property(e => e.Csturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CSTURU");

                entity.Property(e => e.Ctarih1)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH1");

                entity.Property(e => e.Ctarih10)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH10");

                entity.Property(e => e.Ctarih11)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH11");

                entity.Property(e => e.Ctarih12)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH12");

                entity.Property(e => e.Ctarih13)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH13");

                entity.Property(e => e.Ctarih14)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH14");

                entity.Property(e => e.Ctarih15)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH15");

                entity.Property(e => e.Ctarih2)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH2");

                entity.Property(e => e.Ctarih3)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH3");

                entity.Property(e => e.Ctarih4)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH4");

                entity.Property(e => e.Ctarih5)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH5");

                entity.Property(e => e.Ctarih6)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH6");

                entity.Property(e => e.Ctarih7)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH7");

                entity.Property(e => e.Ctarih8)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH8");

                entity.Property(e => e.Ctarih9)
                    .HasColumnType("datetime")
                    .HasColumnName("CTARIH9");

                entity.Property(e => e.Czaman1)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN1");

                entity.Property(e => e.Czaman10)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN10");

                entity.Property(e => e.Czaman11)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN11");

                entity.Property(e => e.Czaman12)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN12");

                entity.Property(e => e.Czaman13)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN13");

                entity.Property(e => e.Czaman14)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN14");

                entity.Property(e => e.Czaman15)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN15");

                entity.Property(e => e.Czaman2)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN2");

                entity.Property(e => e.Czaman3)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN3");

                entity.Property(e => e.Czaman4)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN4");

                entity.Property(e => e.Czaman5)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN5");

                entity.Property(e => e.Czaman6)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN6");

                entity.Property(e => e.Czaman7)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN7");

                entity.Property(e => e.Czaman8)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN8");

                entity.Property(e => e.Czaman9)
                    .HasColumnType("datetime")
                    .HasColumnName("CZAMAN9");

                entity.Property(e => e.Dpadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPADI");

                entity.Property(e => e.Erkensure)
                    .HasColumnType("datetime")
                    .HasColumnName("ERKENSURE");

                entity.Property(e => e.Fark)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FARK");

                entity.Property(e => e.Gecsure)
                    .HasColumnType("datetime")
                    .HasColumnName("GECSURE");

                entity.Property(e => e.Gkapi1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI1");

                entity.Property(e => e.Gkapi10)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI10");

                entity.Property(e => e.Gkapi11)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI11");

                entity.Property(e => e.Gkapi12)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI12");

                entity.Property(e => e.Gkapi13)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI13");

                entity.Property(e => e.Gkapi14)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI14");

                entity.Property(e => e.Gkapi15)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI15");

                entity.Property(e => e.Gkapi2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI2");

                entity.Property(e => e.Gkapi3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI3");

                entity.Property(e => e.Gkapi4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI4");

                entity.Property(e => e.Gkapi5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI5");

                entity.Property(e => e.Gkapi6)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI6");

                entity.Property(e => e.Gkapi7)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI7");

                entity.Property(e => e.Gkapi8)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI8");

                entity.Property(e => e.Gkapi9)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GKAPI9");

                entity.Property(e => e.Gneden1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN1");

                entity.Property(e => e.Gneden10)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN10");

                entity.Property(e => e.Gneden11)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN11");

                entity.Property(e => e.Gneden12)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN12");

                entity.Property(e => e.Gneden13)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN13");

                entity.Property(e => e.Gneden14)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN14");

                entity.Property(e => e.Gneden15)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN15");

                entity.Property(e => e.Gneden2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN2");

                entity.Property(e => e.Gneden3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN3");

                entity.Property(e => e.Gneden4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN4");

                entity.Property(e => e.Gneden5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN5");

                entity.Property(e => e.Gneden6)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN6");

                entity.Property(e => e.Gneden7)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN7");

                entity.Property(e => e.Gneden8)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN8");

                entity.Property(e => e.Gneden9)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNEDEN9");

                entity.Property(e => e.Grturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRTURU");

                entity.Property(e => e.Gtarih1)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH1");

                entity.Property(e => e.Gtarih10)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH10");

                entity.Property(e => e.Gtarih11)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH11");

                entity.Property(e => e.Gtarih12)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH12");

                entity.Property(e => e.Gtarih13)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH13");

                entity.Property(e => e.Gtarih14)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH14");

                entity.Property(e => e.Gtarih15)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH15");

                entity.Property(e => e.Gtarih2)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH2");

                entity.Property(e => e.Gtarih3)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH3");

                entity.Property(e => e.Gtarih4)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH4");

                entity.Property(e => e.Gtarih5)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH5");

                entity.Property(e => e.Gtarih6)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH6");

                entity.Property(e => e.Gtarih7)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH7");

                entity.Property(e => e.Gtarih8)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH8");

                entity.Property(e => e.Gtarih9)
                    .HasColumnType("datetime")
                    .HasColumnName("GTARIH9");

                entity.Property(e => e.Gzaman1)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN1");

                entity.Property(e => e.Gzaman10)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN10");

                entity.Property(e => e.Gzaman11)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN11");

                entity.Property(e => e.Gzaman12)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN12");

                entity.Property(e => e.Gzaman13)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN13");

                entity.Property(e => e.Gzaman14)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN14");

                entity.Property(e => e.Gzaman15)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN15");

                entity.Property(e => e.Gzaman2)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN2");

                entity.Property(e => e.Gzaman3)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN3");

                entity.Property(e => e.Gzaman4)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN4");

                entity.Property(e => e.Gzaman5)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN5");

                entity.Property(e => e.Gzaman6)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN6");

                entity.Property(e => e.Gzaman7)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN7");

                entity.Property(e => e.Gzaman8)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN8");

                entity.Property(e => e.Gzaman9)
                    .HasColumnType("datetime")
                    .HasColumnName("GZAMAN9");

                entity.Property(e => e.Kdturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KDTURU");

                entity.Property(e => e.Mmturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MMTURU");

                entity.Property(e => e.Msturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSTURU");

                entity.Property(e => e.Pradi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRADI");

                entity.Property(e => e.Praltdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRALTDEPART");

                entity.Property(e => e.Praltdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRALTDEPTAR");

                entity.Property(e => e.Prcikndn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRCIKNDN");

                entity.Property(e => e.Prdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRDEPART");

                entity.Property(e => e.Prdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRDEPTAR");

                entity.Property(e => e.Prgmyaka)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGMYAKA");

                entity.Property(e => e.Prgorev)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGOREV");

                entity.Property(e => e.Priscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISCIKT");

                entity.Property(e => e.Prisgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISGIRT");

                entity.Property(e => e.Prkadro)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRKADRO");

                entity.Property(e => e.Prkartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRKARTNO");

                entity.Property(e => e.Prkod1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD1");

                entity.Property(e => e.Prkod2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD2");

                entity.Property(e => e.Prkrttar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRKRTTAR");

                entity.Property(e => e.Prmasraf)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMASRAF");

                entity.Property(e => e.Prmasraftar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRMASRAFTAR");

                entity.Property(e => e.Prmesai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRMESAI");

                entity.Property(e => e.Prmeslek)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMESLEK");

                entity.Property(e => e.Prpertip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRPERTIP");

                entity.Property(e => e.Prposta).HasColumnName("PRPOSTA");

                entity.Property(e => e.Prpostar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRPOSTAR");

                entity.Property(e => e.Prpuantb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRPUANTB");

                entity.Property(e => e.Prservis)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRSERVIS");

                entity.Property(e => e.Prsicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICILNO");

                entity.Property(e => e.Prsoyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRSOYADI");

                entity.Property(e => e.Prtpgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRTPGIRT");

                entity.Property(e => e.Psadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSADI");

                entity.Property(e => e.Ptturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PTTURU");

                entity.Property(e => e.Srkodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SRKODU");

                entity.Property(e => e.Srturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SRTURU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<OtomailRpgunizin>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("OTOMAIL_RPGUNIZIN");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Adadadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADADADI");

                entity.Property(e => e.Cladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLADI");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Csturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CSTURU");

                entity.Property(e => e.Dpadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPADI");

                entity.Property(e => e.Gibastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("GIBASTARIH");

                entity.Property(e => e.Gibittarih)
                    .HasColumnType("datetime")
                    .HasColumnName("GIBITTARIH");

                entity.Property(e => e.Gigun).HasColumnName("GIGUN");

                entity.Property(e => e.Gisebep)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GISEBEP");

                entity.Property(e => e.Grturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRTURU");

                entity.Property(e => e.Kdturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KDTURU");

                entity.Property(e => e.Mmturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MMTURU");

                entity.Property(e => e.Msturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSTURU");

                entity.Property(e => e.Nnturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NNTURU");

                entity.Property(e => e.Pradi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRADI");

                entity.Property(e => e.Praltdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRALTDEPART");

                entity.Property(e => e.Praltdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRALTDEPTAR");

                entity.Property(e => e.Prcikndn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRCIKNDN");

                entity.Property(e => e.Prdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRDEPART");

                entity.Property(e => e.Prdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRDEPTAR");

                entity.Property(e => e.Prgmyaka)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGMYAKA");

                entity.Property(e => e.Prgorev)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGOREV");

                entity.Property(e => e.Priscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISCIKT");

                entity.Property(e => e.Prisgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISGIRT");

                entity.Property(e => e.Prkadro)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRKADRO");

                entity.Property(e => e.Prkartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRKARTNO");

                entity.Property(e => e.Prkod1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD1");

                entity.Property(e => e.Prkod2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD2");

                entity.Property(e => e.Prkrttar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRKRTTAR");

                entity.Property(e => e.Prmasraf)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMASRAF");

                entity.Property(e => e.Prmasraftar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRMASRAFTAR");

                entity.Property(e => e.Prmesai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRMESAI");

                entity.Property(e => e.Prmeslek)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMESLEK");

                entity.Property(e => e.Prpertip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRPERTIP");

                entity.Property(e => e.Prposta).HasColumnName("PRPOSTA");

                entity.Property(e => e.Prpostar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRPOSTAR");

                entity.Property(e => e.Prpuantb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRPUANTB");

                entity.Property(e => e.Prservis)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRSERVIS");

                entity.Property(e => e.Prsicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICILNO");

                entity.Property(e => e.Prsoyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRSOYADI");

                entity.Property(e => e.Prtpgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRTPGIRT");

                entity.Property(e => e.Psadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSADI");

                entity.Property(e => e.Ptturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PTTURU");

                entity.Property(e => e.Srturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SRTURU");
            });

            modelBuilder.Entity<OtomailRpicerde>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("OTOMAIL_RPICERDE");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Adadadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADADADI");

                entity.Property(e => e.Csturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CSTURU");

                entity.Property(e => e.Dpadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPADI");

                entity.Property(e => e.Grturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRTURU");

                entity.Property(e => e.Hrgckodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HRGCKODU");

                entity.Property(e => e.Hrtarih)
                    .HasColumnType("datetime")
                    .HasColumnName("HRTARIH");

                entity.Property(e => e.Hrtermkodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HRTERMKODU");

                entity.Property(e => e.Hrzaman)
                    .HasColumnType("datetime")
                    .HasColumnName("HRZAMAN");

                entity.Property(e => e.K1kangrb)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("K1KANGRB");

                entity.Property(e => e.Kdturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KDTURU");

                entity.Property(e => e.Mmturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MMTURU");

                entity.Property(e => e.Msturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSTURU");

                entity.Property(e => e.Pradi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRADI");

                entity.Property(e => e.Praltdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRALTDEPART");

                entity.Property(e => e.Praltdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRALTDEPTAR");

                entity.Property(e => e.Prcikndn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRCIKNDN");

                entity.Property(e => e.Prdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRDEPART");

                entity.Property(e => e.Prdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRDEPTAR");

                entity.Property(e => e.Prgmyaka)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGMYAKA");

                entity.Property(e => e.Prgorev)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGOREV");

                entity.Property(e => e.Priscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISCIKT");

                entity.Property(e => e.Prisgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISGIRT");

                entity.Property(e => e.Prkadro)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRKADRO");

                entity.Property(e => e.Prkartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRKARTNO");

                entity.Property(e => e.Prkod1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD1");

                entity.Property(e => e.Prkod2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD2");

                entity.Property(e => e.Prkrttar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRKRTTAR");

                entity.Property(e => e.Prmasraf)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMASRAF");

                entity.Property(e => e.Prmasraftar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRMASRAFTAR");

                entity.Property(e => e.Prmesai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRMESAI");

                entity.Property(e => e.Prmeslek)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMESLEK");

                entity.Property(e => e.Prpertip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRPERTIP");

                entity.Property(e => e.Prposta).HasColumnName("PRPOSTA");

                entity.Property(e => e.Prpostar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRPOSTAR");

                entity.Property(e => e.Prpuantb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRPUANTB");

                entity.Property(e => e.Prservis)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRSERVIS");

                entity.Property(e => e.Prsicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICILNO");

                entity.Property(e => e.Prsoyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRSOYADI");

                entity.Property(e => e.Prtpgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRTPGIRT");

                entity.Property(e => e.Psadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSADI");

                entity.Property(e => e.Ptturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PTTURU");

                entity.Property(e => e.Srturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SRTURU");
            });

            modelBuilder.Entity<OtomailRpsaatizin>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("OTOMAIL_RPSAATIZIN");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Adadadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADADADI");

                entity.Property(e => e.Cladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLADI");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Csturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CSTURU");

                entity.Property(e => e.Dpadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPADI");

                entity.Property(e => e.Grturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRTURU");

                entity.Property(e => e.Kdturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KDTURU");

                entity.Property(e => e.Mmturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MMTURU");

                entity.Property(e => e.Msturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSTURU");

                entity.Property(e => e.Nnturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NNTURU");

                entity.Property(e => e.Pradi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRADI");

                entity.Property(e => e.Praltdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRALTDEPART");

                entity.Property(e => e.Praltdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRALTDEPTAR");

                entity.Property(e => e.Prcikndn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRCIKNDN");

                entity.Property(e => e.Prdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRDEPART");

                entity.Property(e => e.Prdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRDEPTAR");

                entity.Property(e => e.Prgmyaka)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGMYAKA");

                entity.Property(e => e.Prgorev)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRGOREV");

                entity.Property(e => e.Priscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISCIKT");

                entity.Property(e => e.Prisgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRISGIRT");

                entity.Property(e => e.Prkadro)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRKADRO");

                entity.Property(e => e.Prkartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRKARTNO");

                entity.Property(e => e.Prkod1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD1");

                entity.Property(e => e.Prkod2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRKOD2");

                entity.Property(e => e.Prkrttar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRKRTTAR");

                entity.Property(e => e.Prmasraf)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMASRAF");

                entity.Property(e => e.Prmasraftar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRMASRAFTAR");

                entity.Property(e => e.Prmesai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRMESAI");

                entity.Property(e => e.Prmeslek)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRMESLEK");

                entity.Property(e => e.Prpertip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRPERTIP");

                entity.Property(e => e.Prposta).HasColumnName("PRPOSTA");

                entity.Property(e => e.Prpostar)
                    .HasColumnType("datetime")
                    .HasColumnName("PRPOSTAR");

                entity.Property(e => e.Prpuantb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRPUANTB");

                entity.Property(e => e.Prservis)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRSERVIS");

                entity.Property(e => e.Prsicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICILNO");

                entity.Property(e => e.Prsoyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRSOYADI");

                entity.Property(e => e.Prtpgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("PRTPGIRT");

                entity.Property(e => e.Psadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSADI");

                entity.Property(e => e.Ptturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PTTURU");

                entity.Property(e => e.Sibassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("SIBASSAAT");

                entity.Property(e => e.Sibitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("SIBITSAAT");

                entity.Property(e => e.Sitarih)
                    .HasColumnType("datetime")
                    .HasColumnName("SITARIH");

                entity.Property(e => e.Srturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SRTURU");
            });

            modelBuilder.Entity<Otomaildepart>(entity =>
            {
                entity.HasKey(e => new { e.Yetkili, e.Srkodu, e.Kodu });

                entity.ToTable("OTOMAILDEPART");

                entity.Property(e => e.Yetkili)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("YETKILI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("KODU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<Otomailparam>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("OTOMAILPARAM");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KODU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Adresi)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ADRESI");

                entity.Property(e => e.Aylik)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AYLIK")
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.Disarda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DISARDA")
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.Eksik)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EKSIK")
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.Erken)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ERKEN")
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.Gec)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GEC")
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.Gelmeyen)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GELMEYEN")
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.Gelmeyen2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GELMEYEN2")
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.GirisCikis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GIRIS_CIKIS")
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.Grup)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GRUP");

                entity.Property(e => e.GunIzin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GUN_IZIN")
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.Icerde)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ICERDE")
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Izinde)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IZINDE")
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.SaatIzin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SAAT_IZIN")
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");
            });

            modelBuilder.Entity<Otomailyetki>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Derece, e.Yetkili, e.Turu });

                entity.ToTable("OTOMAILYETKI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Derece).HasColumnName("DERECE");

                entity.Property(e => e.Yetkili)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YETKILI");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");

                entity.Property(e => e.Deger)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("DEGER");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<OtopuanMail>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("OTOPUAN_MAIL");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Turu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<OtopuanParam>(entity =>
            {
                entity.HasKey(e => e.Zaman);

                entity.ToTable("OTOPUAN_PARAM");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.IlktarihGun).HasColumnName("ILKTARIH_GUN");

                entity.Property(e => e.IlktarihParam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ILKTARIH_PARAM");

                entity.Property(e => e.SontarihGun).HasColumnName("SONTARIH_GUN");

                entity.Property(e => e.SontarihParam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SONTARIH_PARAM");
            });

            modelBuilder.Entity<Otorapor>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("OTORAPOR");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("KODU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Adi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Goster)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GOSTER")
                    .IsFixedLength();

                entity.Property(e => e.Ilktarih).HasColumnName("ILKTARIH");

                entity.Property(e => e.Sontarih).HasColumnName("SONTARIH");
            });

            modelBuilder.Entity<Otorpkolon>(entity =>
            {
                entity.HasKey(e => new { e.Rpkodu, e.Adi });

                entity.ToTable("OTORPKOLON");

                entity.Property(e => e.Rpkodu)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("RPKODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Goster)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GOSTER");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<Otorpparam>(entity =>
            {
                entity.HasKey(e => new { e.Rpkodu, e.Adi });

                entity.ToTable("OTORPPARAM");

                entity.Property(e => e.Rpkodu)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("RPKODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Degeri)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGERI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TIPI");
            });

            modelBuilder.Entity<Overtime>(entity =>
            {
                entity.ToTable("OVERTIMES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Endhour)
                    .HasMaxLength(20)
                    .HasColumnName("ENDHOUR");

                entity.Property(e => e.Overtimeid).HasColumnName("OVERTIMEID");

                entity.Property(e => e.Overtimename)
                    .HasMaxLength(20)
                    .HasColumnName("OVERTIMENAME");

                entity.Property(e => e.Starthour)
                    .HasMaxLength(20)
                    .HasColumnName("STARTHOUR");
            });

            modelBuilder.Entity<PasifDonem>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("PASIF_DONEM");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Bittarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTARIH");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<Perarsiv1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("PERARSIV1");

                entity.HasIndex(e => e.Prsicil, "ARF1");

                entity.HasIndex(e => e.Tarih, "ARF2");

                entity.HasIndex(e => e.Bilgi, "ARF3");

                entity.HasIndex(e => e.Deger, "ARF4");

                entity.HasIndex(e => new { e.Prsicil, e.Bilgi, e.Tarih }, "PERARSIV1_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Bilgi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BILGI")
                    .IsFixedLength();

                entity.Property(e => e.Ciktarih)
                    .HasColumnType("datetime")
                    .HasColumnName("CIKTARIH");

                entity.Property(e => e.Deger)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEGER")
                    .IsFixedLength();

                entity.Property(e => e.Girtarih)
                    .HasColumnType("datetime")
                    .HasColumnName("GIRTARIH");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL")
                    .IsFixedLength();

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");
            });

            modelBuilder.Entity<Personel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PERSONEL");

                entity.HasIndex(e => new { e.Sicil, e.Sirket, e.Departman, e.Adi, e.Soyadi, e.Isgiristar, e.Iscikistar }, "IDX_01");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI")
                    .IsFixedLength();

                entity.Property(e => e.Adsoyad)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADSOYAD");

                entity.Property(e => e.Altdep)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ALTDEP");

                entity.Property(e => e.Cardno).HasColumnName("CARDNO");

                entity.Property(e => e.Departman)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMAN")
                    .IsFixedLength();

                entity.Property(e => e.Enabled).HasColumnName("ENABLED");

                entity.Property(e => e.Feyyaz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FEYYAZ");

                entity.Property(e => e.Gorevi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GOREVI");

                entity.Property(e => e.Iscikistar)
                    .HasColumnType("datetime")
                    .HasColumnName("ISCIKISTAR");

                entity.Property(e => e.Isgiristar)
                    .HasColumnType("datetime")
                    .HasColumnName("ISGIRISTAR");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Karttarih)
                    .HasColumnType("datetime")
                    .HasColumnName("KARTTARIH");

                entity.Property(e => e.Kurumsicilno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KURUMSICILNO");

                entity.Property(e => e.Password)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Privilege).HasColumnName("PRIVILEGE");

                entity.Property(e => e.Sicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICIL");

                entity.Property(e => e.Sirket).HasColumnName("SIRKET");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Tckimlik)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TCKIMLIK");

                entity.Property(e => e.Vergino)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VERGINO");
            });

            modelBuilder.Entity<Personel1>(entity =>
            {
                entity.HasKey(e => e.Sicilno);

                entity.ToTable("PERSONEL1");

                entity.HasIndex(e => e.Sicilno, "PERSONEL1_SICILNO_A");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Aktif)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.Altdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ALTDEPART");

                entity.Property(e => e.Altdepart2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALTDEPART2");

                entity.Property(e => e.Altdepart3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALTDEPART3");

                entity.Property(e => e.Altdepart4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALTDEPART4");

                entity.Property(e => e.Altdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("ALTDEPTAR");

                entity.Property(e => e.Altdeptar2)
                    .HasColumnType("datetime")
                    .HasColumnName("ALTDEPTAR2");

                entity.Property(e => e.Altdeptar3)
                    .HasColumnType("datetime")
                    .HasColumnName("ALTDEPTAR3");

                entity.Property(e => e.Altdeptar4)
                    .HasColumnType("datetime")
                    .HasColumnName("ALTDEPTAR4");

                entity.Property(e => e.Amir1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMIR1");

                entity.Property(e => e.Amir2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMIR2");

                entity.Property(e => e.Amir3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMIR3");

                entity.Property(e => e.Amir4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMIR4");

                entity.Property(e => e.Amir5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMIR5");

                entity.Property(e => e.BirimKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIRIM_KODU");

                entity.Property(e => e.BirimTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("BIRIM_TARIHI");

                entity.Property(e => e.Cikndn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIKNDN")
                    .IsFixedLength();

                entity.Property(e => e.Depart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEPART")
                    .IsFixedLength();

                entity.Property(e => e.Deptar)
                    .HasColumnType("datetime")
                    .HasColumnName("DEPTAR");

                entity.Property(e => e.DomainUsername)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_USERNAME");

                entity.Property(e => e.Durak)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DURAK");

                entity.Property(e => e.DurakTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("DURAK_TARIHI");

                entity.Property(e => e.GecisYetkituru)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GECIS_YETKITURU");

                entity.Property(e => e.Gmyaka)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GMYAKA")
                    .IsFixedLength();

                entity.Property(e => e.Gorev)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GOREV")
                    .IsFixedLength();

                entity.Property(e => e.Gorevtar)
                    .HasColumnType("datetime")
                    .HasColumnName("GOREVTAR");

                entity.Property(e => e.GrupKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_KODU");

                entity.Property(e => e.GrupTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GRUP_TARIHI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Iscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISCIKT");

                entity.Property(e => e.Isgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISGIRT");

                entity.Property(e => e.Kadro)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KADRO")
                    .IsFixedLength();

                entity.Property(e => e.Kadrotar)
                    .HasColumnType("datetime")
                    .HasColumnName("KADROTAR");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Kisitlama)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KISITLAMA")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.Kod1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KOD1")
                    .IsFixedLength();

                entity.Property(e => e.Kod2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KOD2")
                    .IsFixedLength();

                entity.Property(e => e.Kredi)
                    .HasColumnName("KREDI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KrediBastar)
                    .HasColumnType("datetime")
                    .HasColumnName("KREDI_BASTAR");

                entity.Property(e => e.KrediBittar)
                    .HasColumnType("datetime")
                    .HasColumnName("KREDI_BITTAR");

                entity.Property(e => e.Krttar)
                    .HasColumnType("datetime")
                    .HasColumnName("KRTTAR");

                entity.Property(e => e.Masraf)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MASRAF");

                entity.Property(e => e.Masraftar)
                    .HasColumnType("datetime")
                    .HasColumnName("MASRAFTAR");

                entity.Property(e => e.Mesai)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MESAI")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Meslek)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MESLEK")
                    .IsFixedLength();

                entity.Property(e => e.Meslektar)
                    .HasColumnType("datetime")
                    .HasColumnName("MESLEKTAR");

                entity.Property(e => e.OnySifre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONY_SIFRE");

                entity.Property(e => e.Pertip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP")
                    .IsFixedLength();

                entity.Property(e => e.Pertiptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PERTIPTAR");

                entity.Property(e => e.PiCardid)
                    .HasColumnName("PI_CARDID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PiIdno)
                    .HasColumnName("PI_IDNO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PiIdnoYdk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PI_IDNO_YDK");

                entity.Property(e => e.Posta).HasColumnName("POSTA");

                entity.Property(e => e.Postar)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTAR");

                entity.Property(e => e.Puantb)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PUANTB")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Servis)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SERVIS")
                    .IsFixedLength();

                entity.Property(e => e.Servistar)
                    .HasColumnType("datetime")
                    .HasColumnName("SERVISTAR");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SIFRE");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.SubeKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUBE_KODU");

                entity.Property(e => e.SubeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("SUBE_TARIHI");

                entity.Property(e => e.Tpgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("TPGIRT");

                entity.Property(e => e.Ucrettipi)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("UCRETTIPI");

                entity.Property(e => e.Ucretturu)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("UCRETTURU");

                entity.Property(e => e.Yetkituru)
                    .HasColumnName("YETKITURU")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Yilizhesapt)
                    .HasColumnType("datetime")
                    .HasColumnName("YILIZHESAPT");
            });

            modelBuilder.Entity<PersonelAmir>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.AmirKodu });

                entity.ToTable("PERSONEL_AMIR");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.AmirKodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AMIR_KODU");

                entity.Property(e => e.AmirAdi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AMIR_ADI");

                entity.Property(e => e.Dil).HasColumnName("DIL");

                entity.Property(e => e.DomainUsername)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_USERNAME");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.FmGrup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FM_GRUP");

                entity.Property(e => e.FmOnay).HasColumnName("FM_ONAY");

                entity.Property(e => e.Font).HasColumnName("FONT");

                entity.Property(e => e.GunlukIzinOnay).HasColumnName("GUNLUK_IZIN_ONAY");

                entity.Property(e => e.HaftaTatiliOnay).HasColumnName("HAFTA_TATILI_ONAY");

                entity.Property(e => e.HareketEklemeOnay).HasColumnName("HAREKET_EKLEME_ONAY");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.IznGrup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZN_GRUP");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.PostUserGunizin).HasColumnName("POST_USER_GUNIZIN");

                entity.Property(e => e.PostUserHareket).HasColumnName("POST_USER_HAREKET");

                entity.Property(e => e.PostUserMesai).HasColumnName("POST_USER_MESAI");

                entity.Property(e => e.PostUserPosta).HasColumnName("POST_USER_POSTA");

                entity.Property(e => e.PostUserSaatizin).HasColumnName("POST_USER_SAATIZIN");

                entity.Property(e => e.PostUserVardiya).HasColumnName("POST_USER_VARDIYA");

                entity.Property(e => e.RevirBolge)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("REVIR_BOLGE");

                entity.Property(e => e.RevirIzin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REVIR_IZIN");

                entity.Property(e => e.RevirUser).HasColumnName("REVIR_USER");

                entity.Property(e => e.SaatlikIzinOnay).HasColumnName("SAATLIK_IZIN_ONAY");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SIFRE");

                entity.Property(e => e.TaksiUcretiOnay).HasColumnName("TAKSI_UCRETI_ONAY");

                entity.Property(e => e.VardiyaOnay).HasColumnName("VARDIYA_ONAY");

                entity.Property(e => e.YmkModulDurumu).HasColumnName("YMK_MODUL_DURUMU");
            });

            modelBuilder.Entity<Personelamir1>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Prsicil, e.AmirKodu, e.Derece });

                entity.ToTable("PERSONELAMIR");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.AmirKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMIR_KODU");

                entity.Property(e => e.Derece).HasColumnName("DERECE");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<Personelovertime>(entity =>
            {
                entity.ToTable("PERSONELOVERTIMES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Createdat)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEDAT");

                entity.Property(e => e.Overtimeday)
                    .HasMaxLength(50)
                    .HasColumnName("OVERTIMEDAY");

                entity.Property(e => e.Overtimeid).HasColumnName("OVERTIMEID");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(20)
                    .HasColumnName("SICILNO");
            });

            modelBuilder.Entity<Personelshift>(entity =>
            {
                entity.ToTable("PERSONELSHIFTS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Createday)
                    .HasMaxLength(20)
                    .HasColumnName("CREATEDAY");

                entity.Property(e => e.Endday)
                    .HasMaxLength(20)
                    .HasColumnName("ENDDAY");

                entity.Property(e => e.Shiftid).HasColumnName("SHIFTID");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(20)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Startday)
                    .HasMaxLength(20)
                    .HasColumnName("STARTDAY");
            });

            modelBuilder.Entity<Pertipi>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Pertipi1 });

                entity.ToTable("PERTIPI");

                entity.HasIndex(e => new { e.Srkodu, e.Pertipi1 }, "IDX_YN_01");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Pertipi1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIPI")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Puantaj)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PUANTAJ")
                    .HasDefaultValueSql("('POSTA')")
                    .IsFixedLength();

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<Pertran>(entity =>
            {
                entity.HasKey(e => e.Tipi);

                entity.ToTable("PERTRANS");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPI");

                entity.Property(e => e.Basla).HasColumnName("BASLA");

                entity.Property(e => e.Dosya)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOSYA");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Yedek)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("YEDEK");
            });

            modelBuilder.Entity<Pertransalt>(entity =>
            {
                entity.HasKey(e => new { e.Tipi, e.Alan });

                entity.ToTable("PERTRANSALT");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPI");

                entity.Property(e => e.Alan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALAN");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Bilgi)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BILGI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Sayi).HasColumnName("SAYI");

                entity.Property(e => e.Stddeger)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STDDEGER");

                entity.Property(e => e.Sutun).HasColumnName("SUTUN");

                entity.Property(e => e.Zorunlu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ZORUNLU")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pervardiya1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("PERVARDIYA1");

                entity.HasIndex(e => new { e.Prsicil, e.Tarih }, "PERVARDIYA1_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Onay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ovkodu)
                    .HasColumnName("OVKODU")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<Perversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PERVERSION");

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VERSION");
            });

            modelBuilder.Entity<PgsDnkParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PGS_DNK_PARAM");

                entity.Property(e => e.DenklesecekMesai).HasColumnName("DENKLESECEK_MESAI");

                entity.Property(e => e.DenklesmeyecekMesai11).HasColumnName("DENKLESMEYECEK_MESAI_11");

                entity.Property(e => e.DenklesmeyecekMesaiGece).HasColumnName("DENKLESMEYECEK_MESAI_GECE");

                entity.Property(e => e.DenklesmeyecekMesaiGt).HasColumnName("DENKLESMEYECEK_MESAI_GT");

                entity.Property(e => e.DenklesmeyecekMesaiHt).HasColumnName("DENKLESMEYECEK_MESAI_HT");

                entity.Property(e => e.FiiliCalisma).HasColumnName("FIILI_CALISMA");

                entity.Property(e => e.Fm1).HasColumnName("FM1");

                entity.Property(e => e.Fm2).HasColumnName("FM2");

                entity.Property(e => e.Fm3).HasColumnName("FM3");

                entity.Property(e => e.Fm4).HasColumnName("FM4");

                entity.Property(e => e.Fm5).HasColumnName("FM5");

                entity.Property(e => e.GeceCalismasi).HasColumnName("GECE_CALISMASI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<PntListe>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("PNT_LISTE");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.ListeAdi)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LISTE_ADI");

                entity.Property(e => e.Rapor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RAPOR")
                    .IsFixedLength();
            });

            modelBuilder.Entity<PntListealt>(entity =>
            {
                entity.HasKey(e => new { e.ListeKodu, e.Clkodu });

                entity.ToTable("PNT_LISTEALT");

                entity.Property(e => e.ListeKodu).HasColumnName("LISTE_KODU");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BASLIK");
            });

            modelBuilder.Entity<Postatil>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("POSTATIL");

                entity.HasIndex(e => new { e.Srkodu, e.Pskodu, e.Tarih }, "POSTATIL_IDX1")
                    .IsUnique();

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.Pskodu).HasColumnName("PSKODU");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<Postavar>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("POSTAVAR");

                entity.HasIndex(e => new { e.Srkodu, e.Pskodu, e.Vrkodu }, "POSTAVAR_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.Pskodu).HasColumnName("PSKODU");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<Postum>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("POSTA");

                entity.HasIndex(e => new { e.Srkodu, e.Kodu }, "IDX_YN_01");

                entity.HasIndex(e => e.Idno, "POSTA_IDX1");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Bastar)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTAR");

                entity.Property(e => e.DvmSure).HasColumnName("DVM_SURE");

                entity.Property(e => e.GrupKodu).HasColumnName("GRUP_KODU");

                entity.Property(e => e.Gun)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GUN");

                entity.Property(e => e.HaftaTatili).HasColumnName("HAFTA_TATILI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.IsbasiGun).HasColumnName("ISBASI_GUN");

                entity.Property(e => e.IzinDevirLimit).HasColumnName("IZIN_DEVIR_LIMIT");

                entity.Property(e => e.Turu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<Prgparam>(entity =>
            {
                entity.HasKey(e => e.Idno)
                    .HasName("PK_PRGPARAM_1");

                entity.ToTable("PRGPARAM");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Deger)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER");

                entity.Property(e => e.Grup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUP");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Parametre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETRE");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPI");
            });

            modelBuilder.Entity<Puancal>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("PUANCAL");

                entity.HasIndex(e => new { e.Srkodu, e.Ptkodu, e.Clkodu }, "PUANCAL_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Ptkodu).HasColumnName("PTKODU");

                entity.Property(e => e.Sira).HasColumnName("SIRA");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<Puanlama1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("PUANLAMA1");

                entity.HasIndex(e => new { e.Prsicil, e.Tarih }, "PUANLAMA1_IDX1")
                    .IsUnique();

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Baglilik).HasColumnName("BAGLILIK");

                entity.Property(e => e.Bilgi).HasColumnName("BILGI");

                entity.Property(e => e.Disiplin).HasColumnName("DISIPLIN");

                entity.Property(e => e.Kalite).HasColumnName("KALITE");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Temizlik).HasColumnName("TEMIZLIK");

                entity.Property(e => e.Verim).HasColumnName("VERIM");
            });

            modelBuilder.Entity<Puantaj1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("PUANTAJ1");

                entity.HasIndex(e => e.Prsicil, "PUANTAJ1_IDX1");

                entity.HasIndex(e => new { e.Prsicil, e.Tarih, e.Drcno }, "PUANTAJ1_IDX2");

                entity.HasIndex(e => new { e.Prsicil, e.Tarih, e.Drcno, e.Clkodu }, "PUANTAJ1_IDX3");

                entity.HasIndex(e => new { e.Prsicil, e.Tarih }, "PUANTAJ1_PRSICIL_TARIH");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.DnkDonem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DNK_DONEM");

                entity.Property(e => e.DnkOrjsure)
                    .HasColumnType("datetime")
                    .HasColumnName("DNK_ORJSURE");

                entity.Property(e => e.Drcno).HasColumnName("DRCNO");

                entity.Property(e => e.GunHesapla)
                    .HasColumnName("GUN_HESAPLA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hesapzaman)
                    .HasColumnType("datetime")
                    .HasColumnName("HESAPZAMAN")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Izahat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Neden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN");

                entity.Property(e => e.Onay)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ONAY")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Orjsure)
                    .HasColumnType("datetime")
                    .HasColumnName("ORJSURE");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Pskodu).HasColumnName("PSKODU");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.TpSure).HasColumnName("TP_SURE");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<PuantajEsnekTarih>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Prsicil, e.Tarih });

                entity.ToTable("PUANTAJ_ESNEK_TARIH");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<PuantajLog>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("PUANTAJ_LOG");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Durum).HasColumnName("DURUM");

                entity.Property(e => e.IslemZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLEM_ZAMANI");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");
            });

            modelBuilder.Entity<PuantajToleransLog>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("PUANTAJ_TOLERANS_LOG");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<Puanturu>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("PUANTURU");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Aymodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AYMODU")
                    .HasDefaultValueSql("('DAKİKA')")
                    .IsFixedLength();

                entity.Property(e => e.Ayyuv)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AYYUV")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Bosgoster)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BOSGOSTER")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Gunmodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GUNMODU")
                    .HasDefaultValueSql("('DAKİKA')")
                    .IsFixedLength();

                entity.Property(e => e.Gunyuv)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("GUNYUV")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .HasDefaultValueSql("('RAPOR')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Rapor>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("RAPOR");

                entity.HasIndex(e => e.Kodu, "RAPOR_IDX1")
                    .IsUnique();

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Alanbaslik)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ALANBASLIK");

                entity.Property(e => e.Alantipi)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ALANTIPI");

                entity.Property(e => e.Alanuzunluk)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ALANUZUNLUK");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BASLIK");

                entity.Property(e => e.Grkodu)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("GRKODU")
                    .IsFixedLength();

                entity.Property(e => e.Kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KODU")
                    .IsFixedLength();

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI")
                    .IsFixedLength();

                entity.Property(e => e.Ordersql)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSQL");

                entity.Property(e => e.Selectsql)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SELECTSQL");

                entity.Property(e => e.Turu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .IsFixedLength();

                entity.Property(e => e.Wheresql)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("WHERESQL");

                entity.Property(e => e.Yetki)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YETKI")
                    .IsFixedLength();
            });

            modelBuilder.Entity<RaporHareket>(entity =>
            {
                entity.HasKey(e => e.Idno)
                    .HasName("PK_GPRAPOR_HAREKET");

                entity.ToTable("RAPOR_HAREKET");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Ciksaat1)
                    .HasColumnType("datetime")
                    .HasColumnName("CIKSAAT1");

                entity.Property(e => e.Ciksaat2)
                    .HasColumnType("datetime")
                    .HasColumnName("CIKSAAT2");

                entity.Property(e => e.Ciktarih1)
                    .HasColumnType("datetime")
                    .HasColumnName("CIKTARIH1");

                entity.Property(e => e.Ciktarih2)
                    .HasColumnType("datetime")
                    .HasColumnName("CIKTARIH2");

                entity.Property(e => e.Girsaat1)
                    .HasColumnType("datetime")
                    .HasColumnName("GIRSAAT1");

                entity.Property(e => e.Girsaat2)
                    .HasColumnType("datetime")
                    .HasColumnName("GIRSAAT2");

                entity.Property(e => e.Girtarih1)
                    .HasColumnType("datetime")
                    .HasColumnName("GIRTARIH1");

                entity.Property(e => e.Girtarih2)
                    .HasColumnType("datetime")
                    .HasColumnName("GIRTARIH2");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");
            });

            modelBuilder.Entity<Refidlog>(entity =>
            {
                entity.HasKey(e => e.Zaman);

                entity.ToTable("REFIDLOG");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Maxdeger)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MAXDEGER");

                entity.Property(e => e.Yazilan)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("YAZILAN");
            });

            modelBuilder.Entity<RpOzelrapor>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("RP_OZELRAPOR");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.GrupAlan)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_ALAN");

                entity.Property(e => e.Grupla).HasColumnName("GRUPLA");

                entity.Property(e => e.RaporAdi)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RAPOR_ADI");

                entity.Property(e => e.RaporKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RAPOR_KODU");

                entity.Property(e => e.Sayalan)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("SAYALAN");

                entity.Property(e => e.StoredProcedure)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("STORED_PROCEDURE");

                entity.Property(e => e.Toplamalan)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("TOPLAMALAN");
            });

            modelBuilder.Entity<Rpalan>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("RPALAN");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Alan)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ALAN")
                    .IsFixedLength();

                entity.Property(e => e.Izahat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");

                entity.Property(e => e.Rpkodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RPKODU")
                    .IsFixedLength();

                entity.Property(e => e.Tbadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TBADI")
                    .IsFixedLength();

                entity.Property(e => e.Uzunluk).HasColumnName("UZUNLUK");
            });

            modelBuilder.Entity<Rpalanstd>(entity =>
            {
                entity.HasKey(e => new { e.Rpturu, e.Rpadi, e.Lstadi, e.Caption });

                entity.ToTable("RPALANSTD");

                entity.Property(e => e.Rpturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RPTURU");

                entity.Property(e => e.Rpadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RPADI");

                entity.Property(e => e.Lstadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LSTADI");

                entity.Property(e => e.Caption)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CAPTION");

                entity.Property(e => e.Sira).HasColumnName("SIRA");

                entity.Property(e => e.Width)
                    .HasColumnName("WIDTH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Rpgrup>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("RPGRUP");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KODU")
                    .IsFixedLength();

                entity.Property(e => e.Tbadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TBADI")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Rppreview>(entity =>
            {
                entity.HasKey(e => new { e.Rpturu, e.Rpadi, e.Lsadi });

                entity.ToTable("RPPREVIEW");

                entity.Property(e => e.Rpturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RPTURU");

                entity.Property(e => e.Rpadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RPADI");

                entity.Property(e => e.Lsadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LSADI");

                entity.Property(e => e.Autowidth).HasColumnName("AUTOWIDTH");

                entity.Property(e => e.Font)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FONT");

                entity.Property(e => e.Fontsize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FONTSIZE");

                entity.Property(e => e.Orientation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ORIENTATION");
            });

            modelBuilder.Entity<RprForm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPR_FORM");

                entity.Property(e => e.Adi)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Kodu).HasColumnName("KODU");
            });

            modelBuilder.Entity<RprFormat>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Rpradi, e.Adi });

                entity.ToTable("RPR_FORMAT");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Rpradi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RPRADI");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Sira)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SIRA");
            });

            modelBuilder.Entity<RprGunizin>(entity =>
            {
                entity.HasKey(e => e.Sira);

                entity.ToTable("RPR_GUNIZIN");

                entity.Property(e => e.Sira).HasColumnName("SIRA");

                entity.Property(e => e.Bastar)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTAR");

                entity.Property(e => e.Bittar)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTAR");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Sirket)
                    .HasColumnName("SIRKET")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<RprKulform>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Kodu })
                    .HasName("PK_RPR_KULform");

                entity.ToTable("RPR_KULFORM");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Sira)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SIRA");
            });

            modelBuilder.Entity<RprKulgrup>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Kodu });

                entity.ToTable("RPR_KULGRUP");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Adi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Sira)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SIRA");
            });

            modelBuilder.Entity<RprKulgrupchz>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Kodu, e.Adi });

                entity.ToTable("RPR_KULGRUPCHZ");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Sira)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SIRA");
            });

            modelBuilder.Entity<RprKullanici>(entity =>
            {
                entity.HasKey(e => e.Kladi);

                entity.ToTable("RPR_KULLANICI");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MAIL");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIFRE");

                entity.Property(e => e.Sira)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SIRA");

                entity.Property(e => e.Yetkili)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("YETKILI");
            });

            modelBuilder.Entity<RprKulliste>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Kodu });

                entity.ToTable("RPR_KULLISTE");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Kodu)
                    .HasMaxLength(10)
                    .HasColumnName("KODU")
                    .IsFixedLength();

                entity.Property(e => e.Sira)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SIRA");
            });

            modelBuilder.Entity<RprListe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPR_LISTE");

                entity.Property(e => e.Adi)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ADI")
                    .IsFixedLength();

                entity.Property(e => e.Kodu).HasColumnName("KODU");
            });

            modelBuilder.Entity<RprLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPR_LOG");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Islem)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ISLEM");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<RprMailparam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPR_MAILPARAM");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HOSTNAME");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Mailgonder)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAILGONDER")
                    .HasDefaultValueSql("('HAYIR')");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Portno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PORTNO");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Zaman1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ZAMAN1");

                entity.Property(e => e.Zaman2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ZAMAN2");

                entity.Property(e => e.Zaman3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ZAMAN3");

                entity.Property(e => e.Zaman4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ZAMAN4");
            });

            modelBuilder.Entity<RprMola>(entity =>
            {
                entity.HasKey(e => e.Kodu);

                entity.ToTable("RPR_MOLA");

                entity.Property(e => e.Kodu)
                    .ValueGeneratedNever()
                    .HasColumnName("KODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(10)
                    .HasColumnName("ADI")
                    .IsFixedLength();

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Sira)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SIRA");
            });

            modelBuilder.Entity<RprNeden>(entity =>
            {
                entity.HasKey(e => e.Sira);

                entity.ToTable("RPR_NEDEN");

                entity.Property(e => e.Sira).HasColumnName("SIRA");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Turu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .HasDefaultValueSql("('IZIN')");
            });

            modelBuilder.Entity<RprNobet>(entity =>
            {
                entity.HasKey(e => new { e.Sicil, e.Tarih, e.Bassaat, e.Bitsaat });

                entity.ToTable("RPR_NOBET");

                entity.Property(e => e.Sicil)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Sayi)
                    .HasColumnName("SAYI")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<RprSaatizin>(entity =>
            {
                entity.HasKey(e => e.Sira);

                entity.ToTable("RPR_SAATIZIN");

                entity.Property(e => e.Sira).HasColumnName("SIRA");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Sirket)
                    .HasColumnName("SIRKET")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");
            });

            modelBuilder.Entity<RprToplam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPR_TOPLAM");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Cikchz).HasColumnName("CIKCHZ");

                entity.Property(e => e.Cikchzadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIKCHZADI");

                entity.Property(e => e.Cikzmn)
                    .HasColumnType("datetime")
                    .HasColumnName("CIKZMN");

                entity.Property(e => e.Dpadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPADI");

                entity.Property(e => e.Dpkodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DPKODU");

                entity.Property(e => e.Girchz).HasColumnName("GIRCHZ");

                entity.Property(e => e.Girchzadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GIRCHZADI");

                entity.Property(e => e.Girzmn)
                    .HasColumnType("datetime")
                    .HasColumnName("GIRZMN");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Sirket)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SIRKET");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Sure)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURE");

                entity.Property(e => e.Turu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TURU");

                entity.Property(e => e.Unvan)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UNVAN");
            });

            modelBuilder.Entity<RprVersiyon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPR_VERSIYON");

                entity.Property(e => e.Versiyon)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VERSIYON")
                    .IsFixedLength();
            });

            modelBuilder.Entity<RprYetkicihaz>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Terminal });

                entity.ToTable("RPR_YETKICIHAZ");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Terminal)
                    .HasMaxLength(10)
                    .HasColumnName("TERMINAL")
                    .IsFixedLength();

                entity.Property(e => e.Sira)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SIRA");
            });

            modelBuilder.Entity<RprYetkidepart>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Departman });

                entity.ToTable("RPR_YETKIDEPART");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Departman)
                    .HasMaxLength(10)
                    .HasColumnName("DEPARTMAN")
                    .IsFixedLength();

                entity.Property(e => e.Sira)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SIRA");

                entity.Property(e => e.Srkodu)
                    .HasMaxLength(10)
                    .HasColumnName("SRKODU")
                    .IsFixedLength();
            });

            modelBuilder.Entity<RprYetkisicil>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Sicil });

                entity.ToTable("RPR_YETKISICIL");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Sicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICIL");

                entity.Property(e => e.Sira)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SIRA");

                entity.Property(e => e.Srkodu)
                    .HasMaxLength(10)
                    .HasColumnName("SRKODU")
                    .IsFixedLength();
            });

            modelBuilder.Entity<RprYetkisirket>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Sirket });

                entity.ToTable("RPR_YETKISIRKET");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Sirket)
                    .HasMaxLength(10)
                    .HasColumnName("SIRKET")
                    .IsFixedLength();

                entity.Property(e => e.Sira)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SIRA");
            });

            modelBuilder.Entity<RprYmk>(entity =>
            {
                entity.HasKey(e => e.Kodu);

                entity.ToTable("RPR_YMK");

                entity.Property(e => e.Kodu)
                    .ValueGeneratedNever()
                    .HasColumnName("KODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(10)
                    .HasColumnName("ADI")
                    .IsFixedLength();

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Fiyati)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("FIYATI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sira)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SIRA");
            });

            modelBuilder.Entity<Rprfiltre>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("RPRFILTRE");

                entity.HasIndex(e => new { e.Rapor, e.Adi }, "RPRFILTRE_IDX1");

                entity.HasIndex(e => new { e.Rapor, e.Idno }, "RPRFILTRE_IDX2");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Izahat)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");

                entity.Property(e => e.Ordersql)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSQL");

                entity.Property(e => e.Rapor)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RAPOR");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPI");

                entity.Property(e => e.Wheresql)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("WHERESQL");
            });

            modelBuilder.Entity<Rprfiltred>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("RPRFILTRED");

                entity.HasIndex(e => e.Radi, "RPRFILTRED_IDX1");

                entity.HasIndex(e => e.Fidno, "RPRFILTRED_IDX2");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Alan)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ALAN");

                entity.Property(e => e.Baglama)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BAGLAMA");

                entity.Property(e => e.Deger1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER1");

                entity.Property(e => e.Deger2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER2");

                entity.Property(e => e.Fidno).HasColumnName("FIDNO");

                entity.Property(e => e.Keyalan)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("KEYALAN");

                entity.Property(e => e.Kriter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KRITER");

                entity.Property(e => e.Radi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RADI");

                entity.Property(e => e.Siralama).HasColumnName("SIRALAMA");

                entity.Property(e => e.Tadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TADI");
            });

            modelBuilder.Entity<Rprtablo>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("RPRTABLO");

                entity.HasIndex(e => new { e.Radi, e.Tadi }, "RPRTABLO_IDX1");

                entity.HasIndex(e => e.Tadi, "RPRTABLO_IDX2");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Alias1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ALIAS1");

                entity.Property(e => e.Alias2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ALIAS2");

                entity.Property(e => e.Durum)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DURUM");

                entity.Property(e => e.Ltadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LTADI");

                entity.Property(e => e.Radi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RADI");

                entity.Property(e => e.Tadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TADI");
            });

            modelBuilder.Entity<Rpsorgu>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("RPSORGU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Alan)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ALAN")
                    .IsFixedLength();

                entity.Property(e => e.Baglama)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BAGLAMA")
                    .IsFixedLength();

                entity.Property(e => e.Deger1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER1");

                entity.Property(e => e.Deger2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER2");

                entity.Property(e => e.Kriter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KRITER");

                entity.Property(e => e.Rpkodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RPKODU")
                    .IsFixedLength();

                entity.Property(e => e.Siralama).HasColumnName("SIRALAMA");

                entity.Property(e => e.Tbadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TBADI")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Rptablo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPTABLO");

                entity.HasIndex(e => new { e.Rpkodu, e.Tbadi }, "RPTABLO_IDX1");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Rpkodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RPKODU")
                    .IsFixedLength();

                entity.Property(e => e.Tbadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TBADI")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Saatizin1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("SAATIZIN1");

                entity.HasIndex(e => new { e.Prsicil, e.Neden, e.Tarih, e.Bassaat }, "Idx_Yn_1");

                entity.HasIndex(e => new { e.Prsicil, e.Tarih, e.Bassaat, e.Bitsaat }, "SAATIZIN1_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN")
                    .IsFixedLength();

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Saat)
                    .HasColumnType("datetime")
                    .HasColumnName("SAAT");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Trnid).HasColumnName("TRNID");
            });

            modelBuilder.Entity<Seminer1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("SEMINER1");

                entity.HasIndex(e => e.Prsicil, "SEMINER1_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Ciktar)
                    .HasColumnType("datetime")
                    .HasColumnName("CIKTAR");

                entity.Property(e => e.Derece).HasColumnName("DERECE");

                entity.Property(e => e.Girtar)
                    .HasColumnType("datetime")
                    .HasColumnName("GIRTAR");

                entity.Property(e => e.Konusu)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("KONUSU");

                entity.Property(e => e.Kuradi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KURADI");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Sure).HasColumnName("SURE");

                entity.Property(e => e.Suresec)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SURESEC")
                    .IsFixedLength();

                entity.Property(e => e.Ucret).HasColumnName("UCRET");
            });

            modelBuilder.Entity<Serbesttatil1>(entity =>
            {
                entity.HasKey(e => new { e.Prsicil, e.Tarih });

                entity.ToTable("SERBESTTATIL1");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<Serdinlenme>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Vardiya, e.Baslama, e.Bitis, e.Refcal })
                    .HasName("PK_SERDINLLENME");

                entity.ToTable("SERDINLENME");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Vardiya).HasColumnName("VARDIYA");

                entity.Property(e => e.Baslama)
                    .HasColumnType("datetime")
                    .HasColumnName("BASLAMA");

                entity.Property(e => e.Bitis)
                    .HasColumnType("datetime")
                    .HasColumnName("BITIS");

                entity.Property(e => e.Refcal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REFCAL");

                entity.Property(e => e.Trncal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRNCAL");

                entity.Property(e => e.Trnsure)
                    .HasColumnType("datetime")
                    .HasColumnName("TRNSURE");

                entity.Property(e => e.Varsure)
                    .HasColumnType("datetime")
                    .HasColumnName("VARSURE")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Serizin>(entity =>
            {
                entity.HasKey(e => e.Kodu);

                entity.ToTable("SERIZIN");

                entity.Property(e => e.Kodu)
                    .ValueGeneratedNever()
                    .HasColumnName("KODU");

                entity.Property(e => e.Gun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GUN");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");

                entity.Property(e => e.Tatil).HasColumnName("TATIL");
            });

            modelBuilder.Entity<Servi>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("SERVIS");

                entity.HasIndex(e => new { e.Srkodu, e.Kodu }, "IDX_YN_01");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KODU")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<ShfVersiyon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SHF_VERSIYON");

                entity.Property(e => e.Versiyon)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VERSIYON")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Shfgunizin>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kladi, e.Sicil, e.Bastar, e.Bittar, e.Neden });

                entity.ToTable("SHFGUNIZIN");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Sicil)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SICIL");

                entity.Property(e => e.Bastar)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTAR");

                entity.Property(e => e.Bittar)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTAR");

                entity.Property(e => e.Neden).HasColumnName("NEDEN");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Belge)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BELGE")
                    .HasDefaultValueSql("('YOK')");

                entity.Property(e => e.Durum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DURUM")
                    .HasDefaultValueSql("('BEKLEMEDE')");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPI")
                    .HasDefaultValueSql("('Talep')");
            });

            modelBuilder.Entity<Shfhareket>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kladi, e.Sicil, e.Tarih, e.Saat });

                entity.ToTable("SHFHAREKET");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Sicil)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Saat)
                    .HasColumnType("datetime")
                    .HasColumnName("SAAT");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Belge)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BELGE")
                    .HasDefaultValueSql("('YOK')");

                entity.Property(e => e.Durum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DURUM")
                    .HasDefaultValueSql("('BEKLEMEDE')");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPI");

                entity.Property(e => e.Yon)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YON")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Shfkullanici>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Adi });

                entity.ToTable("SHFKULLANICI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ADI")
                    .IsFixedLength();

                entity.Property(e => e.Adm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADM")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength();

                entity.Property(e => e.ArsivAc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ARSIV_AC");

                entity.Property(e => e.ArsivKpt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ARSIV_KPT");

                entity.Property(e => e.Ik)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IK")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength();

                entity.Property(e => e.Izahat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");

                entity.Property(e => e.Klsira).HasColumnName("KLSIRA");

                entity.Property(e => e.PostUser)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POST_USER");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIFRE")
                    .IsFixedLength();

                entity.Property(e => e.UserTanim)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USER_TANIM");

                entity.Property(e => e.Ytkdepart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("YTKDEPART")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength();

                entity.Property(e => e.Ytkderece)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("YTKDERECE")
                    .HasDefaultValueSql("('E')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Shflog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SHFLOG");

                entity.Property(e => e.Islem)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ISLEM");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<Shfmesai>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kladi, e.Sicil, e.Tarih, e.Saat, e.Neden });

                entity.ToTable("SHFMESAI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Sicil)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SICIL");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Saat)
                    .HasColumnType("datetime")
                    .HasColumnName("SAAT");

                entity.Property(e => e.Neden).HasColumnName("NEDEN");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Belge)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BELGE")
                    .HasDefaultValueSql("('YOK')");

                entity.Property(e => e.Durum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DURUM")
                    .HasDefaultValueSql("('BEKLEMEDE')");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Mesai)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MESAI");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Onay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPI")
                    .HasDefaultValueSql("('Talep')");
            });

            modelBuilder.Entity<Shfonay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SHFONAY");

                entity.Property(e => e.Onay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONAY")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.Sicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Vardiya).HasColumnName("VARDIYA");
            });

            modelBuilder.Entity<Shfsaatizin>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kladi, e.Sicil, e.Bastar, e.Bittar, e.Neden });

                entity.ToTable("SHFSAATIZIN");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Sicil)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SICIL");

                entity.Property(e => e.Bastar)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTAR");

                entity.Property(e => e.Bittar)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTAR");

                entity.Property(e => e.Neden).HasColumnName("NEDEN");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Belge)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BELGE")
                    .HasDefaultValueSql("('YOK')");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Durum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DURUM")
                    .HasDefaultValueSql("('BEKLEMEDE')");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Sebep)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SEBEP");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPI")
                    .HasDefaultValueSql("('Talep')");
            });

            modelBuilder.Entity<Shfyedek>(entity =>
            {
                entity.HasKey(e => e.Sira);

                entity.ToTable("SHFYEDEK");

                entity.Property(e => e.Sira).HasColumnName("SIRA");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Departman)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMAN")
                    .IsFixedLength();

                entity.Property(e => e.Grup).HasColumnName("GRUP");

                entity.Property(e => e.Islemtarih)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLEMTARIH");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Sicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Vardiya).HasColumnName("VARDIYA");
            });

            modelBuilder.Entity<Shfyetkidepart>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kladi, e.Depart });

                entity.ToTable("SHFYETKIDEPART");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Depart)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DEPART")
                    .IsFixedLength();

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");
            });

            modelBuilder.Entity<Shfyetkivardiya>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kladi, e.Kodu, e.Adi });

                entity.ToTable("SHFYETKIVARDIYA");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIPI");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("SHIFTS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Endhour)
                    .HasMaxLength(10)
                    .HasColumnName("ENDHOUR");

                entity.Property(e => e.Shiftid).HasColumnName("SHIFTID");

                entity.Property(e => e.Shiftname)
                    .HasMaxLength(20)
                    .HasColumnName("SHIFTNAME");

                entity.Property(e => e.Starthour)
                    .HasMaxLength(10)
                    .HasColumnName("STARTHOUR");
            });

            modelBuilder.Entity<Sifrekural>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("SIFREKURAL");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Buyukharf).HasColumnName("BUYUKHARF");

                entity.Property(e => e.Buyukharfsayisi).HasColumnName("BUYUKHARFSAYISI");

                entity.Property(e => e.Degisikliksure).HasColumnName("DEGISIKLIKSURE");

                entity.Property(e => e.Digerkarakter).HasColumnName("DIGERKARAKTER");

                entity.Property(e => e.Digerkaraktersayisi).HasColumnName("DIGERKARAKTERSAYISI");

                entity.Property(e => e.Ilkkarakter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ILKKARAKTER");

                entity.Property(e => e.Kucukharf).HasColumnName("KUCUKHARF");

                entity.Property(e => e.Kucukharfsayisi).HasColumnName("KUCUKHARFSAYISI");

                entity.Property(e => e.Kullaniciiceremez).HasColumnName("KULLANICIICEREMEZ");

                entity.Property(e => e.Oncekisifresayi).HasColumnName("ONCEKISIFRESAYI");

                entity.Property(e => e.Rakam).HasColumnName("RAKAM");

                entity.Property(e => e.Rakamsayisi).HasColumnName("RAKAMSAYISI");

                entity.Property(e => e.Uzunluk).HasColumnName("UZUNLUK");
            });

            modelBuilder.Entity<Sirket>(entity =>
            {
                entity.HasKey(e => e.Kodu);

                entity.ToTable("SIRKET");

                entity.HasIndex(e => e.Idno, "SIRKET_IDX1");

                entity.Property(e => e.Kodu)
                    .ValueGeneratedNever()
                    .HasColumnName("KODU");

                entity.Property(e => e.Adres)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADRES");

                entity.Property(e => e.Aydonum).HasColumnName("AYDONUM");

                entity.Property(e => e.Aytoplamyuvar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AYTOPLAMYUVAR")
                    .IsFixedLength();

                entity.Property(e => e.Ayyuvar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AYYUVAR")
                    .IsFixedLength();

                entity.Property(e => e.DnkKullan).HasColumnName("DNK_KULLAN");

                entity.Property(e => e.DnkonayGunluk).HasColumnName("DNKONAY_GUNLUK");

                entity.Property(e => e.DnkonayHaftalik).HasColumnName("DNKONAY_HAFTALIK");

                entity.Property(e => e.Fax1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FAX1");

                entity.Property(e => e.Fax2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FAX2");

                entity.Property(e => e.Gunyuvar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GUNYUVAR")
                    .IsFixedLength();

                entity.Property(e => e.Hfttoplamyuvar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HFTTOPLAMYUVAR")
                    .IsFixedLength();

                entity.Property(e => e.Hftyuvar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HFTYUVAR")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Il)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IL");

                entity.Property(e => e.Ilce)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ILCE");

                entity.Property(e => e.Krtuzun).HasColumnName("KRTUZUN");

                entity.Property(e => e.Logo)
                    .HasColumnType("image")
                    .HasColumnName("LOGO");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAIL");

                entity.Property(e => e.PrgTipi).HasColumnName("PRG_TIPI");

                entity.Property(e => e.Scluzun).HasColumnName("SCLUZUN");

                entity.Property(e => e.Semt)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SEMT");

                entity.Property(e => e.Sistem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SISTEM");

                entity.Property(e => e.Teksicil)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TEKSICIL")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Tel1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TEL1");

                entity.Property(e => e.Tel2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TEL2");

                entity.Property(e => e.Tel3)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TEL3");

                entity.Property(e => e.Trsirkodu)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("TRSIRKODU");

                entity.Property(e => e.Trsirturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRSIRTURU");

                entity.Property(e => e.Unvan)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UNVAN");

                entity.Property(e => e.Verda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VERDA");

                entity.Property(e => e.Verno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VERNO");

                entity.Property(e => e.Web)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WEB");
            });

            modelBuilder.Entity<Sisgk>(entity =>
            {
                entity.HasKey(e => new { e.Sistem, e.Reader });

                entity.ToTable("SISGKS");

                entity.Property(e => e.Sistem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SISTEM");

                entity.Property(e => e.Reader)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("READER")
                    .IsFixedLength();

                entity.Property(e => e.Gc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GC")
                    .IsFixedLength();

                entity.Property(e => e.Gmyaka)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GMYAKA");

                entity.Property(e => e.Idno).HasColumnName("IDNO");
            });

            modelBuilder.Entity<Sismesai>(entity =>
            {
                entity.HasKey(e => new { e.CihazNo, e.Turu });

                entity.ToTable("SISMESAI");

                entity.Property(e => e.CihazNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZ_NO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TURU");

                entity.Property(e => e.CihazAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZ_ADI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<Sisparam>(entity =>
            {
                entity.HasKey(e => new { e.Sistem, e.Kolon });

                entity.ToTable("SISPARAM");

                entity.Property(e => e.Sistem)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SISTEM");

                entity.Property(e => e.Kolon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KOLON");

                entity.Property(e => e.Deger)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Operator)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OPERATOR");
            });

            modelBuilder.Entity<Sistem>(entity =>
            {
                entity.HasKey(e => e.Adi);

                entity.ToTable("SISTEM");

                entity.HasIndex(e => e.Tipi, "SISTEM_IDX1");

                entity.HasIndex(e => e.Refid, "SISTEM_IDX2");

                entity.Property(e => e.Adi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Ckodu)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CKODU")
                    .HasDefaultValueSql("('C')")
                    .IsFixedLength();

                entity.Property(e => e.Gcvar)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("GCVAR")
                    .HasDefaultValueSql("('HAYIR')")
                    .IsFixedLength();

                entity.Property(e => e.Gkodu)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GKODU")
                    .HasDefaultValueSql("('G')")
                    .IsFixedLength();

                entity.Property(e => e.Gunlim)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNLIM");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("HOSTNAME");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.IlksonGckontrol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ILKSON_GCKONTROL");

                entity.Property(e => e.IlksonGndsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("ILKSON_GNDSAAT");

                entity.Property(e => e.IlksonGndtipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ILKSON_GNDTIPI");

                entity.Property(e => e.IlksonKontrolTolerans)
                    .HasColumnType("datetime")
                    .HasColumnName("ILKSON_KONTROL_TOLERANS");

                entity.Property(e => e.Ilksonhar).HasColumnName("ILKSONHAR");

                entity.Property(e => e.Masterpswd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MASTERPSWD");

                entity.Property(e => e.Masterusr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MASTERUSR");

                entity.Property(e => e.Oksure)
                    .HasColumnType("datetime")
                    .HasColumnName("OKSURE");

                entity.Property(e => e.OksureTekyon)
                    .HasColumnName("OKSURE_TEKYON")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.Protocol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROTOCOL")
                    .HasDefaultValueSql("('mssql')");

                entity.Property(e => e.Refcolumn)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("REFCOLUMN");

                entity.Property(e => e.Refid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REFID");

                entity.Property(e => e.RemoteHostname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REMOTE_HOSTNAME");

                entity.Property(e => e.Saniye)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SANIYE")
                    .HasDefaultValueSql("('Hayır')");

                entity.Property(e => e.Sorgu)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("SORGU");

                entity.Property(e => e.Tablo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TABLO");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPI")
                    .HasDefaultValueSql("('DATABASE')")
                    .IsFixedLength();

                entity.Property(e => e.Transfer)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRANSFER")
                    .IsFixedLength();

                entity.Property(e => e.Txtgcknt)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TXTGCKNT")
                    .IsFixedLength();

                entity.Property(e => e.Veriyolu)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VERIYOLU");
            });

            modelBuilder.Entity<Sisveri>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("SISVERI");

                entity.HasIndex(e => new { e.Sistem, e.Alan }, "SISVERI_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Alan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ALAN")
                    .IsFixedLength();

                entity.Property(e => e.Baslangic).HasColumnName("BASLANGIC");

                entity.Property(e => e.Field)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FIELD")
                    .IsFixedLength();

                entity.Property(e => e.Sistem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SISTEM");

                entity.Property(e => e.Uzunluk).HasColumnName("UZUNLUK");
            });

            modelBuilder.Entity<Stdrapor>(entity =>
            {
                entity.HasKey(e => e.Idkodu);

                entity.ToTable("STDRAPOR");

                entity.HasIndex(e => e.Aciklama, "STDRAPOR_IDX1");

                entity.HasIndex(e => e.Adi, "STDRAPOR_IDX2");

                entity.Property(e => e.Idkodu)
                    .ValueGeneratedNever()
                    .HasColumnName("IDKODU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Adi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ADI");
            });

            modelBuilder.Entity<Sube>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.SubeKodu });

                entity.ToTable("SUBE");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.SubeKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUBE_KODU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.SubeAdi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SUBE_ADI");
            });

            modelBuilder.Entity<Tablo>(entity =>
            {
                entity.HasKey(e => e.Adi);

                entity.ToTable("TABLO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Izahat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IZAHAT");

                entity.Property(e => e.Sec)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SEC")
                    .IsFixedLength();

                entity.Property(e => e.Turu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .HasDefaultValueSql("('GENEL')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Takvim>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("TAKVIM");

                entity.HasIndex(e => new { e.Srkodu, e.Pskodu, e.Tarih }, "TAKVIM_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Pskodu).HasColumnName("PSKODU");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<Tarihler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TARIHLER");

                entity.Property(e => e.AyAd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AyIlkGun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AySonGun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BuAy)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BuHafta)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BuYil)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormatliBugun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GecenAyBugun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GecenHaftaBugun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GecenYil)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GecenYilBuAy)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GecenYilBuHafta)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GecenYilBugun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GunAd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HaftaIlkGun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HaftaSonGun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.TarihAd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YilIlkGun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.YilSonGun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblShiftPlu>(entity =>
            {
                entity.ToTable("tblShiftPlus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ShiftPlusName).HasMaxLength(20);
            });

            modelBuilder.Entity<Terminal>(entity =>
            {
                entity.HasKey(e => e.Kodu);

                entity.ToTable("TERMINAL");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KODU")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<Thpuan1>(entity =>
            {
                entity.HasKey(e => new { e.Idno, e.Prsicil, e.Clkodu });

                entity.ToTable("THPUAN1");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Ay).HasColumnName("AY");

                entity.Property(e => e.Bastar)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTAR");

                entity.Property(e => e.Bittar)
                    .HasColumnType("datetime")
                    .HasColumnName("BITTAR");

                entity.Property(e => e.Sure)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SURE");

                entity.Property(e => e.Topgun).HasColumnName("TOPGUN");

                entity.Property(e => e.Yil).HasColumnName("YIL");
            });

            modelBuilder.Entity<TmpKartsorgu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_KARTSORGU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Iscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISCIKT");

                entity.Property(e => e.Isgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISGIRT");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Keycode).HasColumnName("KEYCODE");

                entity.Property(e => e.PiCardid).HasColumnName("PI_CARDID");

                entity.Property(e => e.PiIdno).HasColumnName("PI_IDNO");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SIFRE");

                entity.Property(e => e.Sirket).HasColumnName("SIRKET");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");
            });

            modelBuilder.Entity<TmpPerliste>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_PERLISTE");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Adres)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("ADRES");

                entity.Property(e => e.Adril)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ADRIL");

                entity.Property(e => e.Adrilce)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADRILCE");

                entity.Property(e => e.Aktif)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AKTIF");

                entity.Property(e => e.Cinsyt)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CINSYT");

                entity.Property(e => e.Depadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPADI");

                entity.Property(e => e.Depart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEPART");

                entity.Property(e => e.Dogtar)
                    .HasColumnType("datetime")
                    .HasColumnName("DOGTAR");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gsm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("GSM");

                entity.Property(e => e.Iscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISCIKT");

                entity.Property(e => e.Isgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISGIRT");

                entity.Property(e => e.Kadro)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KADRO");

                entity.Property(e => e.Kangrb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KANGRB");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Kisitlama)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KISITLAMA");

                entity.Property(e => e.Kod1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KOD1");

                entity.Property(e => e.Kod2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KOD2");

                entity.Property(e => e.Kredi).HasColumnName("KREDI");

                entity.Property(e => e.Meslek)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MESLEK");

                entity.Property(e => e.Pertip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP");

                entity.Property(e => e.PiCardid).HasColumnName("PI_CARDID");

                entity.Property(e => e.PiIdno).HasColumnName("PI_IDNO");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SIFRE");

                entity.Property(e => e.Siradi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SIRADI");

                entity.Property(e => e.Sirket).HasColumnName("SIRKET");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Tckmno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TCKMNO");

                entity.Property(e => e.Tel1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TEL1");

                entity.Property(e => e.Tel2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TEL2");

                entity.Property(e => e.Yetkituru).HasColumnName("YETKITURU");
            });

            modelBuilder.Entity<Translog>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("TRANSLOG");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Cihaz)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZ")
                    .IsFixedLength();

                entity.Property(e => e.Gckodu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GCKODU")
                    .IsFixedLength();

                entity.Property(e => e.Islzamani)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLZAMANI");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Neden).HasColumnName("NEDEN");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Sistem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SISTEM");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Turu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TURU");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<Ucret1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("UCRET1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Ayucr).HasColumnName("AYUCR");

                entity.Property(e => e.Banka)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BANKA");

                entity.Property(e => e.DirektEndirekt)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DIREKT_ENDIREKT");

                entity.Property(e => e.Hesap)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HESAP");

                entity.Property(e => e.Iban)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IBAN");

                entity.Property(e => e.Il)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IL");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Saatucr).HasColumnName("SAATUCR");

                entity.Property(e => e.Send)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SEND")
                    .IsFixedLength();

                entity.Property(e => e.Sgkad)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SGKAD");

                entity.Property(e => e.Sgkno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SGKNO");

                entity.Property(e => e.Sgktur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SGKTUR");

                entity.Property(e => e.Sosyar)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SOSYAR")
                    .IsFixedLength();

                entity.Property(e => e.Sube)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SUBE");

                entity.Property(e => e.Yolpar)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("YOLPAR")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Varcali>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("VARCALIS");

                entity.HasIndex(e => new { e.Srkodu, e.Vrkodu, e.Clkodu }, "VARCALIS_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT")
                    .HasDefaultValueSql("('1899-12-30 00:00:00')");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT")
                    .HasDefaultValueSql("('1899-12-30 00:00:00')");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Durum)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DURUM")
                    .IsFixedLength();

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<Vardiya>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("VARDIYA");

                entity.HasIndex(e => new { e.Turu, e.Grup, e.Idno }, "VARDIYA_IDX1");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Arefe).HasColumnName("AREFE");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Erktol)
                    .HasColumnType("datetime")
                    .HasColumnName("ERKTOL");

                entity.Property(e => e.Gectol)
                    .HasColumnType("datetime")
                    .HasColumnName("GECTOL");

                entity.Property(e => e.Grup).HasColumnName("GRUP");

                entity.Property(e => e.Haftat).HasColumnName("HAFTAT");

                entity.Property(e => e.HftTuru)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HFT_TURU");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.KntBassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("KNT_BASSAAT");

                entity.Property(e => e.KntBitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("KNT_BITSAAT");

                entity.Property(e => e.KntDagitimDerece).HasColumnName("KNT_DAGITIM_DERECE");

                entity.Property(e => e.KntErkensure)
                    .HasColumnType("datetime")
                    .HasColumnName("KNT_ERKENSURE");

                entity.Property(e => e.KntGecsure)
                    .HasColumnType("datetime")
                    .HasColumnName("KNT_GECSURE");

                entity.Property(e => e.KntMaxclim)
                    .HasColumnType("datetime")
                    .HasColumnName("KNT_MAXCLIM");

                entity.Property(e => e.KntMesaiDerece).HasColumnName("KNT_MESAI_DERECE");

                entity.Property(e => e.KntYmkSure)
                    .HasColumnType("datetime")
                    .HasColumnName("KNT_YMK_SURE");

                entity.Property(e => e.Maxclim)
                    .HasColumnType("datetime")
                    .HasColumnName("MAXCLIM");

                entity.Property(e => e.TrnKod1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRN_KOD1");

                entity.Property(e => e.TrnKod2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRN_KOD2");

                entity.Property(e => e.TrnKod3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRN_KOD3");

                entity.Property(e => e.TrnKod4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRN_KOD4");

                entity.Property(e => e.TrnKod5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRN_KOD5");

                entity.Property(e => e.Turu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VardiyaMecburiZaman>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("VARDIYA_MECBURI_ZAMAN");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<Vargrup>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Kodu });

                entity.ToTable("VARGRUP");

                entity.HasIndex(e => e.Idno, "VARGRUP_IDX1");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI")
                    .IsFixedLength();

                entity.Property(e => e.Gndsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("GNDSAAT");

                entity.Property(e => e.Gndtipi)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GNDTIPI")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");
            });

            modelBuilder.Entity<Varhaked>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("VARHAKED");

                entity.HasIndex(e => new { e.Srkodu, e.Vrkodu, e.Clkodu }, "VARHAKED_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Haksure)
                    .HasColumnType("datetime")
                    .HasColumnName("HAKSURE");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Maxsure)
                    .HasColumnType("datetime")
                    .HasColumnName("MAXSURE");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<VarhakedZaman>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("VARHAKED_ZAMAN");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.IslemTuru)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISLEM_TURU");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<Vartol>(entity =>
            {
                entity.HasKey(e => new { e.Idno, e.Srkodu, e.Vgkodu });

                entity.ToTable("VARTOL");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Vgkodu).HasColumnName("VGKODU");

                entity.Property(e => e.Baserkt)
                    .HasColumnType("datetime")
                    .HasColumnName("BASERKT");

                entity.Property(e => e.Basgect)
                    .HasColumnType("datetime")
                    .HasColumnName("BASGECT");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Biterkt)
                    .HasColumnType("datetime")
                    .HasColumnName("BITERKT");

                entity.Property(e => e.Bitgect)
                    .HasColumnType("datetime")
                    .HasColumnName("BITGECT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Vrkodu).HasColumnName("VRKODU");
            });

            modelBuilder.Entity<VartolTerminal>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("VARTOL_TERMINAL");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Baserkt)
                    .HasColumnType("datetime")
                    .HasColumnName("BASERKT");

                entity.Property(e => e.Basgect)
                    .HasColumnType("datetime")
                    .HasColumnName("BASGECT");

                entity.Property(e => e.BaslamaTolerans).HasColumnName("BASLAMA_TOLERANS");

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Biterkt)
                    .HasColumnType("datetime")
                    .HasColumnName("BITERKT");

                entity.Property(e => e.Bitgect)
                    .HasColumnType("datetime")
                    .HasColumnName("BITGECT");

                entity.Property(e => e.BitisTolerans).HasColumnName("BITIS_TOLERANS");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.TerminalNo).HasColumnName("TERMINAL_NO");
            });

            modelBuilder.Entity<Vartran>(entity =>
            {
                entity.HasKey(e => e.Dosya);

                entity.ToTable("VARTRANS");

                entity.Property(e => e.Dosya)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DOSYA");

                entity.Property(e => e.Satir).HasColumnName("SATIR");

                entity.Property(e => e.Sicil).HasColumnName("SICIL");

                entity.Property(e => e.Sutun).HasColumnName("SUTUN");

                entity.Property(e => e.Yedek)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("YEDEK");
            });

            modelBuilder.Entity<Vpdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VPDetail");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Adres)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("ADRES");

                entity.Property(e => e.Depadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPADI");

                entity.Property(e => e.Depkodu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEPKODU")
                    .IsFixedLength();

                entity.Property(e => e.DurakAdi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DURAK_ADI");

                entity.Property(e => e.DurakKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DURAK_KODU");

                entity.Property(e => e.Il)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("IL");

                entity.Property(e => e.Iscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISCIKT");

                entity.Property(e => e.Isgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISGIRT");

                entity.Property(e => e.Postaadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTAADI");

                entity.Property(e => e.Postakodu).HasColumnName("POSTAKODU");

                entity.Property(e => e.Postaturu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POSTATURU");

                entity.Property(e => e.Servisadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERVISADI");

                entity.Property(e => e.Serviskodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SERVISKODU")
                    .IsFixedLength();

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");
            });

            modelBuilder.Entity<Vwtakvim1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWTAKVIM1");

                entity.Property(e => e.Posta100).HasColumnName("POSTA100");

                entity.Property(e => e.Posta110).HasColumnName("POSTA110");

                entity.Property(e => e.Posta111).HasColumnName("POSTA111");

                entity.Property(e => e.Posta140).HasColumnName("POSTA140");

                entity.Property(e => e.Posta141).HasColumnName("POSTA141");

                entity.Property(e => e.Posta150).HasColumnName("POSTA150");

                entity.Property(e => e.Posta151).HasColumnName("POSTA151");

                entity.Property(e => e.Posta152).HasColumnName("POSTA152");

                entity.Property(e => e.Posta155).HasColumnName("POSTA155");

                entity.Property(e => e.Posta156).HasColumnName("POSTA156");

                entity.Property(e => e.Posta157).HasColumnName("POSTA157");

                entity.Property(e => e.Posta41).HasColumnName("POSTA41");

                entity.Property(e => e.Posta42).HasColumnName("POSTA42");

                entity.Property(e => e.Posta43).HasColumnName("POSTA43");

                entity.Property(e => e.Posta44).HasColumnName("POSTA44");

                entity.Property(e => e.Posta45).HasColumnName("POSTA45");

                entity.Property(e => e.Posta46).HasColumnName("POSTA46");

                entity.Property(e => e.Posta47).HasColumnName("POSTA47");

                entity.Property(e => e.Posta50).HasColumnName("POSTA50");

                entity.Property(e => e.Posta55).HasColumnName("POSTA55");

                entity.Property(e => e.Posta56).HasColumnName("POSTA56");

                entity.Property(e => e.Posta60).HasColumnName("POSTA60");

                entity.Property(e => e.Posta61).HasColumnName("POSTA61");

                entity.Property(e => e.Posta62).HasColumnName("POSTA62");

                entity.Property(e => e.Posta63).HasColumnName("POSTA63");

                entity.Property(e => e.Posta64).HasColumnName("POSTA64");

                entity.Property(e => e.Posta65).HasColumnName("POSTA65");

                entity.Property(e => e.Posta66).HasColumnName("POSTA66");

                entity.Property(e => e.Posta67).HasColumnName("POSTA67");

                entity.Property(e => e.Posta68).HasColumnName("POSTA68");

                entity.Property(e => e.Posta71).HasColumnName("POSTA71");

                entity.Property(e => e.Posta72).HasColumnName("POSTA72");

                entity.Property(e => e.Posta81).HasColumnName("POSTA81");

                entity.Property(e => e.Posta90).HasColumnName("POSTA90");

                entity.Property(e => e.Posta91).HasColumnName("POSTA91");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");
            });

            modelBuilder.Entity<WrDildeger>(entity =>
            {
                entity.ToTable("WR_DILDEGER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deger)
                    .HasMaxLength(150)
                    .HasColumnName("DEGER");

                entity.Property(e => e.Dilid).HasColumnName("DILID");

                entity.Property(e => e.Textid).HasColumnName("TEXTID");
            });

            modelBuilder.Entity<WrDiller>(entity =>
            {
                entity.ToTable("WR_DILLER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIL");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KODU");

                entity.Property(e => e.Tarihformat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TARIHFORMAT");

                entity.Property(e => e.Text)
                    .HasMaxLength(50)
                    .HasColumnName("TEXT");
            });

            modelBuilder.Entity<WrDiltext>(entity =>
            {
                entity.ToTable("WR_DILTEXT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Text)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TEXT");
            });

            modelBuilder.Entity<WrLogPer>(entity =>
            {
                entity.HasKey(e => e.IdNo);

                entity.ToTable("WR_LOG_PER");

                entity.Property(e => e.Durum)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Sebep).HasMaxLength(4000);

                entity.Property(e => e.Sorgu).HasMaxLength(4000);

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<WrLogTbl>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("WR_LOG_TBL");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Isltarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("ISLTARIHI");

                entity.Property(e => e.Islturu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ISLTURU");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Sirket).HasColumnName("SIRKET");

                entity.Property(e => e.Tablo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TABLO");
            });

            modelBuilder.Entity<WrSpDeger>(entity =>
            {
                entity.HasKey(e => new { e.Kodu, e.Aciklama });

                entity.ToTable("WR_SP_DEGER");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Text)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TEXT");
            });

            modelBuilder.Entity<WrUserYetki>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Srkodu, e.Turu, e.Deger });

                entity.ToTable("WR_USER_YETKI");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");

                entity.Property(e => e.Deger)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<WrVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WR_VERSION");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<Yabdil1>(entity =>
            {
                entity.HasKey(e => new { e.Idno, e.Prsicil });

                entity.ToTable("YABDIL1");

                entity.HasIndex(e => new { e.Prsicil, e.Lsadi }, "YABDIL1_IDX1")
                    .IsUnique();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Anlama)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ANLAMA")
                    .IsFixedLength();

                entity.Property(e => e.Konusma)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("KONUSMA")
                    .IsFixedLength();

                entity.Property(e => e.Lsadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LSADI");

                entity.Property(e => e.Ogryer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OGRYER");

                entity.Property(e => e.Okuma)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("OKUMA")
                    .IsFixedLength();

                entity.Property(e => e.Yazma)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("YAZMA")
                    .IsFixedLength();

                entity.Property(e => e.Yili).HasColumnName("YILI");
            });

            modelBuilder.Entity<YdkGksHareketBo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YDK_GKS_HAREKET_BOS");

                entity.Property(e => e.Cihaz).HasColumnName("CIHAZ");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Keycode).HasColumnName("KEYCODE");

                entity.Property(e => e.Nedenkodu).HasColumnName("NEDENKODU");

                entity.Property(e => e.PiIdno).HasColumnName("PI_IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.ToplaTar)
                    .HasColumnType("datetime")
                    .HasColumnName("TOPLA_TAR");

                entity.Property(e => e.Yon).HasColumnName("YON");

                entity.Property(e => e.ZamanTrh)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN_TRH");
            });

            modelBuilder.Entity<YdkPersonel122032021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YDK_PERSONEL1_22032021");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Aktif)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AKTIF");

                entity.Property(e => e.Altdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ALTDEPART");

                entity.Property(e => e.Altdepart2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALTDEPART2");

                entity.Property(e => e.Altdepart3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALTDEPART3");

                entity.Property(e => e.Altdepart4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALTDEPART4");

                entity.Property(e => e.Altdeptar)
                    .HasColumnType("datetime")
                    .HasColumnName("ALTDEPTAR");

                entity.Property(e => e.Altdeptar2)
                    .HasColumnType("datetime")
                    .HasColumnName("ALTDEPTAR2");

                entity.Property(e => e.Altdeptar3)
                    .HasColumnType("datetime")
                    .HasColumnName("ALTDEPTAR3");

                entity.Property(e => e.Altdeptar4)
                    .HasColumnType("datetime")
                    .HasColumnName("ALTDEPTAR4");

                entity.Property(e => e.Amir1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMIR1");

                entity.Property(e => e.Amir2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMIR2");

                entity.Property(e => e.Amir3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMIR3");

                entity.Property(e => e.Amir4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMIR4");

                entity.Property(e => e.Amir5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMIR5");

                entity.Property(e => e.BirimKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIRIM_KODU");

                entity.Property(e => e.BirimTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("BIRIM_TARIHI");

                entity.Property(e => e.Cikndn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIKNDN")
                    .IsFixedLength();

                entity.Property(e => e.Depart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEPART")
                    .IsFixedLength();

                entity.Property(e => e.Deptar)
                    .HasColumnType("datetime")
                    .HasColumnName("DEPTAR");

                entity.Property(e => e.DomainUsername)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_USERNAME");

                entity.Property(e => e.Durak)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DURAK");

                entity.Property(e => e.DurakTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("DURAK_TARIHI");

                entity.Property(e => e.GecisYetkituru)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GECIS_YETKITURU");

                entity.Property(e => e.Gmyaka)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GMYAKA")
                    .IsFixedLength();

                entity.Property(e => e.Gorev)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GOREV")
                    .IsFixedLength();

                entity.Property(e => e.Gorevtar)
                    .HasColumnType("datetime")
                    .HasColumnName("GOREVTAR");

                entity.Property(e => e.GrupKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_KODU");

                entity.Property(e => e.GrupTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GRUP_TARIHI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Iscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISCIKT");

                entity.Property(e => e.Isgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISGIRT");

                entity.Property(e => e.Kadro)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KADRO")
                    .IsFixedLength();

                entity.Property(e => e.Kadrotar)
                    .HasColumnType("datetime")
                    .HasColumnName("KADROTAR");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Kisitlama)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KISITLAMA");

                entity.Property(e => e.Kod1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KOD1")
                    .IsFixedLength();

                entity.Property(e => e.Kod2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KOD2")
                    .IsFixedLength();

                entity.Property(e => e.Kredi).HasColumnName("KREDI");

                entity.Property(e => e.KrediBastar)
                    .HasColumnType("datetime")
                    .HasColumnName("KREDI_BASTAR");

                entity.Property(e => e.KrediBittar)
                    .HasColumnType("datetime")
                    .HasColumnName("KREDI_BITTAR");

                entity.Property(e => e.Krttar)
                    .HasColumnType("datetime")
                    .HasColumnName("KRTTAR");

                entity.Property(e => e.Masraf)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MASRAF");

                entity.Property(e => e.Masraftar)
                    .HasColumnType("datetime")
                    .HasColumnName("MASRAFTAR");

                entity.Property(e => e.Mesai)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MESAI")
                    .IsFixedLength();

                entity.Property(e => e.Meslek)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MESLEK")
                    .IsFixedLength();

                entity.Property(e => e.Meslektar)
                    .HasColumnType("datetime")
                    .HasColumnName("MESLEKTAR");

                entity.Property(e => e.OnySifre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONY_SIFRE");

                entity.Property(e => e.Pertip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP")
                    .IsFixedLength();

                entity.Property(e => e.Pertiptar)
                    .HasColumnType("datetime")
                    .HasColumnName("PERTIPTAR");

                entity.Property(e => e.PiCardid).HasColumnName("PI_CARDID");

                entity.Property(e => e.PiIdno).HasColumnName("PI_IDNO");

                entity.Property(e => e.Posta).HasColumnName("POSTA");

                entity.Property(e => e.Postar)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTAR");

                entity.Property(e => e.Puantb)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PUANTB")
                    .IsFixedLength();

                entity.Property(e => e.Servis)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SERVIS")
                    .IsFixedLength();

                entity.Property(e => e.Servistar)
                    .HasColumnType("datetime")
                    .HasColumnName("SERVISTAR");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SIFRE");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.SubeKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUBE_KODU");

                entity.Property(e => e.SubeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("SUBE_TARIHI");

                entity.Property(e => e.Tpgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("TPGIRT");

                entity.Property(e => e.Ucrettipi)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("UCRETTIPI");

                entity.Property(e => e.Ucretturu)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("UCRETTURU");

                entity.Property(e => e.Yetkituru).HasColumnName("YETKITURU");

                entity.Property(e => e.Yilizhesapt)
                    .HasColumnType("datetime")
                    .HasColumnName("YILIZHESAPT");
            });

            modelBuilder.Entity<Yetkiaylikonay>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("YETKIAYLIKONAY");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.EmailGonder).HasColumnName("EMAIL_GONDER");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.OnayKullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONAY_KULLANICI");
            });

            modelBuilder.Entity<Yetkidepart>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("YETKIDEPART");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Depart)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DEPART")
                    .IsFixedLength();

                entity.Property(e => e.Dpadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPADI");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Yetki)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("YETKI")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Yetkiform>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("YETKIFORM");

                entity.HasIndex(e => new { e.Kladi, e.Srkodu, e.Fmadi }, "YETKIFORM_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Fmadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FMADI");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Yetki)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("YETKI")
                    .HasDefaultValueSql("('EVET')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Yetkikayit>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("YETKIKAYIT");

                entity.HasIndex(e => new { e.Kladi, e.Srkodu, e.Tbadi, e.Aladi }, "YETKIKAYIT_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Aladi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ALADI")
                    .IsFixedLength();

                entity.Property(e => e.Deger1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER1");

                entity.Property(e => e.Deger2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEGER2");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Kriter)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KRITER")
                    .IsFixedLength();

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tbadi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TBADI")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Yetkikod>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("YETKIKOD");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Kod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KOD");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Turu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<Yetkimenu>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("YETKIMENU");

                entity.HasIndex(e => new { e.Kladi, e.Srkodu, e.Mnadi }, "YETKIMENU_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Mnadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MNADI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Yetki)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("YETKI")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Yetkisirket>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("YETKISIRKET");

                entity.HasIndex(e => new { e.Kladi, e.Srkodu, e.Dnadi }, "YETKISIRKET_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Dnadi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DNADI");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Yetki)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("YETKI")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Yetkitablo>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("YETKITABLO");

                entity.HasIndex(e => new { e.Kladi, e.Srkodu, e.Tbadi }, "YETKITABLO_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Degistir)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DEGISTIR")
                    .IsFixedLength();

                entity.Property(e => e.Ekle)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("EKLE")
                    .IsFixedLength();

                entity.Property(e => e.Goster)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("GOSTER")
                    .IsFixedLength();

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Sil)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SIL")
                    .IsFixedLength();

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tbadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TBADI");
            });

            modelBuilder.Entity<Yiliz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YILIZ");

                entity.Property(e => e.Barkod)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BARKOD");

                entity.Property(e => e.Gckodu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GCKODU")
                    .IsFixedLength();

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Linkid).HasColumnName("LINKID");

                entity.Property(e => e.Neden).HasColumnName("NEDEN");

                entity.Property(e => e.Otarih)
                    .HasColumnType("datetime")
                    .HasColumnName("OTARIH");

                entity.Property(e => e.Ozaman)
                    .HasColumnType("datetime")
                    .HasColumnName("OZAMAN");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Sistem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SISTEM");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Termkodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TERMKODU")
                    .IsFixedLength();

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<YilizMahsuptar>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Prsicil, e.MahsupTarihi });

                entity.ToTable("YILIZ_MAHSUPTAR");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.MahsupTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("MAHSUP_TARIHI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<Yilizhesap1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("YILIZHESAP1");

                entity.HasIndex(e => e.Prsicil, "YILIZHESAP1_IDX2");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Devir).HasColumnName("DEVIR");

                entity.Property(e => e.DevirYil).HasColumnName("DEVIR_YIL");

                entity.Property(e => e.Hakedilen).HasColumnName("HAKEDILEN");

                entity.Property(e => e.Hesaptarih)
                    .HasColumnType("datetime")
                    .HasColumnName("HESAPTARIH");

                entity.Property(e => e.Ilave).HasColumnName("ILAVE");

                entity.Property(e => e.IptalDevir).HasColumnName("IPTAL_DEVIR");

                entity.Property(e => e.KidemAy).HasColumnName("KIDEM_AY");

                entity.Property(e => e.KidemGun).HasColumnName("KIDEM_GUN");

                entity.Property(e => e.KidemYil).HasColumnName("KIDEM_YIL");

                entity.Property(e => e.Kullanilan).HasColumnName("KULLANILAN");

                entity.Property(e => e.Mahsup).HasColumnName("MAHSUP");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Toplamkalan).HasColumnName("TOPLAMKALAN");

                entity.Property(e => e.Yil).HasColumnName("YIL");

                entity.Property(e => e.Yildakalan).HasColumnName("YILDAKALAN");
            });

            modelBuilder.Entity<Yilizhuk>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("YILIZHUK");

                entity.HasIndex(e => new { e.Srkodu, e.Pertip }, "YILIZHUK_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Durum)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DURUM")
                    .IsFixedLength();

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.Pertip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP")
                    .IsFixedLength();

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");
            });

            modelBuilder.Entity<Yilizkdm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YILIZKDM");

                entity.HasIndex(e => new { e.Srkodu, e.Pertip }, "YILIZKDM_IDX1");

                entity.Property(e => e.Hakgun).HasColumnName("HAKGUN");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Ilkyil).HasColumnName("ILKYIL");

                entity.Property(e => e.Kriter)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("KRITER")
                    .IsFixedLength();

                entity.Property(e => e.Pertip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP")
                    .IsFixedLength();

                entity.Property(e => e.Sonyil).HasColumnName("SONYIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<Yilizkul>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YILIZKUL");

                entity.HasIndex(e => new { e.Srkodu, e.Prsicil, e.Bastarih }, "PK_YILIZKUL");

                entity.Property(e => e.Ay)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AY");

                entity.Property(e => e.Bastarih)
                    .HasColumnType("datetime")
                    .HasColumnName("BASTARIH");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Kullan).HasColumnName("KULLAN");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Turu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .HasDefaultValueSql("('Denkleştirme')");

                entity.Property(e => e.Yil)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("YIL");
            });

            modelBuilder.Entity<Yilizpar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YILIZPAR");

                entity.HasIndex(e => new { e.Srkodu, e.Pertip }, "YILIZPAR_IDX1")
                    .IsUnique();

                entity.Property(e => e.Bastar)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BASTAR");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.DevirIptal).HasColumnName("DEVIR_IPTAL");

                entity.Property(e => e.DevirIptalAy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVIR_IPTAL_AY");

                entity.Property(e => e.DevirIptalGun).HasColumnName("DEVIR_IPTAL_GUN");

                entity.Property(e => e.Devirvar)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DEVIRVAR");

                entity.Property(e => e.GirisYiliHesapla).HasColumnName("GIRIS_YILI_HESAPLA");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Pertip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP")
                    .IsFixedLength();

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.YilbasiHakedis).HasColumnName("YILBASI_HAKEDIS");
            });

            modelBuilder.Entity<YilizparIznkod>(entity =>
            {
                entity.HasKey(e => new { e.Srkodu, e.Pertip, e.Clkodu });

                entity.ToTable("YILIZPAR_IZNKOD");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Pertip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIP");

                entity.Property(e => e.Clkodu).HasColumnName("CLKODU");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Sure)
                    .HasColumnType("datetime")
                    .HasColumnName("SURE");
            });

            modelBuilder.Entity<YnCihazGrup>(entity =>
            {
                entity.HasKey(e => e.Kodu);

                entity.ToTable("Yn_CihazGrup");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Cihaz).HasColumnName("CIHAZ");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU")
                    .HasDefaultValueSql("('Pdks')");
            });

            modelBuilder.Entity<YnGrupCihaz>(entity =>
            {
                entity.HasKey(e => e.Kodu);

                entity.ToTable("Yn_GrupCihaz");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Cihaz).HasColumnName("CIHAZ");

                entity.Property(e => e.Cihazadi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CIHAZADI");

                entity.Property(e => e.Grupkodu).HasColumnName("GRUPKODU");
            });

            modelBuilder.Entity<YnIzin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Yn_Izin");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Neden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEDEN")
                    .IsFixedLength();

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TIPI");
            });

            modelBuilder.Entity<YnMola>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("Yn_Mola");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Baslama)
                    .HasColumnType("datetime")
                    .HasColumnName("BASLAMA");

                entity.Property(e => e.Bitis)
                    .HasColumnType("datetime")
                    .HasColumnName("BITIS");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<YnParametre>(entity =>
            {
                entity.HasKey(e => new { e.Kodu, e.Adi });

                entity.ToTable("Yn_Parametre");

                entity.Property(e => e.Adi)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Deger)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Idno).ValueGeneratedOnAdd();

                entity.Property(e => e.Kriter)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VeriText)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YnPer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Yn_Per");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Altdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ALTDEPART");

                entity.Property(e => e.Departman)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMAN")
                    .IsFixedLength();

                entity.Property(e => e.Gorev)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GOREV")
                    .IsFixedLength();

                entity.Property(e => e.Iscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISCIKT");

                entity.Property(e => e.Isgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISGIRT");

                entity.Property(e => e.Kadro)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KADRO")
                    .IsFixedLength();

                entity.Property(e => e.Kod1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KOD1")
                    .IsFixedLength();

                entity.Property(e => e.Kod2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KOD2")
                    .IsFixedLength();

                entity.Property(e => e.Meslek)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MESLEK")
                    .IsFixedLength();

                entity.Property(e => e.Pertipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIPI")
                    .IsFixedLength();

                entity.Property(e => e.Posta).HasColumnName("POSTA");

                entity.Property(e => e.Servis)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SERVIS")
                    .IsFixedLength();

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<YnPerView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Yn_Per_View");

                entity.Property(e => e.Adadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADADI");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Altdepart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ALTDEPART");

                entity.Property(e => e.Departman)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMAN")
                    .IsFixedLength();

                entity.Property(e => e.DpAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DP_ADI");

                entity.Property(e => e.Gorev)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GOREV")
                    .IsFixedLength();

                entity.Property(e => e.GrAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GR_ADI");

                entity.Property(e => e.Iscikt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISCIKT");

                entity.Property(e => e.Isgirt)
                    .HasColumnType("datetime")
                    .HasColumnName("ISGIRT");

                entity.Property(e => e.Kadro)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KADRO")
                    .IsFixedLength();

                entity.Property(e => e.KdAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KD_ADI");

                entity.Property(e => e.Kod1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KOD1")
                    .IsFixedLength();

                entity.Property(e => e.Kod2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KOD2")
                    .IsFixedLength();

                entity.Property(e => e.Meslek)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MESLEK")
                    .IsFixedLength();

                entity.Property(e => e.MsAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MS_ADI");

                entity.Property(e => e.Pertipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERTIPI")
                    .IsFixedLength();

                entity.Property(e => e.Posta).HasColumnName("POSTA");

                entity.Property(e => e.PsAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PS_ADI");

                entity.Property(e => e.PtAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PT_ADI");

                entity.Property(e => e.Servis)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SERVIS")
                    .IsFixedLength();

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.SrAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SR_ADI");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Unvan)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UNVAN");
            });

            modelBuilder.Entity<YnRapor>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Rpradi, e.Adi, e.Kriter });

                entity.ToTable("Yn_Rapor");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Rpradi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RPRADI");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Kriter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KRITER");

                entity.Property(e => e.Sira)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SIRA");
            });

            modelBuilder.Entity<YnUser>(entity =>
            {
                entity.HasKey(e => e.UserAdi);

                entity.ToTable("Yn_User");

                entity.Property(e => e.UserAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idno).ValueGeneratedOnAdd();

                entity.Property(e => e.Isim)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserSifre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Yetkili)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YnUserYetki>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Yn_UserYetki");

                entity.Property(e => e.Adi)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Idno).ValueGeneratedOnAdd();

                entity.Property(e => e.Kodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KODU");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Secim).HasColumnName("SECIM");

                entity.Property(e => e.Srkodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SRKODU");

                entity.Property(e => e.Turu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<YnVersiyon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Yn_Versiyon");

                entity.Property(e => e.Sira).HasColumnName("SIRA");
            });

            modelBuilder.Entity<YnView>(entity =>
            {
                entity.HasKey(e => new { e.Menu, e.Isim });

                entity.ToTable("Yn_View");

                entity.Property(e => e.Isim)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YnViewUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Yn_View_User");

                entity.Property(e => e.Isim)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kladi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KLAdi");
            });

            modelBuilder.Entity<YnYetki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Yn_Yetki");

                entity.Property(e => e.Adi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("KODU");

                entity.Property(e => e.Secim).HasColumnName("SECIM");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Turu)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("TURU");
            });

            modelBuilder.Entity<YnYmk>(entity =>
            {
                entity.HasKey(e => e.Kodu);

                entity.ToTable("Yn_Ymk");

                entity.Property(e => e.Kodu)
                    .ValueGeneratedNever()
                    .HasColumnName("KODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(100)
                    .HasColumnName("ADI")
                    .IsFixedLength();

                entity.Property(e => e.Bassaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BASSAAT");

                entity.Property(e => e.Bitsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("BITSAAT");

                entity.Property(e => e.Fiyati)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("FIYATI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<Ytdepbaz>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK_YT_DEPARTMAN");

                entity.ToTable("YTDEPBAZ");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Chzgrp).HasColumnName("CHZGRP");

                entity.Property(e => e.Depid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPID");

                entity.Property(e => e.Sirid).HasColumnName("SIRID");

                entity.Property(e => e.Zmngrp).HasColumnName("ZMNGRP");
            });

            modelBuilder.Entity<Ytgrper>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("YTGRPER");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Grpid).HasColumnName("GRPID");

                entity.Property(e => e.Sicil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SICIL");

                entity.Property(e => e.Sirket).HasColumnName("SIRKET");
            });

            modelBuilder.Entity<Ytgrup>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK_YETKI_GRP");

                entity.ToTable("YTGRUP");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Gradi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRADI");

                entity.Property(e => e.Oncelik).HasColumnName("ONCELIK");
            });

            modelBuilder.Entity<Ytgrupbaz>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK_YT_GRUP");

                entity.ToTable("YTGRUPBAZ");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Chzgrp).HasColumnName("CHZGRP");

                entity.Property(e => e.Grupid).HasColumnName("GRUPID");

                entity.Property(e => e.Zmngrp).HasColumnName("ZMNGRP");
            });

            modelBuilder.Entity<Ytperbaz>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK_YT_PERSONEL");

                entity.ToTable("YTPERBAZ");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Chzgrp).HasColumnName("CHZGRP");

                entity.Property(e => e.Sicil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SICIL");

                entity.Property(e => e.Sirket).HasColumnName("SIRKET");

                entity.Property(e => e.Zmngrp).HasColumnName("ZMNGRP");
            });

            modelBuilder.Entity<Yukumlu1>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("YUKUMLU1");

                entity.HasIndex(e => e.Prsicil, "YUKUMLU1_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Dogtrh)
                    .HasColumnType("datetime")
                    .HasColumnName("DOGTRH");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SOYAD");

                entity.Property(e => e.Yakinlik)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("YAKINLIK");
            });

            modelBuilder.Entity<Yuvardgl>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("YUVARDGL");

                entity.HasIndex(e => e.Yvkodu, "YUVARDGL_IDX1");

                entity.Property(e => e.Idno)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Ilkdeger).HasColumnName("ILKDEGER");

                entity.Property(e => e.Netdeger).HasColumnName("NETDEGER");

                entity.Property(e => e.Sondeger).HasColumnName("SONDEGER");

                entity.Property(e => e.Yvkodu).HasColumnName("YVKODU");
            });

            modelBuilder.Entity<Yuvarlama>(entity =>
            {
                entity.HasKey(e => e.Kodu);

                entity.ToTable("YUVARLAMA");

                entity.HasIndex(e => e.Idno, "YUVARLAMA_IDX1");

                entity.Property(e => e.Kodu)
                    .ValueGeneratedNever()
                    .HasColumnName("KODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");
            });

            modelBuilder.Entity<Zilzaman>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("ZILZAMAN");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Baslama)
                    .HasColumnType("datetime")
                    .HasColumnName("BASLAMA");

                entity.Property(e => e.Bitis)
                    .HasColumnType("datetime")
                    .HasColumnName("BITIS");

                entity.Property(e => e.Gun).HasColumnName("GUN");

                entity.Property(e => e.Zilgrup).HasColumnName("ZILGRUP");

                entity.Property(e => e.Zilmsg)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ZILMSG");
            });

            modelBuilder.Entity<Zmndlm>(entity =>
            {
                entity.HasKey(e => e.Num);

                entity.ToTable("ZMNDLM");

                entity.Property(e => e.Num).HasColumnName("NUM");

                entity.Property(e => e.Basla)
                    .HasColumnType("datetime")
                    .HasColumnName("BASLA");

                entity.Property(e => e.Bitis)
                    .HasColumnType("datetime")
                    .HasColumnName("BITIS");

                entity.Property(e => e.Gun)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("GUN");

                entity.Property(e => e.Gunkodu).HasColumnName("GUNKODU");

                entity.Property(e => e.Kere).HasColumnName("KERE");

                entity.Property(e => e.Zgr).HasColumnName("ZGR");
            });

            modelBuilder.Entity<Zmngrp>(entity =>
            {
                entity.HasKey(e => e.Kodu);

                entity.ToTable("ZMNGRP");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");
            });

            modelBuilder.Entity<ZyEhliyet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZY_EHLIYET");

                entity.Property(e => e.Ailesno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AILESNO");

                entity.Property(e => e.Anadi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ANADI");

                entity.Property(e => e.Babadi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BABADI");

                entity.Property(e => e.Belgeno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BELGENO");

                entity.Property(e => e.Ciltno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CILTNO");

                entity.Property(e => e.Dogumtar)
                    .HasColumnType("datetime")
                    .HasColumnName("DOGUMTAR");

                entity.Property(e => e.Dogumyeri)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DOGUMYERI");

                entity.Property(e => e.Duzenleyen)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DUZENLEYEN");

                entity.Property(e => e.Ehlno).HasColumnName("EHLNO");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Il)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IL");

                entity.Property(e => e.Ilce)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ILCE");

                entity.Property(e => e.Kangrubu)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KANGRUBU");

                entity.Property(e => e.Koy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("KOY");

                entity.Property(e => e.Sicilno).HasColumnName("SICILNO");

                entity.Property(e => e.Sirano)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIRANO");

                entity.Property(e => e.Vertar)
                    .HasColumnType("datetime")
                    .HasColumnName("VERTAR");

                entity.Property(e => e.Veryer)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VERYER");
            });

            modelBuilder.Entity<ZyFoto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZY_FOTO");

                entity.Property(e => e.Foto)
                    .HasColumnType("image")
                    .HasColumnName("FOTO");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Sicilno).HasColumnName("SICILNO");
            });

            modelBuilder.Entity<ZyGelenevrak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZY_GELENEVRAK");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA")
                    .IsFixedLength();

                entity.Property(e => e.Alicifirma)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ALICIFIRMA")
                    .IsFixedLength();

                entity.Property(e => e.Alicisahis)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ALICISAHIS")
                    .IsFixedLength();

                entity.Property(e => e.Evrakdurumu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EVRAKDURUMU")
                    .IsFixedLength();

                entity.Property(e => e.Evrakno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EVRAKNO");

                entity.Property(e => e.Evrakturu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EVRAKTURU")
                    .IsFixedLength();

                entity.Property(e => e.Gonfirma)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GONFIRMA")
                    .IsFixedLength();

                entity.Property(e => e.Gonsahis)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("GONSAHIS")
                    .IsFixedLength();

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Kargofirma)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("KARGOFIRMA")
                    .IsFixedLength();

                entity.Property(e => e.Kargosahis)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("KARGOSAHIS")
                    .IsFixedLength();

                entity.Property(e => e.Odemedurumu)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ODEMEDURUMU")
                    .IsFixedLength();

                entity.Property(e => e.Tarihsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIHSAAT");

                entity.Property(e => e.Tesalan)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TESALAN")
                    .IsFixedLength();

                entity.Property(e => e.Tesdurumu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TESDURUMU")
                    .HasDefaultValueSql("('BEKLEMEDE')")
                    .IsFixedLength();

                entity.Property(e => e.Teseden)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TESEDEN")
                    .IsFixedLength();

                entity.Property(e => e.Teslimalan)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TESLIMALAN");

                entity.Property(e => e.Testarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("TESTARIHI");

                entity.Property(e => e.Tutar)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TUTAR")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZyGidenevrak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZY_GIDENEVRAK");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA")
                    .IsFixedLength();

                entity.Property(e => e.Alicifirma)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ALICIFIRMA")
                    .IsFixedLength();

                entity.Property(e => e.Alicisahis)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ALICISAHIS")
                    .IsFixedLength();

                entity.Property(e => e.Evrakdurumu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EVRAKDURUMU")
                    .IsFixedLength();

                entity.Property(e => e.Evrakno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EVRAKNO");

                entity.Property(e => e.Evrakturu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EVRAKTURU")
                    .IsFixedLength();

                entity.Property(e => e.Gonfirma)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GONFIRMA")
                    .IsFixedLength();

                entity.Property(e => e.Gonsahis)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("GONSAHIS")
                    .IsFixedLength();

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Kargofirma)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("KARGOFIRMA")
                    .IsFixedLength();

                entity.Property(e => e.Kargosahis)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("KARGOSAHIS")
                    .IsFixedLength();

                entity.Property(e => e.Odemedurumu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ODEMEDURUMU")
                    .IsFixedLength();

                entity.Property(e => e.Tarihsaat)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIHSAAT");

                entity.Property(e => e.Tesalan)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TESALAN")
                    .IsFixedLength();

                entity.Property(e => e.Tesdurumu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TESDURUMU")
                    .HasDefaultValueSql("('BEKLEMEDE')")
                    .IsFixedLength();

                entity.Property(e => e.Teseden)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TESEDEN")
                    .IsFixedLength();

                entity.Property(e => e.Testarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("TESTARIHI");

                entity.Property(e => e.Tutar)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TUTAR")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZyHareket>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZY_HAREKET");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Kapi).HasColumnName("KAPI");

                entity.Property(e => e.Keycode).HasColumnName("KEYCODE");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.Yon).HasColumnName("YON");

                entity.Property(e => e.Zyid).HasColumnName("ZYID");
            });

            modelBuilder.Entity<ZyKayit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ZY_KAYIT");

                entity.Property(e => e.Cihaz).HasColumnName("CIHAZ");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Nedenkodu).HasColumnName("NEDENKODU");

                entity.Property(e => e.PiIdno).HasColumnName("PI_IDNO");

                entity.Property(e => e.Prsicil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRSICIL");

                entity.Property(e => e.Srkodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SRKODU");

                entity.Property(e => e.Yon).HasColumnName("YON");

                entity.Property(e => e.ZamnTrh)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMN_TRH");
            });

            modelBuilder.Entity<ZyKimlik>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZY_KIMLIK");

                entity.Property(e => e.Adi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Ailesno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AILESNO");

                entity.Property(e => e.Anadi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ANADI");

                entity.Property(e => e.Babadi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BABADI");

                entity.Property(e => e.Ciltno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CILTNO");

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CINSIYET");

                entity.Property(e => e.Dini)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DINI");

                entity.Property(e => e.Dogumtar)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DOGUMTAR");

                entity.Property(e => e.Dogumyeri)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DOGUMYERI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Il)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IL");

                entity.Property(e => e.Ilce)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ILCE");

                entity.Property(e => e.Kmno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KMNO");

                entity.Property(e => e.Koy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("KOY");

                entity.Property(e => e.Medenihal)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MEDENIHAL");

                entity.Property(e => e.Serino)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SERINO");

                entity.Property(e => e.Sicilno).HasColumnName("SICILNO");

                entity.Property(e => e.Sirano)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIRANO");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Tckimlik)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TCKIMLIK");

                entity.Property(e => e.Verneden)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VERNEDEN");

                entity.Property(e => e.Vertar)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VERTAR");

                entity.Property(e => e.Veryer)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VERYER");
            });

            modelBuilder.Entity<ZyKulchzgrp>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Chzkodu });

                entity.ToTable("ZY_KULCHZGRP");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(20)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Chzkodu)
                    .HasMaxLength(10)
                    .HasColumnName("CHZKODU")
                    .IsFixedLength();

                entity.Property(e => e.Chzadi)
                    .HasMaxLength(50)
                    .HasColumnName("CHZADI")
                    .IsFixedLength();

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<ZyKullanici>(entity =>
            {
                entity.HasKey(e => e.Kladi);

                entity.ToTable("ZY_KULLANICI");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .HasColumnName("ACIKLAMA")
                    .IsFixedLength();

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(20)
                    .HasColumnName("SIFRE")
                    .IsFixedLength();

                entity.Property(e => e.Yetki)
                    .HasMaxLength(5)
                    .HasColumnName("YETKI")
                    .HasDefaultValueSql("(N'HAYIR')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZyKulzmngrp>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Zmnkodu });

                entity.ToTable("ZY_KULZMNGRP");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(20)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Zmnkodu)
                    .HasMaxLength(10)
                    .HasColumnName("ZMNKODU")
                    .IsFixedLength();

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Zmnadi)
                    .HasMaxLength(50)
                    .HasColumnName("ZMNADI")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZyLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZY_LOG");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Islem)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ISLEM");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("KLADI");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasColumnName("ZAMAN");
            });

            modelBuilder.Entity<ZyMailbilgi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZY_MAILBILGI");

                entity.Property(e => e.Departman)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMAN");

                entity.Property(e => e.Disfirma)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DISFIRMA");

                entity.Property(e => e.Dissahis)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DISSAHIS");

                entity.Property(e => e.Durum)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DURUM")
                    .HasDefaultValueSql("('BEKLEMEDE')");

                entity.Property(e => e.Firma)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("FIRMA");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Islem)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ISLEM");

                entity.Property(e => e.Mail)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("MAIL");

                entity.Property(e => e.Personel)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("PERSONEL");

                entity.Property(e => e.Sayi).HasColumnName("SAYI");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");
            });

            modelBuilder.Entity<ZyMailliste>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZY_MAILLISTE");

                entity.Property(e => e.ArcBilgi)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ARC_BILGI")
                    .HasDefaultValueSql("('EVET')");

                entity.Property(e => e.Deger)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEGER");

                entity.Property(e => e.EvrBilgi)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("EVR_BILGI")
                    .HasDefaultValueSql("('EVET')");

                entity.Property(e => e.GccKart)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("GCC_KART")
                    .HasDefaultValueSql("('EVET')");

                entity.Property(e => e.Mailadres)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("MAILADRES");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TIPI");

                entity.Property(e => e.ZyrBilgi)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ZYR_BILGI")
                    .HasDefaultValueSql("('EVET')");
            });

            modelBuilder.Entity<ZyMailparam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZY_MAILPARAM");

                entity.Property(e => e.ArcBilgi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ARC_BILGI")
                    .HasDefaultValueSql("('EVET')");

                entity.Property(e => e.EvrBilgi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EVR_BILGI")
                    .HasDefaultValueSql("('EVET')");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HOSTNAME");

                entity.Property(e => e.Mailgonder)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAILGONDER");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Portno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PORTNO");

                entity.Property(e => e.Sayi).HasColumnName("SAYI");

                entity.Property(e => e.Sure).HasColumnName("SURE");

                entity.Property(e => e.Username)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.ZyrBilgi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ZYR_BILGI")
                    .HasDefaultValueSql("('EVET')");
            });

            modelBuilder.Entity<ZyPiziChz>(entity =>
            {
                entity.HasKey(e => new { e.Adi, e.Ip });

                entity.ToTable("ZY_PIZI_CHZ");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Ip)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.Port)
                    .HasColumnName("PORT")
                    .HasDefaultValueSql("((4370))");
            });

            modelBuilder.Entity<ZyPizikulchzgrp>(entity =>
            {
                entity.HasKey(e => new { e.Kladi, e.Chzkodu });

                entity.ToTable("ZY_PIZIKULCHZGRP");

                entity.Property(e => e.Kladi)
                    .HasMaxLength(20)
                    .HasColumnName("KLADI")
                    .IsFixedLength();

                entity.Property(e => e.Chzkodu)
                    .HasMaxLength(10)
                    .HasColumnName("CHZKODU")
                    .IsFixedLength();

                entity.Property(e => e.Chzadi)
                    .HasMaxLength(50)
                    .HasColumnName("CHZADI")
                    .IsFixedLength();

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");
            });

            modelBuilder.Entity<ZyPiziyetki>(entity =>
            {
                entity.HasKey(e => new { e.Zyid, e.Cihaz });

                entity.ToTable("ZY_PIZIYETKI");

                entity.Property(e => e.Zyid).HasColumnName("ZYID");

                entity.Property(e => e.Cihaz).HasColumnName("CIHAZ");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADI");
            });

            modelBuilder.Entity<ZyRuhsat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZY_RUHSAT");

                entity.Property(e => e.Adres)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ADRES");

                entity.Property(e => e.Babadi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BABADI");

                entity.Property(e => e.Cinsi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CINSI");

                entity.Property(e => e.Dogumyeri)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DOGUMYERI");

                entity.Property(e => e.Dogumyili)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DOGUMYILI");

                entity.Property(e => e.Idno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNO");

                entity.Property(e => e.IlIlce)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IL_ILCE");

                entity.Property(e => e.Isim)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ISIM");

                entity.Property(e => e.Markasi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MARKASI");

                entity.Property(e => e.Modeli)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MODELI");

                entity.Property(e => e.Plakasi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PLAKASI");

                entity.Property(e => e.Rengi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RENGI");

                entity.Property(e => e.Sicilno).HasColumnName("SICILNO");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TIPI");
            });

            modelBuilder.Entity<ZyTanim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZY_TANIM");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.CksTarih)
                    .HasColumnType("datetime")
                    .HasColumnName("CKS_TARIH");

                entity.Property(e => e.Firma)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("FIRMA");

                entity.Property(e => e.GrsTarih)
                    .HasColumnType("datetime")
                    .HasColumnName("GRS_TARIH");

                entity.Property(e => e.Isim)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ISIM");

                entity.Property(e => e.Kartno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KARTNO");

                entity.Property(e => e.Sicil).HasColumnName("SICIL");

                entity.Property(e => e.ZDepartman)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Z_DEPARTMAN");

                entity.Property(e => e.ZIsim)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Z_ISIM");

                entity.Property(e => e.ZSicil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Z_SICIL");

                entity.Property(e => e.ZSirket)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Z_SIRKET");

                entity.Property(e => e.ZyPlaka)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZY_PLAKA");

                entity.Property(e => e.Zyid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ZYID");
            });

            modelBuilder.Entity<ZyVersiyon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZY_VERSIYON");

                entity.Property(e => e.Versiyon)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VERSIYON")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZyYetki>(entity =>
            {
                entity.HasKey(e => new { e.Zyid, e.Kapigrup, e.Zamangrup });

                entity.ToTable("ZY_YETKI");

                entity.Property(e => e.Zyid).HasColumnName("ZYID");

                entity.Property(e => e.Kapigrup).HasColumnName("KAPIGRUP");

                entity.Property(e => e.Zamangrup).HasColumnName("ZAMANGRUP");
            });

            modelBuilder.Entity<ZyZiyaretci>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZY_ZIYARETCI");

                entity.Property(e => e.Adres1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADRES1");

                entity.Property(e => e.Adres2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADRES2");

                entity.Property(e => e.Departman)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMAN");

                entity.Property(e => e.Firma)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FIRMA");

                entity.Property(e => e.Gsm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("GSM");

                entity.Property(e => e.Ilce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ILCE");

                entity.Property(e => e.Isim)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ISIM");

                entity.Property(e => e.Sehir)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEHIR");

                entity.Property(e => e.Sicilno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SICILNO");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TELEFON");

                entity.Property(e => e.Tipi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TIPI")
                    .HasDefaultValueSql("('ZIYARETCI')");

                entity.Property(e => e.Yasakli)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YASAKLI")
                    .HasDefaultValueSql("('HAYIR')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
