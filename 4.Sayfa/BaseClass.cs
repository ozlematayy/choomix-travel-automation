using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sayfa
{
    public abstract class BaseClass
    {


        public int Price;
        public String x;
        public String y;
        public String z;
        public String t;
        public String k;

        public static string Category;
        public static string Name;

        public BaseClass()
        {

            x = "TL";
            y = "Euro";
            z = "Ars";
            t = "Kron";
            k = "Yen";

        }


        public abstract int Calculation();




    }

}
