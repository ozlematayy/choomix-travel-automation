using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Sayfa
{
    public class LoginAssign
    {
        public static string User;
        public static string MailAddress;
        public static string PhoneNumber;


        public LoginAssign(string k, string l, string m)
        {
            User = k;
            MailAddress = l;
            PhoneNumber = m;
        }

    }
}
