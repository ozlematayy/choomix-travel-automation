using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sayfa
{

    public enum TourName
    {
        AKTUR,
        ULUTUR,
        ÖZTUR,
        CANTUR,

        BIGTOUR,
        TRIOTOUR,
        REDTOUR,
        ASIATOUR,

        ASIANTOUR,
        IKURATOUR,
        ARIGATOUR,
        AWARETOUR,

    }
    public class TourCity : BaseClass
    {


        public String m1 = "TUR TERCİHLERİ";
        public String m3 = "Bütçeye Göre Sırala";
        public String m4 = "Kişi Sayısı";
        public String m5 = "Tura Katılım Tarihi";
        public String m6 = "Başlangıç:";
        public String m7 = "Bitiş:";


        public String b1 = "Uygula";
        public String b2 = "Seçimi Temizle";
        public String b3 = "Ödeme";


        public String o1 = "Her Şey Dahil";
        public String o2 = "Rehber";
        public String o3 = "Gidiş Dönüş";


        public TourCity()
        {

        }

        public String a = BaseClass.Name;

        public String Tour;
        public int TourPrice;
        public int TourPerson;
        public int turgun;

        public int toplamt;
        public void gonder(string isimtur, int fiyattur, int kisitur, int timetur)
        {
            this.Tour = isimtur;
            this.TourPrice = fiyattur;
            this.TourPerson = kisitur;
            this.turgun = timetur;
        }


        public void Fiyatlandırma(TourName isim)
        {

            switch (isim)
            {

                case TourName.AKTUR:
                case TourName.BIGTOUR:
                    this.Price = 600;
                    break;

                case TourName.ULUTUR:
                case TourName.TRIOTOUR:
                    this.Price = 1200;
                    break;

                case TourName.ÖZTUR:
                case TourName.REDTOUR:
                    this.Price = 2000;
                    break;

                case TourName.CANTUR:
                case TourName.ASIATOUR:
                    this.Price = 2800;
                    break;

                case TourName.ASIANTOUR:
                    this.Price = 600000;
                    break;

                case TourName.IKURATOUR:
                    this.Price = 1200000;
                    break;

                case TourName.ARIGATOUR:

                    this.Price = 200000;
                    break;

                case TourName.AWARETOUR:
                    this.Price = 2800000;
                    break;

            }
        }


        public override int Calculation()
        {
            toplamt = TourPrice * TourPerson * turgun;
            return toplamt;
        }

    }
}