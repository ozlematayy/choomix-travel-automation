using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Sayfa
{
    public class Basket
    {

        private List<BaseClass> yeni = new List<BaseClass>();


        public void Add(BaseClass calc)
        {
            if (calc != null)
            {
                yeni.Add(calc);
            }
        }


        public List<BaseClass> GetAtama()
        {
            return yeni;
        }

        public Basket()
        {

        }


        public static String HotelName, MuseumName, TourName, RestaurantName, TransportationName;
        public String Result, click1, click2, click3, click4, click5;

        public static String HotelPersonTotal = "0";
        public static String MuseumPersonTotal = "0";
        public static String TourPersonTotal = "0";
        public static String RestaurantPersonTotal = "0";
        public static String TransportationPersonTotal = "0";


        public static String MuseumDailyPrice = "0";
        public static String TourDailyPrice = "0";
        public static String RestaurantDailyPrice = "0";
        public static String HotelDailyPrice = "0";
        public static String TransportationDailyPrice = "0";


        public static String MuseumTotal = "0";
        public static String TourTotal = "0";
        public static String RestaurantTotal = "0";
        public static String HotelTotal = "0";
        public static String TransportationTotal = "0";


        public static int HotelDay = 0;
        public static int TourDay = 0;
        public String Currency;
        public static double total;



        public static double totalPrice = 0;

        public double TotalPrice()
        {

            foreach (var toplam in yeni)
            {
                totalPrice += toplam.Price;
            }
            return totalPrice;
        }

    }
}

