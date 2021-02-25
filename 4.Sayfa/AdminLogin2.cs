using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 
using System.Text; 

namespace _4.Sayfa
{
    public partial class AdminLogin2 : Form
    {
        public AdminLogin2()
        {
            InitializeComponent();
        }

        public static string HotelTotal;
        public static string HotelPerson;
        public static string MuseumTotal;
        public static string MuseumPerson;
        public static string RestaurantTotal;
        public static string RestaurantPerson;
        public static string TourTotal;
        public static string TourPerson;
        public static string TransportationTotal;
        public static string TransportationPerson;
        AdminCity adminCity = new AdminCity();



        private void admingiris2_Load(object sender, EventArgs e)
        {

            this.AutoScroll = true;
            this.MaximizeBox = false;
            BackColor = Color.Silver;
            menuStrip1.BackColor = Color.Silver;


            pictureBox1.ImageLocation = "logo1.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;



            label1.Text = adminCity.lx1;
            label2.Text = adminCity.lx2;


            File.AppendAllText("admin.txt", AdminCity.person + ": " + Environment.NewLine);
            File.AppendAllText("admin.txt", "Restoran: " + Basket.RestaurantName + " restoranı " + RestaurantPerson + " kişi için " + RestaurantTotal + " ücret ödedi." + Environment.NewLine);
            File.AppendAllText("admin.txt", "Müze: " + ", " + Basket.MuseumName + " müzesi " + MuseumPerson + " kişi için " + MuseumTotal + " ücret ödedi." + Environment.NewLine);
            File.AppendAllText("admin.txt", "Otel: " + Basket.HotelName + " oteli " + HotelPerson + " kişi için " + HotelTotal + " ödedi." + Environment.NewLine);
            File.AppendAllText("admin.txt", "Tur: " + Basket.TourName + " turu " + TourPerson + " kişi için " + TourTotal + " ödedi." + Environment.NewLine);
            File.AppendAllText("admin.txt", "Ulasım:" + Basket.TransportationName + " turizm " + TransportationPerson + " kişi için " + TransportationTotal + " ödedi." + Environment.NewLine);
            File.AppendAllText("admin.txt", "-----------------------" + Environment.NewLine);


            string oku = File.ReadAllText("admin.txt");

            richTextBox1.Text = oku;

        }

        private void AnasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AdminCity.person = "0";
            HomePage ana = new HomePage();
            ana.Show();
            this.Hide();
            AdminLogin2.HotelTotal = "0";
            AdminLogin2.HotelPerson = "0";
            AdminLogin2.RestaurantPerson = "0";
            AdminLogin2.RestaurantTotal = "0";
            AdminLogin2.MuseumTotal = "0";
            AdminLogin2.MuseumPerson = "0";
            AdminLogin2.TourTotal = "0";
            AdminLogin2.TourPerson = "0";
            AdminLogin2.TransportationPerson = "0";
            AdminLogin2.TransportationTotal = "0";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
