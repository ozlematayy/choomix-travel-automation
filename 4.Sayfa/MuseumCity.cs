using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Sayfa
{

    public enum MuseumName
    {
        GöremeAçıkHavaMüzesi,
        KaymaklıYeraltıŞehri,
        StJeanKilisesi,
        AçıksarayÖrenyeri,
        NevsehirMuzesi,
        ZelveAçıkHavaMüzesi,

        TopkapıSarayı,
        İstanbulArkeolojiMüzesi,
        DenizMüzesi,
        YerebatanSarnıcı,
        OyuncakMüzesi,
        KlasikOtmobilMüzesi,

        AntalyaMuzesi,
        SunaİnanKaleiçiMüzesi,
        DenizBiyolojisiMüzesi,
        Sandland,
        HababamSınıfıMüzesi,
        EtnografyaMüzesi,

        MardinMüzesi,
        SakıpSabancıKentMüzesi,
        EğitimTarihiMüzesiArtuklu,
        MidyatKonukevi,
        MorBehnamKırklıKilisesi,
        DaraAntikKenti,

        SümelaManastırı,
        TrabzonMüzesi,
        AtatürkKöşkü,
        OrtahisarTarihMüzesi,
        EdebiyatMüzesi,
        TrabzonSporMüzesi,

        AtatürkveKurtuluşSavaşıMüzesiAnıtkabir,
        CumhuriyetMüzesi,
        KurtuluşSavaşıMüzesi,
        AnadoluMedeniyetleriMüzesi,
        EtnografyaMuzesiAnkara,
        ODTÜBilimveTeknolojiMüzesi,

        BergamaMuseum,
        AlteNationalGalerie,
        BodeMuseum,
        AltePinakothek,
        StädelMuseum,
        SenckenbergMuseum,

        GalleriaBorghese,
        Uffizi,
        PittiPalace,
        CaptaliniMuseum,
        Pantheon,
        GalileoMuseum,

        MuseoNacionaldeArteDecorativo,
        BenitoQuinquelaMartínMuseum,
        MuseoDeLaPlata,
        XulSolarMuseum,
        AmaliaLacrozdeFortabatArtCollection,
        MuseodeArteContemporáneodeSalta,

        TokyoNationalMuseum,
        TeamLabPlanets,
        OharaMuseumofArt,
        MihoMuseum,
        PolaMuseumofArt,
        TokyoNationalMuseumHeiseikan,

        TheFramMuseum,
        NorwegianMaritimeMuseum,
        NobelPeaceCenter,
        OscarshallPalace,
        KistefosMuseum,
        TheNorwegianMuseumofCulturalHistory,

    }


    public class MuseumCity : BaseClass
    {


        public String txt1 = "Kişi Sayısı: ";
        public String txt2 = "Tarih:";
        public String txt3 = "Bütçe:";
        public String txt4 = "Sirala";
        public String txt5 = "Temizle";
        public String txt6 = "Sepete Ekle";
        public String txt7 = "Ödeme";

        public String Day = "Her gün Açık.";
        public String WeekDay = "Hafta İçi Açık.";


        public String text1 = "Giriş Ücreti: ";
        public String text2 = "Nasıl Gidilir: ";


        public string MuseumName;
        public int PriceM;
        public int Total = 0;
        public int Person;



        public MuseumCity()
        {

        }


        public void Kayıt(MuseumName name)
        {

            switch (name)
            {

                case Sayfa.MuseumName.Pantheon:
                case Sayfa.MuseumName.ODTÜBilimveTeknolojiMüzesi:
                case Sayfa.MuseumName.EdebiyatMüzesi:
                case Sayfa.MuseumName.EtnografyaMüzesi:
                case Sayfa.MuseumName.HababamSınıfıMüzesi:
                case Sayfa.MuseumName.AçıksarayÖrenyeri:
                case Sayfa.MuseumName.NevsehirMuzesi:
                case Sayfa.MuseumName.DaraAntikKenti:
                case Sayfa.MuseumName.EğitimTarihiMüzesiArtuklu:
                    this.Price = 0;
                    break;

                case Sayfa.MuseumName.AltePinakothek:
                    this.Price = 5;
                    break;

                case Sayfa.MuseumName.SenckenbergMuseum:
                case Sayfa.MuseumName.MardinMüzesi:
                case Sayfa.MuseumName.SunaİnanKaleiçiMüzesi:
                case Sayfa.MuseumName.ZelveAçıkHavaMüzesi:
                case Sayfa.MuseumName.AtatürkveKurtuluşSavaşıMüzesiAnıtkabir:
                case Sayfa.MuseumName.OrtahisarTarihMüzesi:
                case Sayfa.MuseumName.TrabzonMüzesi:
                case Sayfa.MuseumName.SakıpSabancıKentMüzesi:
                case Sayfa.MuseumName.MidyatKonukevi:
                case Sayfa.MuseumName.DenizBiyolojisiMüzesi:
                case Sayfa.MuseumName.StJeanKilisesi:
                    this.Price = 7;
                    break;

                case Sayfa.MuseumName.CaptaliniMuseum:
                case Sayfa.MuseumName.GalileoMuseum:
                case Sayfa.MuseumName.GalleriaBorghese:
                case Sayfa.MuseumName.AtatürkKöşkü:
                case Sayfa.MuseumName.KlasikOtmobilMüzesi:
                case Sayfa.MuseumName.DenizMüzesi:
                    this.Price = 10;
                    break;

                case Sayfa.MuseumName.PittiPalace:
                case Sayfa.MuseumName.StädelMuseum:
                case Sayfa.MuseumName.BodeMuseum:
                case Sayfa.MuseumName.AlteNationalGalerie:
                case Sayfa.MuseumName.CumhuriyetMüzesi:
                case Sayfa.MuseumName.EtnografyaMuzesiAnkara:
                case Sayfa.MuseumName.KurtuluşSavaşıMüzesi:
                case Sayfa.MuseumName.OyuncakMüzesi:
                case Sayfa.MuseumName.YerebatanSarnıcı:
                    this.Price = 15;
                    break;

                case Sayfa.MuseumName.Uffizi:
                case Sayfa.MuseumName.BergamaMuseum:
                    this.Price = 20;
                    break;

                case Sayfa.MuseumName.MuseoDeLaPlata:
                case Sayfa.MuseumName.AnadoluMedeniyetleriMüzesi:
                case Sayfa.MuseumName.Sandland:
                case Sayfa.MuseumName.AntalyaMuzesi:
                case Sayfa.MuseumName.TrabzonSporMüzesi:
                    this.Price = 45;
                    break;

                case Sayfa.MuseumName.MuseoNacionaldeArteDecorativo:
                case Sayfa.MuseumName.GöremeAçıkHavaMüzesi:
                case Sayfa.MuseumName.SümelaManastırı:
                case Sayfa.MuseumName.İstanbulArkeolojiMüzesi:
                case Sayfa.MuseumName.KaymaklıYeraltıŞehri:
                    this.Price = 50;
                    break;

                case Sayfa.MuseumName.OscarshallPalace:
                case Sayfa.MuseumName.AmaliaLacrozdeFortabatArtCollection:
                case Sayfa.MuseumName.BenitoQuinquelaMartínMuseum:
                case Sayfa.MuseumName.TopkapıSarayı:
                    this.Price = 100;
                    break;

                case Sayfa.MuseumName.NobelPeaceCenter:
                case Sayfa.MuseumName.TheFramMuseum:
                    this.Price = 120;
                    break;

                case Sayfa.MuseumName.KistefosMuseum:
                case Sayfa.MuseumName.TheNorwegianMuseumofCulturalHistory:
                case Sayfa.MuseumName.NorwegianMaritimeMuseum:
                    this.Price = 150;
                    break;
                case Sayfa.MuseumName.XulSolarMuseum:
                    this.Price = 200;
                    break;

                case Sayfa.MuseumName.TokyoNationalMuseum:
                    this.Price = 1000;
                    break;

                case Sayfa.MuseumName.TeamLabPlanets:
                    this.Price = 3200;
                    break;

                case Sayfa.MuseumName.MihoMuseum:
                case Sayfa.MuseumName.OharaMuseumofArt:
                    this.Price = 1300;
                    break;

                case Sayfa.MuseumName.TokyoNationalMuseumHeiseikan:
                    this.Price = 2300;
                    break;

                case Sayfa.MuseumName.PolaMuseumofArt:
                    this.Price = 1800;
                    break;
                default:
                    break;
            }
        }


        public void Send(string muze, int fiyat, int kisi)
        {
            this.MuseumName = muze;
            this.Price = fiyat;
            this.Person = kisi;
        }


        public override int Calculation()
        {
            Total = Price * Person;
            return Total;
        }

        public int[] fyt = new int[17] { 0, 5, 7, 10, 15, 20, 45, 50, 100, 120, 150, 200, 1000, 1300, 1800, 2300, 3200 };
    }
}
