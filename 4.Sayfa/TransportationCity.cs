using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sayfa
{
    public enum Ulasim_Yolu
    {
        Uçak, Otobus
    }

    public enum Flight
    {
        İstanbul_Antalya, Nevşehir_İstanbul, Ankara_İstanbul, Bursa_İtalya, İstanbul_İtalya, Ankara_Almanya, İstanbul_Japonya, İstanbul_Norveç, İstanbul_Arjantin, Ankara_Arjantin

    }
    public enum Bus
    {
        Adana_Nevşehir, Trabzon_Mardin, Antalya_Ankara, İstanbul_Ankara, Ankara_Mardin, Ankara_Nevşehir, İstanbul_Nevşehir, İstanbul_Trabzon, Ankara_İstanbul
    }
    class TransportationCity : BaseClass
    {

        public string ulasim_yolu;
        public string sefer;
        public int kisi;

        private int fiyat;
        private int toplam;


        public override int Calculation()
        {
            if (ulasim_yolu == Ulasim_Yolu.Uçak.ToString())
            {
                fiyat = 250;
                toplam = kisi * fiyat;
            }
            else
            {
                fiyat = 50;
                toplam = kisi * fiyat;
            }
            return toplam;
        }


    }
}
