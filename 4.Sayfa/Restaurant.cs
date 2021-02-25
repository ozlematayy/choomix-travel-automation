using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Sayfa
{
    public partial class Restaurant : Form
    {   
        public int a;
        public int b;
        public int c;
        public int d;
        public int f;
        public int g;
        
        public int x;
        public int s;
        public int h;
        public int m;
        public int k;
        public int l;
       

        public Restaurant()
        {
            InitializeComponent();
        }

        BaseClass restaurant = new RestaurantCity();//polimorfizm kullandık
        Basket basket = new Basket();
        Payment payment = new Payment();
        RestaurantCity restaurantCity = new RestaurantCity();
        private void restoran_Load(object sender, EventArgs e)
        {
            BaseClass.Category = "Restoran";

            this.AutoScroll = true;
            this.MaximizeBox = false;


            label82.Text = LoginAssign.User;
            if ((label82.Text != LoginAssign.User) || (LoginAssign.User == "0"))
            {
                label82.Text = "Giriş Yapınız.";
                label82.ForeColor = Color.Maroon;
            }
            else
            {
                label82.Text = "HOŞGELDİN " + LoginAssign.User;
                label82.ForeColor = Color.SeaGreen;
            }


            label53.Text = "Bütçe";
            label52.Text = "* Seçmek zorunludur.";
            label80.Text = "* Seçmek zorunludur.";
            label56.Text = "(1 Kişinin Bütçesini Giriniz)";
            label55.Text = "Kişi Sayısı";
            groupBox1.Text = "Seçim İşlemleri:";

            pictureBox7.ImageLocation = "7.jpg";
            pictureBox8.ImageLocation = "7.jpg";
            pictureBox9.ImageLocation = "7.jpg";
            pictureBox10.ImageLocation = "7.png";
            pictureBox10.ImageLocation = "7.jpg";
            pictureBox11.ImageLocation = "7.jpg";
            pictureBox12.ImageLocation = "7.jpg";
            pictureBox19.ImageLocation = "foodserving.png";

            pictureBox20.ImageLocation = "logo1.png";


            pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            label69.Text = "Toplam Tutar";
            label70.Text = "Toplam Tutar";
            label72.Text = "Toplam Tutar";
            label74.Text = "Toplam Tutar";
            label76.Text = "Toplam Tutar";
            label78.Text = "Toplam Tutar";

            panel7.Visible = true;

            RestaurantCity restoran = new RestaurantCity();

            label24.Text = BaseClass.Name;

            if (BaseClass.Name == "Antalya")
            {
                basket.Currency = restaurant.x;
                label83.Text = restaurantCity.x;
                label84.Text = restaurantCity.x;
                label85.Text = restaurantCity.x;
                label86.Text = restaurantCity.x;
                label87.Text = restaurantCity.x;
                label88.Text = restaurantCity.x;
                label89.Visible = false; label92.Visible = false;
                label90.Visible = false; label93.Visible = false;
                label91.Visible = false; label94.Visible = false;


                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "arma.jfif";
                pictureBox2.ImageLocation = "asmani.jfif";
                pictureBox3.ImageLocation = "sera.jfif";
                pictureBox4.ImageLocation = "7.jfif";
                pictureBox5.ImageLocation = "kutulara.jfif";
                pictureBox6.ImageLocation = "supla.jpg";


                restoran.Yad = radioButton1.Text;
                radioButton1.Text = "Arma Restaurant";
                restoran.Yögley = label4.Text;
                label4.Text = "100";
                restoran.Yaksmy = label6.Text;
                label6.Text = "200";


                label1.Visible = false; label2.Visible = false; label9.Visible = false; label10.Visible = false;
                label8.Visible = false; label7.Visible = false;
                a = Convert.ToInt32(label4.Text) + Convert.ToInt32(label6.Text);
                label68.Text = a.ToString();


                restoran.Yad = radioButton2.Text;
                radioButton2.Text = "Asmani Fine Dining ";
                restoran.Yögley = label17.Text;
                label17.Text = "90";
                restoran.Yaksmy = label15.Text;
                label15.Text = "150";
                b = Convert.ToInt32(label17.Text) + Convert.ToInt32(label15.Text);
                label71.Text = b.ToString();

                label12.Visible = false; label11.Visible = false; label13.Visible = false; label14.Visible = false;
                label1.Visible = false; label2.Visible = false; label9.Visible = false; label20.Visible = false;
                label19.Visible = false;


                restoran.Yad = radioButton3.Text;
                radioButton3.Text = "Seraser Fine Dining";

                restoran.Yögley = label28.Text;
                label28.Text = "30";
                restoran.Yaksmy = label26.Text;
                label26.Text = "45";
                restoran.Ytatlı = label23.Text;
                label23.Text = "20";
                label44.Visible = false; label22.Visible = false; label30.Visible = false;
                label31.Visible = false; label21.Visible = false;
                c = Convert.ToInt32(label28.Text) + Convert.ToInt32(label26.Text) + Convert.ToInt32(label23.Text);
                label73.Text = c.ToString();


                restoran.Yad = radioButton4.Text;
                radioButton4.Text = "7 Mehmet ";
                restoran.Yögley = label38.Text;
                label38.Text = "50";
                restoran.Yaksmy = label36.Text;
                label36.Text = "70";
                restoran.Ytatlı = label34.Text;
                label34.Text = "25";
                label32.Visible = false; ; label33.Visible = false; label40.Visible = false; label41.Visible = false;
                d = Convert.ToInt32(label38.Text) + Convert.ToInt32(label36.Text) + Convert.ToInt32(label34.Text);
                label75.Text = d.ToString();

                restoran.Yad = radioButton5.Text;
                radioButton5.Text = "Kutu Lara Lounge ";
                restoran.Ykhv = label54.Text;
                label54.Text = "30";
                restoran.Yögley = label48.Text;
                label48.Text = "30";
                restoran.Yaksmy = label46.Text;
                label46.Text = "50";
                label31.Visible = false; label30.Visible = false;
                label1.Visible = false; label22.Visible = false; label44.Visible = false; label45.Visible = false; label43.Visible = false; label42.Visible = false;
                f = Convert.ToInt32(label54.Text) + Convert.ToInt32(label48.Text) + Convert.ToInt32(label46.Text);
                label77.Text = f.ToString();

                restoran.Yad = radioButton6.Text;
                radioButton6.Text = "Antalya Supla";
                restoran.Ykhv = label66.Text;
                label66.Text = "30";
                restoran.Yögley = label64.Text;
                label64.Text = "25";

                label59.Visible = false; label58.Visible = false; label62.Visible = false; label61.Visible = false;
                label60.Visible = false; label61.Visible = false; label63.Visible = false;
                g = Convert.ToInt32(label66.Text) + Convert.ToInt32(label64.Text);
                label79.Text = g.ToString();
            }

            else if (BaseClass.Name == "Ankara")
            {
                basket.Currency = restaurant.x;
                label83.Text = restaurantCity.x;
                label84.Text = restaurantCity.x;
                label85.Text = restaurantCity.x;
                label86.Text = restaurantCity.x;
                label87.Text = restaurantCity.x;
                label88.Text = restaurantCity.x;
                label89.Visible = false; label92.Visible = false;
                label90.Visible = false; label93.Visible = false;
                label91.Visible = false; label94.Visible = false;


                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "marl.jfif";
                pictureBox2.ImageLocation = "ea.jfif";
                pictureBox3.ImageLocation = "dow.jfif";
                pictureBox4.ImageLocation = "otkafe.jfif";
                pictureBox5.ImageLocation = "aspava.jfif";
                pictureBox6.ImageLocation = "butikek.jfif";


                restoran.Yad = radioButton1.Text;
                radioButton1.Text = "Marlinda";
                restoran.Yögley = label4.Text;
                label4.Text = "60";
                restoran.Yaksmy = label6.Text;
                label6.Text = "70";
                restoran.Ytatlı = label8.Text;
                label8.Text = "30";
                label1.Visible = false; label2.Visible = false; label9.Visible = false; label10.Visible = false;
                a = Convert.ToInt32(label8.Text) + Convert.ToInt32(label4.Text) + Convert.ToInt32(label6.Text);
                label68.Text = a.ToString();

                restoran.Yad = radioButton2.Text;
                radioButton2.Text = "Emirgan Sütiş ";
                restoran.Ykhv = label19.Text;
                label19.Text = "50";
                restoran.Yögley = label17.Text;
                label17.Text = "20";
                restoran.Yaksmy = label6.Text;
                label15.Text = "50";
                label12.Visible = false; label13.Visible = false; label14.Visible = false; label11.Visible = false;
                label9.Visible = false; label10.Visible = false;
                b = Convert.ToInt32(label17.Text) + Convert.ToInt32(label15.Text) + Convert.ToInt32(label19.Text);
                label71.Text = b.ToString();

                restoran.Yad = radioButton3.Text;
                radioButton3.Text = "Downtown Food Club ";
                restoran.Ykhv = label30.Text;
                label30.Text = "30";
                restoran.Yögley = label28.Text;
                label28.Text = "35";
                restoran.Yaksmy = label26.Text;
                label26.Text = "40";
                label44.Visible = false; label43.Visible = false;
                label45.Visible = false; label42.Visible = false; label21.Visible = false;
                c = Convert.ToInt32(label28.Text) + Convert.ToInt32(label26.Text) + Convert.ToInt32(label30.Text);
                label73.Text = c.ToString();



                restoran.Yad = radioButton4.Text;
                radioButton4.Text = "Ot Kafe ";
                restoran.Ykhv = label40.Text;
                label40.Text = "30";
                restoran.Yögley = label38.Text;
                label38.Text = "40";
                restoran.Yaksmy = label36.Text;
                label36.Text = "30";
                label35.Visible = false; label32.Visible = false; label34.Visible = false; label33.Visible = false;
                d = Convert.ToInt32(label38.Text) + Convert.ToInt32(label36.Text) + Convert.ToInt32(label40.Text);
                label75.Text = d.ToString();

                restoran.Yad = radioButton5.Text;
                radioButton5.Text = "Aspava ";
                restoran.Yögley = label48.Text;
                label48.Text = "40";
                restoran.Yaksmy = label46.Text;
                label46.Text = "55";

                label25.Visible = false; label23.Visible = false; label57.Visible = false; label54.Visible = false;
                label22.Visible = false; label9.Visible = false; label10.Visible = false;
                f = Convert.ToInt32(label48.Text) + Convert.ToInt32(label46.Text);
                label77.Text = f.ToString();


                restoran.Yad = radioButton6.Text;
                radioButton6.Text = "Butikek ";
                restoran.Ykhv = label66.Text;
                label66.Text = "25";
                restoran.Yögley = label64.Text;
                label64.Text = "25";
                restoran.Yaksmy = label62.Text;
                label62.Text = "40";
                label59.Visible = false; label58.Visible = false;
                label60.Visible = false; label61.Visible = false;
                g = Convert.ToInt32(label66.Text) + Convert.ToInt32(label64.Text) + Convert.ToInt32(label62.Text);
                label79.Text = g.ToString();


            }



            else if (BaseClass.Name == "İstanbul")
            {

                basket.Currency = restaurant.x;
                label83.Text = restaurantCity.x;
                label84.Text = restaurantCity.x;
                label85.Text = restaurantCity.x;
                label86.Text = restaurantCity.x;
                label87.Text = restaurantCity.x;
                label88.Text = restaurantCity.x;
                label89.Visible = false; label92.Visible = false;
                label90.Visible = false; label93.Visible = false;
                label91.Visible = false; label94.Visible = false;

                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "kızkulesi.jfif";
                pictureBox2.ImageLocation = "ajian.jfif";
                pictureBox3.ImageLocation = "emirgan.jpg";
                pictureBox4.ImageLocation = "galatakulesi.jfif";
                pictureBox5.ImageLocation = "bigchefs.jpg";
                pictureBox6.ImageLocation = "stkule.jfif";


                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


                restoran.Yad = radioButton1.Text;
                radioButton1.Text = "Kız Kulesi Restoran";
                restoran.Ykhv = label2.Text;
                label2.Text = "100";
                restoran.Yögley = label4.Text;
                label4.Text = "60";
                restoran.Yaksmy = label6.Text;
                label6.Text = "100";
                label9.Visible = false; label10.Visible = false;
                label7.Visible = false; label1.Visible = true; label2.Visible = true;
                a = Convert.ToInt32(label2.Text) + Convert.ToInt32(label4.Text) + Convert.ToInt32(label6.Text);
                label68.Text = a.ToString();

                restoran.Yad = radioButton2.Text;
                radioButton2.Text = " A'jia Restaurant";
                restoran.Ykhv = label19.Text;
                label19.Text = "80";
                restoran.Yögley = label17.Text;
                label17.Text = "70";
                restoran.Yaksmy = label6.Text;
                label15.Text = "100";
                label12.Visible = false; label13.Visible = false; label14.Visible = false; label11.Visible = false; label8.Visible = false;
                label9.Visible = false; label10.Visible = false; label20.Visible = true;
                b = Convert.ToInt32(label17.Text) + Convert.ToInt32(label15.Text) + Convert.ToInt32(label19.Text);
                label71.Text = b.ToString();

                restoran.Yad = radioButton3.Text;
                radioButton3.Text = "Emirgan Sütiş ";
                restoran.Ykhv = label30.Text;
                label30.Text = "65";
                restoran.Yögley = label28.Text;
                label28.Text = "50";
                restoran.Yaksmy = label26.Text;
                label26.Text = "60";
                label44.Visible = false; label43.Visible = false;
                label45.Visible = false; label42.Visible = false; label22.Visible = false;
                c = Convert.ToInt32(label28.Text) + Convert.ToInt32(label26.Text) + Convert.ToInt32(label30.Text);
                label73.Text = c.ToString();


                restoran.Yad = radioButton4.Text;
                radioButton4.Text = "Galata Kulesi Restaurant";
                restoran.Ykhv = label40.Text;
                label40.Text = "35";
                restoran.Yögley = label38.Text;
                label38.Text = "30";
                restoran.Yaksmy = label36.Text;
                label36.Text = "45";
                label35.Visible = false; label32.Visible = false; label34.Visible = false; label33.Visible = false;
                d = Convert.ToInt32(label38.Text) + Convert.ToInt32(label36.Text) + Convert.ToInt32(label40.Text);
                label75.Text = d.ToString();

                restoran.Yad = radioButton5.Text;
                radioButton5.Text = "Big Chefs";

                restoran.Ykhv = label54.Text;
                label54.Text = "25";
                restoran.Yögley = label48.Text;
                label48.Text = "35";
                restoran.Yaksmy = label46.Text;
                label46.Text = "50";

                label25.Visible = false; label23.Visible = false;
                label22.Visible = false; label10.Visible = false;
                f = Convert.ToInt32(label54.Text) + Convert.ToInt32(label48.Text) + Convert.ToInt32(label46.Text);
                label77.Text = f.ToString();


                restoran.Yad = radioButton6.Text;
                radioButton6.Text = "Saat Kule Kafeterya";
                restoran.Ykhv = label66.Text;
                label66.Text = "30";
                restoran.Yögley = label64.Text;
                label64.Text = "25";
                restoran.Yaksmy = label62.Text;
                label62.Text = "40";
                label59.Visible = false; label58.Visible = false;
                label60.Visible = false; label61.Visible = false;
                g = Convert.ToInt32(label66.Text) + Convert.ToInt32(label64.Text) + Convert.ToInt32(label62.Text);
                label79.Text = g.ToString();
            }





            else if (BaseClass.Name == "Nevşehir")
            {
                basket.Currency = restaurant.x;
                label83.Text = restaurantCity.x;
                label84.Text = restaurantCity.x;
                label85.Text = restaurantCity.x;
                label86.Text = restaurantCity.x;
                label87.Text = restaurantCity.x;
                label88.Text = restaurantCity.x;
                label89.Visible = false; label92.Visible = false;
                label90.Visible = false; label93.Visible = false;
                label91.Visible = false; label94.Visible = false;

                pictureBox1.ImageLocation = "lila.jfif";
                pictureBox2.ImageLocation = "seki.jfif";
                pictureBox3.ImageLocation = "saklıkonak.jfif";
                pictureBox4.ImageLocation = "montecappa.jfif";
                pictureBox5.ImageLocation = "şıra.jfif";
                pictureBox6.ImageLocation = "vaadi.jfif";

                restoran.Yad = radioButton1.Text;
                radioButton1.Text = "Lil'a Restaurant";
                restoran.Yögley = label4.Text;
                label4.Text = "100";
                restoran.Yaksmy = label6.Text;
                label6.Text = "200";
                a = Convert.ToInt32(label4.Text) + Convert.ToInt32(label6.Text);
                label68.Text = a.ToString();

                label1.Visible = false; label2.Visible = false; label9.Visible = false; label10.Visible = false;
                label8.Visible = false; label7.Visible = false; label8.Visible = false; label7.Visible = false;


                restoran.Yad = radioButton2.Text;
                radioButton2.Text = "Seki Restaurant ";
                restoran.Yögley = label17.Text;
                label17.Text = "70";
                restoran.Yaksmy = label15.Text;
                label15.Text = "150";
                b = Convert.ToInt32(label17.Text) + Convert.ToInt32(label15.Text);
                label71.Text = b.ToString();

                label12.Visible = false; label11.Visible = false; label13.Visible = false; label14.Visible = false;
                label1.Visible = false; label2.Visible = false; label9.Visible = false; label20.Visible = false;
                label19.Visible = false;

                restoran.Yad = radioButton3.Text;
                radioButton3.Text = "Saklı Konak";

                restoran.Yögley = label28.Text;
                label28.Text = "50";
                restoran.Yaksmy = label26.Text;
                label26.Text = "80";
                restoran.Ytatlı = label23.Text;
                label23.Text = "25";
                label44.Visible = false; label22.Visible = false; label30.Visible = false;
                label31.Visible = false; label21.Visible = false;
                c = Convert.ToInt32(label28.Text) + Convert.ToInt32(label26.Text) + Convert.ToInt32(label23.Text);
                label73.Text = c.ToString();


                restoran.Yad = radioButton4.Text;
                radioButton4.Text = "Monte Cappa Restaurant ";
                restoran.Ykhv = label40.Text;
                label40.Text = "35";
                restoran.Yögley = label38.Text;
                label38.Text = "45";
                restoran.Yaksmy = label36.Text;
                label36.Text = "70";
                restoran.Ytatlı = label34.Text;
                label34.Text = "25";
                label35.Visible = false; label32.Visible = false; ; label33.Visible = false;
                label34.Visible = false;
                d = Convert.ToInt32(label38.Text) + Convert.ToInt32(label36.Text) + Convert.ToInt32(label34.Text);
                label75.Text = d.ToString();

                restoran.Yad = radioButton5.Text;
                radioButton5.Text = "Şıra Restaurant";

                restoran.Yögley = label48.Text;
                label48.Text = "40";
                restoran.Yaksmy = label46.Text;
                label46.Text = "60";
                label31.Visible = false; label30.Visible = false;
                label57.Visible = false; label34.Visible = false; label57.Visible = false;
                label1.Visible = false; label22.Visible = false; label9.Visible = false; label10.Visible = false; label54.Visible = false;
                label45.Visible = false; label44.Visible = false; label43.Visible = false;
                label42.Visible = false;
                f = Convert.ToInt32(label48.Text) + Convert.ToInt32(label46.Text);
                label77.Text = f.ToString();

                restoran.Yad = radioButton6.Text;
                radioButton6.Text = "Vadi Kafe Restaurant";
                restoran.Ykhv = label66.Text;
                label66.Text = "30";
                restoran.Yögley = label64.Text;
                label64.Text = "20";
                restoran.Yaksmy = label62.Text;
                label62.Text = "50";

                label59.Visible = false; label58.Visible = false; label61.Visible = false;
                label60.Visible = false; label61.Visible = false;
                g = Convert.ToInt32(label66.Text) + Convert.ToInt32(label64.Text) + Convert.ToInt32(label62.Text);
                label79.Text = g.ToString();

            }


            else if (BaseClass.Name == "Mardin")
            {
                basket.Currency = restaurant.x;
                label83.Text = restaurantCity.x;
                label84.Text = restaurantCity.x;
                label85.Text = restaurantCity.x;
                label86.Text = restaurantCity.x;
                label87.Text = restaurantCity.x;
                label88.Text = restaurantCity.x;
                label89.Visible = false; label92.Visible = false;
                label90.Visible = false; label93.Visible = false;
                label91.Visible = false; label94.Visible = false;

                pictureBox1.ImageLocation = "leyli.jfif";
                pictureBox2.ImageLocation = "yu.jfif";
                pictureBox3.ImageLocation = "cercis.jfif";
                pictureBox4.ImageLocation = "cihan.jfif";
                pictureBox5.ImageLocation = "bağdadi.jfif";
                pictureBox6.ImageLocation = "sm.jfif";

                restoran.Yad = radioButton1.Text;
                radioButton1.Text = "Leyli Muse Mutfak G. A.";
                restoran.Yögley = label2.Text;
                label4.Text = "45";
                restoran.Yaksmy = label6.Text;
                label6.Text = "90";

                label1.Visible = false; label2.Visible = false; label9.Visible = false; label10.Visible = false;
                label8.Visible = false; label7.Visible = false; label8.Visible = false; label7.Visible = false;
                a = Convert.ToInt32(label4.Text) + Convert.ToInt32(label6.Text);
                label68.Text = a.ToString();


                restoran.Yad = radioButton2.Text;
                radioButton2.Text = "Kebapçı Yusuf Usta ";
                restoran.Yögley = label17.Text;
                label17.Text = "40";
                restoran.Yaksmy = label15.Text;
                label15.Text = "55";
                b = Convert.ToInt32(label17.Text) + Convert.ToInt32(label15.Text);
                label71.Text = b.ToString();

                label12.Visible = false; label11.Visible = false; label13.Visible = false; label14.Visible = false;
                label1.Visible = false; label2.Visible = false; label9.Visible = false; label20.Visible = false;
                label19.Visible = false;

                restoran.Yad = radioButton3.Text;
                radioButton3.Text = "Cercis Murat Konağı";

                restoran.Yögley = label28.Text;
                label28.Text = "35";
                restoran.Yaksmy = label26.Text;
                label26.Text = "50";

                label44.Visible = false; label22.Visible = false; label30.Visible = false;
                label31.Visible = false; label21.Visible = false; label25.Visible = false; label23.Visible = false;
                c = Convert.ToInt32(label28.Text) + Convert.ToInt32(label26.Text);
                label73.Text = c.ToString();

                restoran.Yad = radioButton4.Text;
                radioButton4.Text = "Cihan Et Lokantası ";
                restoran.Yögley = label38.Text;
                label38.Text = "35";
                restoran.Yaksmy = label36.Text;
                label36.Text = "50";
                label35.Visible = false; label32.Visible = false; ; label33.Visible = false; label40.Visible = false; label41.Visible = false;
                label45.Visible = false; label44.Visible = false;
                d = Convert.ToInt32(label38.Text) + Convert.ToInt32(label36.Text);
                label75.Text = d.ToString();

                restoran.Yad = radioButton5.Text;
                radioButton5.Text = "Bağdadi ";

                restoran.Yögley = label48.Text;
                label48.Text = "30";
                restoran.Yaksmy = label46.Text;
                label46.Text = "50";
                label31.Visible = false; label30.Visible = false;
                label42.Visible = false; label43.Visible = false; label57.Visible = false; label34.Visible = false;
                label54.Visible = false; label57.Visible = false; label9.Visible = false; label45.Visible = false;
                f = Convert.ToInt32(label48.Text) + Convert.ToInt32(label46.Text);
                label77.Text = f.ToString();


                restoran.Yad = radioButton6.Text;
                radioButton6.Text = "Seyr-i Mardin";

                restoran.Yögley = label64.Text;
                label64.Text = "30";
                restoran.Yaksmy = label62.Text;
                label62.Text = "50";
                label63.Visible = true; label62.Visible = true;
                label59.Visible = false; label58.Visible = false; label61.Visible = false;
                label60.Visible = false; label61.Visible = false; label67.Visible = false; label66.Visible = false;
                g = Convert.ToInt32(label64.Text) + Convert.ToInt32(label62.Text);
                label79.Text = g.ToString();



            }

            else if (BaseClass.Name == "Trabzon")
            {
                basket.Currency = restaurant.x;
                label83.Text = restaurantCity.x;
                label84.Text = restaurantCity.x;
                label85.Text = restaurantCity.x;
                label86.Text = restaurantCity.x;
                label87.Text = restaurantCity.x;
                label88.Text = restaurantCity.x;
                label89.Visible = false; label92.Visible = false;
                label90.Visible = false; label93.Visible = false;
                label91.Visible = false; label94.Visible = false;


                pictureBox1.ImageLocation = "modatepe.jfif";
                pictureBox2.ImageLocation = "bordomavi.jfif";
                pictureBox3.ImageLocation = "komaroğlu.jfif";
                pictureBox4.ImageLocation = "bozo.jfif";
                pictureBox5.ImageLocation = "akçay.jpg";
                pictureBox6.ImageLocation = "ka.jfif";

                restoran.Yad = radioButton1.Text;
                radioButton1.Text = "Trabzon Modatepe Restaurant";
                restoran.Ykhv = label2.Text;
                label2.Text = "40";
                restoran.Yögley = label4.Text;
                label4.Text = "35";
                restoran.Yaksmy = label6.Text;
                label6.Text = "60";
                label9.Visible = false; label10.Visible = false; label2.Visible = true;
                label8.Visible = false; label7.Visible = false; label8.Visible = false; label7.Visible = false;
                a = Convert.ToInt32(label2.Text) + Convert.ToInt32(label4.Text) + Convert.ToInt32(label6.Text);
                label68.Text = a.ToString();


                restoran.Yad = radioButton2.Text;
                radioButton2.Text = "Bordo Mavi Balık ";
                restoran.Yögley = label17.Text;
                label17.Text = "45";
                restoran.Yaksmy = label15.Text;
                label15.Text = "70";


                label12.Visible = false; label11.Visible = false; label13.Visible = false; label14.Visible = false;
                label9.Visible = false; label20.Visible = false;
                label19.Visible = false;
                b = Convert.ToInt32(label17.Text) + Convert.ToInt32(label15.Text);
                label71.Text = b.ToString();

                restoran.Yad = radioButton3.Text;
                radioButton3.Text = "Komoroğlu Köfe Salonu ";

                restoran.Yögley = label28.Text;
                label28.Text = "30";
                restoran.Yaksmy = label26.Text;
                label26.Text = "40";

                label44.Visible = false; label22.Visible = false; label30.Visible = false;
                label31.Visible = false; label21.Visible = false; label25.Visible = false; label23.Visible = false;
                c = Convert.ToInt32(label28.Text) + Convert.ToInt32(label26.Text);
                label73.Text = c.ToString();


                restoran.Yad = radioButton4.Text;
                radioButton4.Text = "Bozo Pide ";
                restoran.Yögley = label38.Text;
                label38.Text = "25";
                restoran.Yaksmy = label36.Text;
                label36.Text = "40";
                label35.Visible = false; label32.Visible = false; ; label33.Visible = false; label40.Visible = false; label41.Visible = false;
                label45.Visible = false; label44.Visible = false;
                d = Convert.ToInt32(label38.Text) + Convert.ToInt32(label36.Text);

                label75.Text = d.ToString();

                restoran.Yad = radioButton5.Text;
                radioButton5.Text = "Akçay Lokantası ";

                restoran.Yögley = label48.Text;
                label48.Text = "15";
                restoran.Yaksmy = label46.Text;
                label46.Text = "30";
                label31.Visible = false; label30.Visible = false;
                label42.Visible = false; label43.Visible = false; label57.Visible = false; label34.Visible = false;
                label54.Visible = false; label57.Visible = false; label9.Visible = false; label45.Visible = false;
                f = Convert.ToInt32(label48.Text) + Convert.ToInt32(label46.Text);
                label77.Text = f.ToString();

                restoran.Yad = radioButton6.Text;
                radioButton6.Text = "Tarihi Kalkanoğlu Pilavcısı";

                restoran.Yögley = label64.Text;
                label64.Text = "20";
                restoran.Yaksmy = label62.Text;
                label62.Text = "30";

                label59.Visible = false; label58.Visible = false; label61.Visible = false;
                label60.Visible = false; label61.Visible = false; label67.Visible = false; label66.Visible = false;
                g = Convert.ToInt32(label64.Text) + Convert.ToInt32(label62.Text);
                label79.Text = g.ToString();


            }

            else if (BaseClass.Name == "Almanya")
            {

                label1.Text = "Ortalama Bütçe";
                label20.Text = "Ortalama Bütçe";
                label31.Text = "Ortalama Bütçe";
                label41.Text = "Ortalama Bütçe";
                label57.Text = "Ortalama Bütçe";
                label67.Text = "Ortalama Bütçe";

                basket.Currency = restaurant.y;
                label89.Text = restaurantCity.y;
                label90.Text = restaurantCity.y;
                label91.Text = restaurantCity.y;
                label92.Text = restaurantCity.y;
                label93.Text = restaurantCity.y;
                label94.Text = restaurantCity.y;
                label81.Visible = true;
                label81.Text = "(*Euro birimi olarak giriniz)";

                label83.Visible = false; label84.Visible = false; label85.Visible = false;
                label86.Visible = false; label87.Visible = false; label88.Visible = false;

                radioButton8.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
                radioButton11.Visible = true;
                radioButton12.Visible = true;
                radioButton13.Visible = true;

                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;


                label69.Visible = false; label70.Visible = false; label71.Visible = false;
                label72.Visible = false; label73.Visible = false; label74.Visible = false;
                label75.Visible = false; label76.Visible = false; label77.Visible = false;
                label78.Visible = false; label79.Visible = false; label68.Visible = false; label43.Visible = false;
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "af.jfif";
                pictureBox2.ImageLocation = "mtry.jfif";
                pictureBox3.ImageLocation = "bianc.jfif";
                pictureBox4.ImageLocation = "bdb.jfif";
                pictureBox5.ImageLocation = "ess.jfif";
                pictureBox6.ImageLocation = "gn.jfif";

                pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox13.ImageLocation = "kt.png";
                pictureBox14.ImageLocation = "kt.png";
                pictureBox15.ImageLocation = "kt.png";
                pictureBox16.ImageLocation = "kt.png";
                pictureBox17.ImageLocation = "kt.png";
                pictureBox18.ImageLocation = "kt.png";
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                label10.Visible = false; label22.Visible = false;
                label12.Visible = false; label33.Visible = false; label59.Visible = false;


                restoran.Yad = radioButton8.Text;
                radioButton8.Text = "Atlantik Fish Restaurant";
                restoran.Ybolge = label9.Text;
                label9.Text = "Münih";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label2.Text = "110";
                x = Convert.ToInt32(label2.Text);
                label2.Text = x.ToString();
                label2.BackColor = Color.Firebrick;
                label2.ForeColor = Color.White;
                label2.BorderStyle = BorderStyle.Fixed3D;
                restoran.Yad = radioButton9.Text;
                radioButton9.Text = "M'eatery Bar  Restaurant";
                restoran.Ybolge = label11.Text;
                label11.Text = "Hamburg";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label19.Text = "85";
                label19.BackColor = Color.Firebrick;
                label19.ForeColor = Color.White;
                label19.BorderStyle = BorderStyle.Fixed3D;
                s = Convert.ToInt32(label19.Text);
                label19.Text = s.ToString();
                restoran.Yad = radioButton10.Text;
                radioButton10.Text = "Bianc Restaurant";
                restoran.Ybolge = label21.Text;
                label21.Text = "Hamburg";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label30.Text = "75";
                label30.BackColor = Color.Firebrick;
                label30.ForeColor = Color.White;
                label30.BorderStyle = BorderStyle.Fixed3D;
                h = Convert.ToInt32(label30.Text);
                label30.Text = h.ToString();
                restoran.Yad = radioButton11.Text;
                restoran.Ybolge = label32.Text;
                label32.Text = "Berlin";
                radioButton11.Text = "Bocco di Bocca";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label40.Text = "55";
                label40.BackColor = Color.Firebrick;
                label40.ForeColor = Color.White;
                label40.BorderStyle = BorderStyle.Fixed3D;

                m = Convert.ToInt32(label40.Text);
                label40.Text = m.ToString();
                restoran.Yad = radioButton12.Text;
                radioButton12.Text = "Essence  Restaurant";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                restoran.Ybolge = label42.Text;
                label42.Text = "Münih";
                label54.Text = "50";
                label54.BackColor = Color.Firebrick;
                label54.ForeColor = Color.White;
                label54.BorderStyle = BorderStyle.Fixed3D;



                k = Convert.ToInt32(label54.Text);
                label54.Text = k.ToString();
                restoran.Yad = radioButton13.Text;
                radioButton13.Text = "Gallo Nero";
                restoran.Ybolge = label58.Text;
                label58.Text = "Düsseldorf";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label66.Text = "25";
                label66.BackColor = Color.Firebrick;
                label66.ForeColor = Color.White;
                label66.BorderStyle = BorderStyle.Fixed3D;
                l = Convert.ToInt32(label66.Text);
                label66.Text = l.ToString();



            }
            else if (BaseClass.Name == "Arjantin")
            {
                basket.Currency = restaurant.z;
                label89.Text = restaurantCity.z;
                label90.Text = restaurantCity.z;
                label91.Text = restaurantCity.z;
                label92.Text = restaurantCity.z;
                label93.Text = restaurantCity.z;
                label94.Text = restaurantCity.z;

                label81.Visible = true;
                label81.Text = "(*Ars birimi olarak giriniz)";
                label1.Text = "Ortalama Bütçe";
                label20.Text = "Ortalama Bütçe";
                label31.Text = "Ortalama Bütçe";
                label41.Text = "Ortalama Bütçe";
                label57.Text = "Ortalama Bütçe";
                label67.Text = "Ortalama Bütçe";
                label83.Visible = false; label84.Visible = false; label85.Visible = false;
                label86.Visible = false; label87.Visible = false; label88.Visible = false;
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "ar.jfif";
                pictureBox2.ImageLocation = "ila.jfif";
                pictureBox3.ImageLocation = "bod.jpg";
                pictureBox4.ImageLocation = "az.jfif";
                pictureBox5.ImageLocation = "la.jfif";
                pictureBox6.ImageLocation = "lo.jpg";
                pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox13.ImageLocation = "kt.png";
                pictureBox14.ImageLocation = "kt.png";
                pictureBox15.ImageLocation = "kt.png";
                pictureBox16.ImageLocation = "kt.png";
                pictureBox17.ImageLocation = "kt.png";
                pictureBox18.ImageLocation = "kt.png";
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
                radioButton11.Visible = true;
                radioButton12.Visible = true;
                radioButton13.Visible = true;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;

                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                label10.Visible = false; label22.Visible = false;
                label12.Visible = false; label33.Visible = false; label59.Visible = false;
                label69.Visible = false; label70.Visible = false; label71.Visible = false;
                label72.Visible = false; label73.Visible = false; label74.Visible = false;
                label75.Visible = false; label76.Visible = false; label77.Visible = false;
                label78.Visible = false; label79.Visible = false; label68.Visible = false; label43.Visible = false;

                restoran.Yad = radioButton8.Text;
                radioButton8.Text = "The Argentine Experience";
                label1.Text = "Ortalama Hesap";
                restoran.Ybolge = label9.Text;
                label9.Text = "Buenos Aires";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label2.Text = "7500";
                x = Convert.ToInt32(label2.Text);
                label2.Text = x.ToString();
                label2.BackColor = Color.Firebrick;
                label2.ForeColor = Color.White;
                label2.BorderStyle = BorderStyle.Fixed3D;
                restoran.Yad = radioButton9.Text;
                radioButton9.Text = "İ Latina";
                restoran.Ybolge = label11.Text;
                label20.Text = "Ortalama Bütçe";
                label11.Text = "Buenos Aires";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label19.Text = "6000";
                s = Convert.ToInt32(label19.Text);
                label19.Text = s.ToString();
                label19.BackColor = Color.Firebrick;
                label19.ForeColor = Color.White;
                label19.BorderStyle = BorderStyle.Fixed3D;
                restoran.Yad = radioButton10.Text;
                radioButton10.Text = "Bodega Renacer";
                restoran.Ybolge = label21.Text;
                label21.Text = "Mendoza";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label30.Text = "3000";
                h = Convert.ToInt32(label30.Text);
                label30.Text = h.ToString();
                label30.BackColor = Color.Firebrick;
                label30.ForeColor = Color.White;
                label30.BorderStyle = BorderStyle.Fixed3D;
                restoran.Yad = radioButton11.Text;
                radioButton11.Text = "Azafran";
                restoran.Ybolge = label32.Text;
                label32.Text = "Mendoza";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label40.Text = "2500";
                m = Convert.ToInt32(label40.Text);
                label40.Text = m.ToString();
                label40.BackColor = Color.Firebrick;
                label40.ForeColor = Color.White;
                label40.BorderStyle = BorderStyle.Fixed3D;
                restoran.Yad = radioButton12.Text;
                restoran.Ybolge = label42.Text;
                label42.Text = "Cordoba";
                radioButton12.Text = "Lo de Villalpando Cocina";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label54.Text = "1500";
                k = Convert.ToInt32(label54.Text);
                label54.Text = k.ToString();
                label54.BackColor = Color.Firebrick;
                label54.ForeColor = Color.White;
                label54.BorderStyle = BorderStyle.Fixed3D;
                restoran.Yad = radioButton13.Text;
                restoran.Ybolge = label58.Text;
                label58.Text = "Buenos Aires";
                radioButton13.Text = "La Choripanneria";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label66.Text = "500";
                l = Convert.ToInt32(label66.Text);
                label66.Text = l.ToString();
                label66.BackColor = Color.Firebrick;
                label66.ForeColor = Color.White;
                label66.BorderStyle = BorderStyle.Fixed3D;

            }
            else if (BaseClass.Name == "İtalya")
            {
                basket.Currency = restaurant.y;
                label89.Text = restaurantCity.y;
                label90.Text = restaurantCity.y;
                label91.Text = restaurantCity.y;
                label92.Text = restaurantCity.y;
                label93.Text = restaurantCity.y;
                label94.Text = restaurantCity.y;

                label81.Visible = true;
                label81.Text = "(*Euro birimi olarak giriniz)";

                label83.Visible = false; label84.Visible = false; label85.Visible = false;
                label86.Visible = false; label87.Visible = false; label88.Visible = false;

                label24.Text = "İTALYA";
                label1.Text = "Ortalama Bütçe";
                label20.Text = "Ortalama Bütçe";
                label31.Text = "Ortalama Bütçe";
                label41.Text = "Ortalama Bütçe";
                label57.Text = "Ortalama Bütçe";
                label67.Text = "Ortalama Bütçe";
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "bo.jfif";
                pictureBox2.ImageLocation = "piz.jfif";
                pictureBox3.ImageLocation = "vulio.jfif";
                pictureBox4.ImageLocation = "dry.jfif";
                pictureBox5.ImageLocation = "isido.jpg";
                pictureBox6.ImageLocation = "jc.jfif";
                pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox13.ImageLocation = "kt.png";
                pictureBox14.ImageLocation = "kt.png";
                pictureBox15.ImageLocation = "kt.png";
                pictureBox16.ImageLocation = "kt.png";
                pictureBox17.ImageLocation = "kt.png";
                pictureBox18.ImageLocation = "kt.png";
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
                radioButton11.Visible = true;
                radioButton12.Visible = true;
                radioButton13.Visible = true;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;

                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false; label19.Visible = true; label43.Visible = false;
                label10.Visible = false; label22.Visible = false;
                label12.Visible = false; label33.Visible = false; label59.Visible = false;
                label69.Visible = false; label70.Visible = false; label71.Visible = false;
                label72.Visible = false; label73.Visible = false; label74.Visible = false;
                label75.Visible = false; label76.Visible = false; label77.Visible = false;
                label78.Visible = false; label79.Visible = false; label68.Visible = false;

                restoran.Yad = radioButton8.Text;
                radioButton8.Text = "Bonno Bottega Nostrana";
                restoran.Ybolge = label9.Text;
                label9.Text = "Lazio";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label2.Text = "60";
                x = Convert.ToInt32(label2.Text);
                label66.Text = x.ToString();
                label2.BackColor = Color.Firebrick;
                label2.ForeColor = Color.White;
                label2.BorderStyle = BorderStyle.Fixed3D;
                restoran.Yad = radioButton9.Text;
                radioButton9.Text = "Er Pizzicarolo";
                restoran.Ybolge = label11.Text;
                label11.Text = "Roma";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label19.Text = "50";
                s = Convert.ToInt32(label19.Text);
                label19.Text = s.ToString();
                label19.BackColor = Color.Firebrick;
                label19.ForeColor = Color.White;
                label19.BorderStyle = BorderStyle.Fixed3D;
                restoran.Yad = radioButton10.Text;
                radioButton10.Text = "Vulio Roma";
                restoran.Ybolge = label21.Text;
                label21.Text = "Roma";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label30.Text = "40";
                h = Convert.ToInt32(label30.Text);
                label30.Text = h.ToString();
                label30.BackColor = Color.Firebrick;
                label30.ForeColor = Color.White;
                label30.BorderStyle = BorderStyle.Fixed3D;
                restoran.Yad = radioButton11.Text;
                radioButton11.Text = "Dry Pizzeria";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                restoran.Ybolge = label32.Text;
                label32.Text = "Milano";
                label40.Text = "50";
                label40.BackColor = Color.Firebrick;
                label40.ForeColor = Color.White;
                label40.BorderStyle = BorderStyle.Fixed3D;
                m = Convert.ToInt32(label40.Text);
                label40.Text = m.ToString();
                restoran.Yad = radioButton12.Text;
                radioButton12.Text = "Ristorante Isidoro";
                restoran.Ybolge = label42.Text;
                label42.Text = "Roma";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label54.Text = "30";
                label54.BackColor = Color.Firebrick;
                label54.ForeColor = Color.White;
                label54.BorderStyle = BorderStyle.Fixed3D;
                k = Convert.ToInt32(label54.Text);
                label54.Text = k.ToString();
                restoran.Yad = radioButton13.Text;
                radioButton13.Text = "Jode Cafe";
                restoran.Ybolge = label58.Text;
                label58.Text = "Milano";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label66.Text = "20";
                label66.BackColor = Color.Firebrick;
                label66.ForeColor = Color.White;
                label66.BorderStyle = BorderStyle.Fixed3D;
                l = Convert.ToInt32(label66.Text);
                label66.Text = l.ToString();

            }
            else if (BaseClass.Name == "Norveç")
            {
                basket.Currency = restaurant.t;
                label89.Text = restaurantCity.t;
                label90.Text = restaurantCity.t;
                label91.Text = restaurantCity.t;
                label92.Text = restaurantCity.t;
                label93.Text = restaurantCity.t;
                label94.Text = restaurantCity.t;

                label81.Visible = true;
                label81.Text = "(*Kron birimi olarak giriniz)";
                label83.Visible = false; label84.Visible = false; label85.Visible = false;
                label86.Visible = false; label87.Visible = false; label88.Visible = false;
                label1.Text = "Ortalama Bütçe";
                label20.Text = "Ortalama Bütçe";
                label31.Text = "Ortalama Bütçe";
                label41.Text = "Ortalama Bütçe";
                label57.Text = "Ortalama Bütçe";
                label67.Text = "Ortalama Bütçe";
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "under.jfif";
                pictureBox2.ImageLocation = "18.jpg";
                pictureBox3.ImageLocation = "bs.jpg";
                pictureBox4.ImageLocation = "kont.jpg";
                pictureBox5.ImageLocation = "mir.jpg";
                pictureBox6.ImageLocation = "elias.jpg";
                pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox13.ImageLocation = "kt.png";
                pictureBox14.ImageLocation = "kt.png";
                pictureBox15.ImageLocation = "kt.png";
                pictureBox16.ImageLocation = "kt.png";
                pictureBox17.ImageLocation = "kt.png";
                pictureBox18.ImageLocation = "kt.png";
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
                radioButton11.Visible = true;
                radioButton12.Visible = true;
                radioButton13.Visible = true;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;

                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                label10.Visible = false; label22.Visible = false;
                label12.Visible = false; label33.Visible = false; label59.Visible = false;
                label69.Visible = false; label70.Visible = false; label71.Visible = false;
                label72.Visible = false; label73.Visible = false; label74.Visible = false;
                label75.Visible = false; label76.Visible = false; label77.Visible = false;
                label78.Visible = false; label79.Visible = false; label68.Visible = false; label43.Visible = false;



                restoran.Yad = radioButton8.Text;
                radioButton8.Text = "Under";
                restoran.Ybolge = label9.Text;
                label9.Text = "Lindesnes";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label2.Text = "2200";
                x = Convert.ToInt32(label2.Text);
                label2.BackColor = Color.Firebrick;
                label2.ForeColor = Color.White;
                label2.BorderStyle = BorderStyle.Fixed3D;
                label66.Text = x.ToString();
                restoran.Yad = radioButton9.Text;
                radioButton9.Text = "Restaurant 1877";
                restoran.Ybolge = label11.Text;
                label11.Text = "Bergen";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label19.Text = "650";

                s = Convert.ToInt32(label19.Text);
                label19.Text = s.ToString();
                label19.BackColor = Color.Firebrick;
                label19.ForeColor = Color.White;
                label19.BorderStyle = BorderStyle.Fixed3D;

                restoran.Yad = radioButton10.Text;
                radioButton10.Text = "Bryggeloftet &Stuene";
                restoran.Ybolge = label21.Text;
                label21.Text = "Bergen";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label30.Text = "400";
                h = Convert.ToInt32(label30.Text);
                label30.Text = h.ToString();
                label30.BackColor = Color.Firebrick;
                label30.ForeColor = Color.White;
                label30.BorderStyle = BorderStyle.Fixed3D;
                restoran.Yad = radioButton11.Text;
                radioButton11.Text = "Restaurant Kontrast";
                restoran.Ybolge = label32.Text;
                label32.Text = "Oslo";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label40.Text = "300";
                label40.BackColor = Color.Firebrick;
                label40.ForeColor = Color.White;
                label40.BorderStyle = BorderStyle.Fixed3D;
                m = Convert.ToInt32(label40.Text);
                label40.Text = m.ToString();
                restoran.Yad = radioButton12.Text;
                radioButton12.Text = "Mirabel Restaurant";
                restoran.Ybolge = label42.Text;
                label42.Text = "Oslo";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label54.Text = "200";
                k = Convert.ToInt32(label54.Text);
                label54.Text = k.ToString();
                restoran.Yad = radioButton13.Text;
                label54.BackColor = Color.Firebrick;
                label54.ForeColor = Color.White;
                label54.BorderStyle = BorderStyle.Fixed3D;
                radioButton13.Text = "Elias Mat & Sant";
                restoran.Ybolge = label58.Text;
                label58.Text = "Oslo";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label66.Text = "100";
                l = Convert.ToInt32(label66.Text);
                label66.Text = l.ToString();
                label66.BackColor = Color.Firebrick;
                label66.ForeColor = Color.White;
                label66.BorderStyle = BorderStyle.Fixed3D;
            }

            else if (BaseClass.Name == "Japonya")
            {
                basket.Currency = restaurant.k;
                label89.Text = restaurantCity.k;
                label90.Text = restaurantCity.k;
                label91.Text = restaurantCity.k;
                label92.Text = restaurantCity.k;
                label93.Text = restaurantCity.k;
                label94.Text = restaurantCity.k;


                label81.Visible = true;
                label81.Text = "(*Yen birimi olarak giriniz)";
                label83.Visible = false; label84.Visible = false; label85.Visible = false;
                label86.Visible = false; label87.Visible = false; label88.Visible = false;
                label1.Text = "Ortalama Bütçe";
                label20.Text = "Ortalama Bütçe";
                label31.Text = "Ortalama Bütçe";
                label41.Text = "Ortalama Bütçe";
                label57.Text = "Ortalama Bütçe";
                label67.Text = "Ortalama Bütçe";
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "han.jpg";
                pictureBox2.ImageLocation = "nob.jfif";
                pictureBox3.ImageLocation = "hoku.jfif";
                pictureBox4.ImageLocation = "maid.jpg";
                pictureBox5.ImageLocation = "gyu.jfif";
                pictureBox6.ImageLocation = "ipp.jfif";
                pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox13.ImageLocation = "kt.png";
                pictureBox14.ImageLocation = "kt.png";
                pictureBox15.ImageLocation = "kt.png";
                pictureBox16.ImageLocation = "kt.png";
                pictureBox17.ImageLocation = "kt.png";
                pictureBox18.ImageLocation = "kt.png";
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
                radioButton11.Visible = true;
                radioButton12.Visible = true;
                radioButton13.Visible = true;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;

                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                label10.Visible = false; label22.Visible = false;
                label12.Visible = false; label33.Visible = false; label59.Visible = false;
                label69.Visible = false; label70.Visible = false; label71.Visible = false;
                label72.Visible = false; label73.Visible = false; label74.Visible = false;
                label75.Visible = false; label76.Visible = false; label77.Visible = false;
                label78.Visible = false; label79.Visible = false; label68.Visible = false; label43.Visible = false;



                restoran.Yad = radioButton8.Text;
                radioButton8.Text = "Han No Daidokoro Honten";
                restoran.Ybolge = label9.Text;
                label9.Text = "Tokyo";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label2.Text = "5000";
                label2.BackColor = Color.Firebrick;
                label2.ForeColor = Color.White;
                label2.BorderStyle = BorderStyle.Fixed3D;
                x = Convert.ToInt32(label2.Text);
                label66.Text = x.ToString();
                restoran.Yad = radioButton9.Text;
                radioButton9.Text = "Nabezo Shibuya Koendori ";
                restoran.Ybolge = label11.Text;
                label11.Text = "Tokyo";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label19.Text = "3000";
                label19.BackColor = Color.Firebrick;
                label19.ForeColor = Color.White;
                label19.BorderStyle = BorderStyle.Fixed3D;
                s = Convert.ToInt32(label19.Text);
                label19.Text = s.ToString();
                restoran.Yad = radioButton10.Text;
                radioButton10.Text = "Hokuto Gems Namba ";
                restoran.Ybolge = label21.Text;
                label21.Text = "Osaka";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label30.Text = "2000";
                label30.BackColor = Color.Firebrick;
                label30.ForeColor = Color.White;
                label30.BorderStyle = BorderStyle.Fixed3D;
                h = Convert.ToInt32(label30.Text);
                label30.Text = h.ToString();
                restoran.Yad = radioButton11.Text;
                radioButton11.Text = "Maidremain Nagoya";
                restoran.Ybolge = label32.Text;
                label32.Text = "Nagoya";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label40.Text = "1500";
                label40.BackColor = Color.Firebrick;
                label40.ForeColor = Color.White;
                label40.BorderStyle = BorderStyle.Fixed3D;
                m = Convert.ToInt32(label40.Text);
                label40.Text = m.ToString();
                restoran.Yad = radioButton12.Text;
                radioButton12.Text = "Gyukatsu Notomura Namba ";
                restoran.Ybolge = label42.Text;
                label42.Text = "Osaka";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label54.Text = "1000";
                label54.BackColor = Color.Firebrick;
                label54.ForeColor = Color.White;
                label54.BorderStyle = BorderStyle.Fixed3D;
                k = Convert.ToInt32(label54.Text);
                label54.Text = k.ToString();
                restoran.Yad = radioButton13.Text;
                radioButton13.Text = "Ippudo Roppongi";
                restoran.Ybolge = label58.Text;
                label58.Text = "Minato";
                restoran.YFiyati = Convert.ToInt32(textBox2.Text);
                label66.Text = "600";
                l = Convert.ToInt32(label66.Text);
                label66.Text = l.ToString();
                label66.BackColor = Color.Firebrick;
                label66.ForeColor = Color.White;
                label66.BorderStyle = BorderStyle.Fixed3D;


            }

            else
            {
                MessageBox.Show("Aradığınız il bulunmamaktadır");
            }


        }
 
        private void button4_Click(object sender, EventArgs e)
        {
            RestaurantCity il = new RestaurantCity();
            if (BaseClass.Name == "Antalya")

            {
                if (Convert.ToInt32(textBox1.Text) < 55)
                {
                    MessageBox.Show("En düşük bütçemiz 55 TL'dir");
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.Enabled = false;

                }

                else if (Convert.ToInt32(textBox1.Text) >= 55 && Convert.ToInt32(textBox1.Text) <= 94)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.BackColor = Color.DarkGray;



                }
                else if (Convert.ToInt32(textBox1.Text) >= 95 && Convert.ToInt32(textBox1.Text) <= 109)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 110 && Convert.ToInt32(textBox1.Text) <= 144)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel4.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 145 && Convert.ToInt32(textBox1.Text) <= 239)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 240 && Convert.ToInt32(textBox1.Text) <= 299)
                {
                    panel1.Enabled = false;
                    panel2.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;

                }


                else if (Convert.ToInt32(textBox1.Text) >= 300)
                {
                    panel1.BackColor = Color.DarkGray;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
            }

            else if (BaseClass.Name == "İstanbul")
            {
                if (Convert.ToInt32(textBox1.Text) < 95)
                {
                    MessageBox.Show("En düşük bütçemiz 95 TL'dir");
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.Enabled = false;

                }

                else if (Convert.ToInt32(textBox1.Text) >= 95 && Convert.ToInt32(textBox1.Text) <= 109)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 110 && Convert.ToInt32(textBox1.Text) <= 174)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 175 && Convert.ToInt32(textBox1.Text) <= 249)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 250 && Convert.ToInt32(textBox1.Text) <= 259)
                {
                    panel1.Enabled = false;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 260)
                {
                    panel1.BackColor = Color.DarkGray;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;
                }
            }

            else if (BaseClass.Name == "Ankara")
            {
                if (Convert.ToInt32(textBox1.Text) < 90)
                {
                    MessageBox.Show("En düşük bütçemiz 90 TL'dir");
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.Enabled = false;

                }

                else if (Convert.ToInt32(textBox1.Text) >= 90 && Convert.ToInt32(textBox1.Text) <= 94)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.BackColor = Color.DarkGray;


                }

                else if (Convert.ToInt32(textBox1.Text) >= 95 && Convert.ToInt32(textBox1.Text) <= 99)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 100 && Convert.ToInt32(textBox1.Text) <= 104)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 105 && Convert.ToInt32(textBox1.Text) <= 119)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 120 && Convert.ToInt32(textBox1.Text) <= 159)
                {
                    panel1.Enabled = false;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 160)
                {
                    panel1.BackColor = Color.DarkGray;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }

            }
            else if (BaseClass.Name == "Nevşehir")
            {
                if (Convert.ToInt32(textBox1.Text) < 90)
                {
                    MessageBox.Show("En düşük bütçemiz 100 TL'dir");
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.Enabled = false;

                }

                else if (Convert.ToInt32(textBox1.Text) >= 100 && Convert.ToInt32(textBox1.Text) <= 139)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }

                else if (Convert.ToInt32(textBox1.Text) >= 140 && Convert.ToInt32(textBox1.Text) <= 154)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 155 && Convert.ToInt32(textBox1.Text) <= 219)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 220 && Convert.ToInt32(textBox1.Text) <= 299)
                {
                    panel1.Enabled = false;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 300)
                {
                    panel1.BackColor = Color.DarkGray;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;
                }


            }

            else if (BaseClass.Name == "Mardin")
            {
                if (Convert.ToInt32(textBox1.Text) < 80)
                {
                    MessageBox.Show("En düşük bütçemiz 80 TL'dir");
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.Enabled = false;

                }

                else if (Convert.ToInt32(textBox1.Text) >= 80 && Convert.ToInt32(textBox1.Text) <= 84)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;



                }
                else if (Convert.ToInt32(textBox1.Text) >= 84 && Convert.ToInt32(textBox1.Text) <= 94)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 95 && Convert.ToInt32(textBox1.Text) <= 134)
                {
                    panel1.Enabled = false;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 135)
                {
                    panel1.BackColor = Color.DarkGray;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }

            }
            else if (BaseClass.Name == "Trabzon")
            {
                if (Convert.ToInt32(textBox1.Text) < 45)
                {
                    MessageBox.Show("En düşük bütçemiz 45 TL'dir");
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.Enabled = false;

                }

                else if (Convert.ToInt32(textBox1.Text) >= 45 && Convert.ToInt32(textBox1.Text) <= 49)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.Enabled = false;




                }
                else if (Convert.ToInt32(textBox1.Text) >= 50 && Convert.ToInt32(textBox1.Text) <= 64)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;
                }
                else if (Convert.ToInt32(textBox1.Text) >= 50 && Convert.ToInt32(textBox1.Text) <= 64)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;
                }
                else if (Convert.ToInt32(textBox1.Text) >= 65 && Convert.ToInt32(textBox1.Text) <= 69)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 70 && Convert.ToInt32(textBox1.Text) <= 114)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 115 && Convert.ToInt32(textBox1.Text) <= 134)
                {
                    panel1.Enabled = false;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 135)
                {
                    panel1.BackColor = Color.DarkGray;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }

            }
            else if (BaseClass.Name == "Almanya")
            {
                if (Convert.ToInt32(textBox1.Text) < 25)
                {
                    MessageBox.Show("En düşük bütçemiz 25 Euro'dur");
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.Enabled = false;
                    panel1.Enabled = false;
                }

                else if (Convert.ToInt32(textBox1.Text) >= 25 && Convert.ToInt32(textBox1.Text) <= 49)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 50 && Convert.ToInt32(textBox1.Text) <= 54)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 55 && Convert.ToInt32(textBox1.Text) <= 74)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 75 && Convert.ToInt32(textBox1.Text) <= 84)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 85 && Convert.ToInt32(textBox1.Text) <= 100)
                {
                    panel1.Enabled = false;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 110)
                {
                    panel1.BackColor = Color.DarkGray;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
            }
            else if (BaseClass.Name == "İtalya")
            {
                if (Convert.ToInt32(textBox1.Text) <= 20)
                {
                    MessageBox.Show("En düşük bütçemiz 20 Euro'dur ");
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.Enabled = false;
                    panel1.Enabled = false;
                }
                else if (Convert.ToInt32(textBox1.Text) >= 15 && Convert.ToInt32(textBox1.Text) <= 29)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 30 && Convert.ToInt32(textBox1.Text) <= 39)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel4.Enabled = false;
                    panel3.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 40 && Convert.ToInt32(textBox1.Text) <= 49)
                {

                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.BackColor = Color.DarkGray;
                    panel4.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 50 && Convert.ToInt32(textBox1.Text) <= 59)
                {
                    panel1.Enabled = false;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 60)
                {
                    panel1.BackColor = Color.DarkGray;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
            }
            else if (BaseClass.Name == "Japonya")
            {
                if (Convert.ToInt32(textBox1.Text) < 600)
                {
                    MessageBox.Show("En düşük bütçemiz 600 Yen'dir");
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.Enabled = false;
                    panel1.Enabled = false;

                }

                else if (Convert.ToInt32(textBox1.Text) >= 600 && Convert.ToInt32(textBox1.Text) <= 990)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 1000 && Convert.ToInt32(textBox1.Text) <= 1499)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 1500 && Convert.ToInt32(textBox1.Text) <= 1999)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 2000 && Convert.ToInt32(textBox1.Text) <= 2990)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 3000 && Convert.ToInt32(textBox1.Text) <= 4990)
                {
                    panel1.Enabled = false;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 5000)
                {
                    panel1.BackColor = Color.DarkGray;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;




                }

            }
            else if (BaseClass.Name == "Arjantin")
            {
                if (Convert.ToInt32(textBox1.Text) < 500)
                {
                    MessageBox.Show("En düşük bütçemiz 500 Ars'dır");
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.Enabled = false;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 500 && Convert.ToInt32(textBox1.Text) <= 999)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.BackColor = Color.DarkGray;
                }
                else if (Convert.ToInt32(textBox1.Text) >= 1000 && Convert.ToInt32(textBox1.Text) <= 1999)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 2000 && Convert.ToInt32(textBox1.Text) <= 2499)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 2500 && Convert.ToInt32(textBox1.Text) <= 2999)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 3000 && Convert.ToInt32(textBox1.Text) <= 5999)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 6000 && Convert.ToInt32(textBox1.Text) <= 7499)
                {
                    panel1.Enabled = false;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 7500)
                {


                    panel1.BackColor = Color.DarkGray;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
            }
            else if (BaseClass.Name == "Norveç")
            {


                if (Convert.ToInt32(textBox1.Text) < 100)
                {
                    MessageBox.Show("En düşük bütçemiz 100 Kron'dur");
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.Enabled = false;


                }

                else if (Convert.ToInt32(textBox1.Text) >= 100 && Convert.ToInt32(textBox1.Text) <= 199)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 200 && Convert.ToInt32(textBox1.Text) <= 299)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 300 && Convert.ToInt32(textBox1.Text) <= 399)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 400 && Convert.ToInt32(textBox1.Text) <= 649)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;

                }
                else if (Convert.ToInt32(textBox1.Text) >= 650 && Convert.ToInt32(textBox1.Text) <= 2199)
                {
                    panel1.Enabled = false;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }
                else if (Convert.ToInt32(textBox1.Text) >= 2200)
                {
                    panel1.BackColor = Color.DarkGray;
                    panel2.BackColor = Color.DarkGray;
                    panel3.BackColor = Color.DarkGray;
                    panel4.BackColor = Color.DarkGray;
                    panel5.BackColor = Color.DarkGray;
                    panel6.BackColor = Color.DarkGray;


                }
            }




        }

            private void katalogSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Catalog katalog = new Catalog();
            this.Hide();
            katalog.Show();
        }

        private void müzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Museum muze = new Museum();
            this.Hide();
            muze.Show();

        }

        private void turToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Tour tur = new Tour();
            this.Hide();
            tur.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            label51.Text = " ";
            textBox1.Text = " ";
            textBox2.Text = " ";
            panel2.Enabled = true;
            panel4.Enabled = true;
            panel3.Enabled = true;
            panel5.Enabled = true;
            panel1.Enabled = true;
            panel6.Enabled = true;
            panel1.BackColor = Color.Silver;
            panel2.BackColor = Color.Silver;
            panel3.BackColor = Color.Silver;
            panel4.BackColor = Color.Silver;
            panel5.BackColor = Color.Silver;
            panel6.BackColor = Color.Silver;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            payment.Show();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
       
        BaseClass r = new Cities();
        private void button2_Click(object sender, EventArgs e)
        {
            basket.Add(r);

            Basket.RestaurantPersonTotal = textBox2.Text;
            AdminLogin2.RestaurantPerson = textBox2.Text;
            Basket.RestaurantTotal = label51.Text;
            r.Price = Convert.ToInt32(label51.Text);
            AdminLogin2.RestaurantTotal = label51.Text;
            Basket.total = basket.TotalPrice();

            MessageBox.Show("Seçiminiz Sepete Eklenmiştir");





        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Basket.RestaurantName = radioButton1.Text;

            RestaurantCity bilgi = new RestaurantCity();
            bilgi.YFiyati = a;
            Basket.RestaurantDailyPrice = a.ToString();
            bilgi.YAdeti = Convert.ToInt32(textBox2.Text);
            label51.Text = bilgi.Calculation().ToString();

            bilgi.YFiyati = Convert.ToInt32(textBox1.Text);
            bilgi.YAdeti = Convert.ToInt32(textBox2.Text);
            label51.Text = bilgi.Calculation().ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Basket.RestaurantName = radioButton2.Text;

            RestaurantCity bilgi = new RestaurantCity();

            bilgi.YFiyati = b;
            Basket.RestaurantDailyPrice = b.ToString();
            bilgi.YAdeti = Convert.ToInt32(textBox2.Text);
            label51.Text = bilgi.Calculation().ToString();


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Basket.RestaurantName = radioButton3.Text;


            RestaurantCity bilgi = new RestaurantCity();

            bilgi.YFiyati = c;
            Basket.RestaurantDailyPrice = c.ToString();
            bilgi.YAdeti = Convert.ToInt32(textBox2.Text);
            label51.Text = bilgi.Calculation().ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Basket.RestaurantName = radioButton4.Text;



            RestaurantCity bilgi = new RestaurantCity();

            bilgi.YFiyati = d;
            Basket.RestaurantDailyPrice = d.ToString();
            bilgi.YAdeti = Convert.ToInt32(textBox2.Text);
            label51.Text = bilgi.Calculation().ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Basket.RestaurantName = radioButton5.Text;


            RestaurantCity bilgi = new RestaurantCity();

            bilgi.YFiyati = f;
            Basket.RestaurantDailyPrice = f.ToString();
            bilgi.YAdeti = Convert.ToInt32(textBox2.Text);
            label51.Text = bilgi.Calculation().ToString();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Basket.RestaurantName = radioButton6.Text;


            RestaurantCity bilgi = new RestaurantCity();

            bilgi.YFiyati = g;
            Basket.RestaurantDailyPrice = g.ToString();
            bilgi.YAdeti = Convert.ToInt32(textBox2.Text);
            label51.Text = bilgi.Calculation().ToString();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void konaklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotel yeni = new Hotel();
            this.Hide();
            yeni.Show();

           
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Basket.RestaurantName = radioButton8.Text;

            RestaurantCity bilgi = new RestaurantCity();

            bilgi.YFiyati = x;
            Basket.RestaurantDailyPrice = x.ToString();
            bilgi.YAdeti = Convert.ToInt32(textBox2.Text);
            label51.Text = bilgi.Calculation().ToString();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Basket.RestaurantName = radioButton9.Text;

            RestaurantCity bilgi = new RestaurantCity();

            bilgi.YFiyati = s;
            Basket.RestaurantDailyPrice = s.ToString();
            bilgi.YAdeti = Convert.ToInt32(textBox2.Text);
            label51.Text = bilgi.Calculation().ToString();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Basket.RestaurantName = radioButton10.Text;

            RestaurantCity bilgi = new RestaurantCity();

            bilgi.YFiyati = h;
            Basket.RestaurantDailyPrice = h.ToString();
            bilgi.YAdeti = Convert.ToInt32(textBox2.Text);
            label51.Text = bilgi.Calculation().ToString();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            Basket.RestaurantName = radioButton11.Text;

            RestaurantCity bilgi = new RestaurantCity();

            bilgi.YFiyati = m;
            Basket.RestaurantDailyPrice = m.ToString();
            bilgi.YAdeti = Convert.ToInt32(textBox2.Text);
            label51.Text = bilgi.Calculation().ToString();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            Basket.RestaurantName = radioButton12.Text;

            RestaurantCity bilgi = new RestaurantCity();

            bilgi.YFiyati = k;
            Basket.RestaurantDailyPrice = k.ToString();
            bilgi.YAdeti = Convert.ToInt32(textBox2.Text);
            label51.Text = bilgi.Calculation().ToString();
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            Basket.RestaurantName = radioButton13.Text;

            RestaurantCity bilgi = new RestaurantCity();

            bilgi.YFiyati = l;
            Basket.RestaurantDailyPrice = l.ToString();
            bilgi.YAdeti = Convert.ToInt32(textBox2.Text);
            label51.Text = bilgi.Calculation().ToString();
        }

        private void kayıtOlunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp yeni = new SignUp();
            yeni.Show();
            this.Hide();
        }

        private void ödemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment yeni = new Payment();
            this.Hide();
            payment.Show();
        }

       
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Turkey türkiye = new Turkey();
            türkiye.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            World dünya = new World();
            dünya.Show();
            this.Hide();
        }

        private void ulaşımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transportation ulaşım = new Transportation();
            ulaşım.Show();
            this.Hide();
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage ana = new HomePage();
            ana.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void katalogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void girişYapınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignIn giris = new SignIn();
            this.Hide();
            giris.Show();
        }

        private void şehirlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

           
        
 
