using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Sayfa
{

    public enum HotelName
    {
        LavantaOtel,
        RoyalInciAirportHotel,
        BeyazKöşkOtel,
        TempoOtel,
        DivanIstanbulOtel,
        DoubletreeByHiltonIstanbulOtel,
        SwissotelTheBosphorus,
        PeraPalaceHotel,

        ArsenOtel,
        UzungölHolidayOtel,
        GrandVavesOtel,
        AseliaHotel,
        ZitasOtelZiganaYaylaTatilKöyü,
        ParkDedemanOtel,
        RadissonBluHotel,
        RoyalComfortHotel,

        NissLaraHotel,
        SherwoodPrizeHotel,
        AkraVHotel,
        TheCornerParkHotel,
        MeldaPalaceHotel,
        RixosDowntownAntalya,
        LimakLaraDeluxeHotel,
        TheMarmaraAntalya,

        HotelİçKale,
        TheGreenParkOtel,
        BestWesternHotel,
        AtaköşkHotel,
        WarwickOtel,
        AnkaraHiltonOtel,
        CPAnkaraHotel,
        NewParkHotel,

        GöremeRevaHotel,
        HasCaveKonakÜrgüp,
        ElifStoneHouse,
        SofaHotel,
        DedeliDeluxeHotel,
        TheVillageCaveHotel,
        TaşkonaklarOtel,
        DereSuites,

        TuğhanOtel,
        DaraKonağı,
        MardinOsmanlıKonağı,
        MaristanTarihiKonak,
        MaridinOtel,
        HiltonGardenInnMardin,
        RamadaPlazaByWyndhamMardin,
        MardiusTarihiKonakOtel,

        İntercityHotel,
        CentroHotelStadtGütersloh,
        LeonardoHotelHannover,
        MaritimHotelUlm,
        HotelLoccumerHof,
        HiltonDresden,
        ExcelsiorHotel,
        SteigenbergerHotel,

        HotelViennaOstenda,
        CorteSanMattia,
        HotelFonteBoiola,
        UnahotelsCusaniMilano,
        HotelNewJolie,
        SheratonMilanMalpensoAirportHotel,
        OtelLeAliDelFrassino,
        HotelGrandViscontiPalace,

        WyndhamNordeltaTigre,
        CHMaderoUrbanoSuites,
        HotelNHBarilocheEdelweiss,
        HotelHowardJohnsonTrenqueLauquen,
        AlgodanMansionHotel,
        HotelAlvearPalace,
        SheratonMarDelPlataHotel,
        HotelDelCasco,

        RighaNakanoshimaInnOsakaHotel,
        NestHotelKumamoto,
        ArkHotelOsakaShinsaibashi,
        UnizoOsakaUmedaHotel,
        ViaInnAsakusaHotel,
        GrandouceHanazonocho,
        ApaVillaHotelYodoyabashi,
        MystaysShinOsakaHotel,

        MarkenGuesthouseHotel,
        KjobmandsgaardenHotel,
        StavangerLilleHotel,
        BergoHotel,
        GeiloVandrerhjem,
        AmiHotel,
        ComfortHotelRunway,
        NordicChoiceHotel,
    }


    public class HotelCity : BaseClass
    {
        public String City = BaseClass.Name;
        public String Daily;
        public String Internet;
        public String IndoorPool;
        public String Pool;
        public String AirConditioning;
        public String Reception;
        public String Breakfast;
        public String CarPark;
        public String Car;
        public String Case;
        public String Food;
        public String Sport;
        public String Hotel;


        public int DailyPrice;
        public int PersonTotal;
        public int PriceH;
        public int Time;
        public int Number;
        public void HotelName(HotelName name)
        {


            switch (name)
            {
                case Sayfa.HotelName.LavantaOtel:
                case Sayfa.HotelName.RoyalInciAirportHotel:
                case Sayfa.HotelName.ArsenOtel:
                case Sayfa.HotelName.UzungölHolidayOtel:
                case Sayfa.HotelName.NissLaraHotel:
                case Sayfa.HotelName.SherwoodPrizeHotel:
                case Sayfa.HotelName.HotelİçKale:
                case Sayfa.HotelName.TheGreenParkOtel:
                case Sayfa.HotelName.GöremeRevaHotel:
                case Sayfa.HotelName.HasCaveKonakÜrgüp:
                case Sayfa.HotelName.TuğhanOtel:
                case Sayfa.HotelName.DaraKonağı:
                case Sayfa.HotelName.İntercityHotel:
                case Sayfa.HotelName.CentroHotelStadtGütersloh:
                case Sayfa.HotelName.HotelViennaOstenda:
                case Sayfa.HotelName.CorteSanMattia:
                case Sayfa.HotelName.WyndhamNordeltaTigre:
                case Sayfa.HotelName.CHMaderoUrbanoSuites:
                case Sayfa.HotelName.MarkenGuesthouseHotel:
                case Sayfa.HotelName.KjobmandsgaardenHotel:
                    this.Price = 50;
                    break;

                case Sayfa.HotelName.BeyazKöşkOtel:
                case Sayfa.HotelName.TempoOtel:
                case Sayfa.HotelName.DivanIstanbulOtel:
                case Sayfa.HotelName.GrandVavesOtel:
                case Sayfa.HotelName.AseliaHotel:
                case Sayfa.HotelName.ZitasOtelZiganaYaylaTatilKöyü:
                case Sayfa.HotelName.AkraVHotel:
                case Sayfa.HotelName.TheCornerParkHotel:
                case Sayfa.HotelName.MeldaPalaceHotel:
                case Sayfa.HotelName.BestWesternHotel:
                case Sayfa.HotelName.AtaköşkHotel:
                case Sayfa.HotelName.WarwickOtel:
                case Sayfa.HotelName.ElifStoneHouse:
                case Sayfa.HotelName.SofaHotel:
                case Sayfa.HotelName.DedeliDeluxeHotel:
                case Sayfa.HotelName.MardinOsmanlıKonağı:
                case Sayfa.HotelName.MaristanTarihiKonak:
                case Sayfa.HotelName.MaridinOtel:
                case Sayfa.HotelName.LeonardoHotelHannover:
                case Sayfa.HotelName.MaritimHotelUlm:
                case Sayfa.HotelName.HotelLoccumerHof:
                case Sayfa.HotelName.HotelFonteBoiola:
                case Sayfa.HotelName.UnahotelsCusaniMilano:
                case Sayfa.HotelName.HotelNewJolie:
                case Sayfa.HotelName.HotelNHBarilocheEdelweiss:
                case Sayfa.HotelName.HotelHowardJohnsonTrenqueLauquen:
                case Sayfa.HotelName.AlgodanMansionHotel:
                case Sayfa.HotelName.StavangerLilleHotel:
                case Sayfa.HotelName.BergoHotel:
                case Sayfa.HotelName.GeiloVandrerhjem:
                    this.Price = 100;
                    break;

                case Sayfa.HotelName.DoubletreeByHiltonIstanbulOtel:
                case Sayfa.HotelName.SwissotelTheBosphorus:
                case Sayfa.HotelName.PeraPalaceHotel:
                case Sayfa.HotelName.ParkDedemanOtel:
                case Sayfa.HotelName.RadissonBluHotel:
                case Sayfa.HotelName.RoyalComfortHotel:
                case Sayfa.HotelName.RixosDowntownAntalya:
                case Sayfa.HotelName.LimakLaraDeluxeHotel:
                case Sayfa.HotelName.TheMarmaraAntalya:
                case Sayfa.HotelName.AnkaraHiltonOtel:
                case Sayfa.HotelName.CPAnkaraHotel:
                case Sayfa.HotelName.NewParkHotel:
                case Sayfa.HotelName.TheVillageCaveHotel:
                case Sayfa.HotelName.TaşkonaklarOtel:
                case Sayfa.HotelName.DereSuites:
                case Sayfa.HotelName.HiltonGardenInnMardin:
                case Sayfa.HotelName.RamadaPlazaByWyndhamMardin:
                case Sayfa.HotelName.MardiusTarihiKonakOtel:
                case Sayfa.HotelName.HiltonDresden:
                case Sayfa.HotelName.ExcelsiorHotel:
                case Sayfa.HotelName.SteigenbergerHotel:
                case Sayfa.HotelName.SheratonMilanMalpensoAirportHotel:
                case Sayfa.HotelName.OtelLeAliDelFrassino:
                case Sayfa.HotelName.HotelGrandViscontiPalace:
                case Sayfa.HotelName.HotelAlvearPalace:
                case Sayfa.HotelName.SheratonMarDelPlataHotel:
                case Sayfa.HotelName.HotelDelCasco:
                case Sayfa.HotelName.AmiHotel:
                case Sayfa.HotelName.ComfortHotelRunway:
                case Sayfa.HotelName.NordicChoiceHotel:
                    this.Price = 200;
                    break;

                case Sayfa.HotelName.RighaNakanoshimaInnOsakaHotel:
                case Sayfa.HotelName.NestHotelKumamoto:
                    this.Price = 50000;
                    break;
                case Sayfa.HotelName.ArkHotelOsakaShinsaibashi:
                case Sayfa.HotelName.UnizoOsakaUmedaHotel:
                case Sayfa.HotelName.ViaInnAsakusaHotel:
                    this.Price = 100000;
                    break;
                case Sayfa.HotelName.GrandouceHanazonocho:
                case Sayfa.HotelName.ApaVillaHotelYodoyabashi:
                case Sayfa.HotelName.MystaysShinOsakaHotel:
                    this.Price = 200000;
                    break;


            }

        }


        public HotelCity()
        {

            Daily = "Günlük:";
            Internet = "Ücretsiz Wifi";
            IndoorPool = "Kapalı yüzme havuzu";
            Pool = "Havuz";
            AirConditioning = "Klima";
            Reception = "24 saat açık resepsiyon";
            Breakfast = "Ücretsiz kahvaltı";
            CarPark = "Ücretli otopark";
            Car = "Ücretsiz otopark";
            Case = "Valiz dolabı";
            Food = "Ücretsiz akşam yemeği";
            Sport = "Spor salonu";
        }


        public void Send(string a)
        {
            this.Hotel = a;
        }

        public void Assignment(int b, int c, int d)
        {
            this.DailyPrice = b;
            this.PersonTotal = c;
            this.Time = d;
        }


        public int total = 0;

        public override int Calculation()
        {
            if (Time == 0)
            {
                total = DailyPrice * PersonTotal;
            }
            else
            {
                total = DailyPrice * PersonTotal * Time;
            }
            return total;

        }
    }
}
