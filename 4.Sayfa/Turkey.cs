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
    public partial class Turkey : Form
    {
        public Turkey()
        {
            InitializeComponent();
        }

        private void türkiye_Load(object sender, EventArgs e)
        {
            Cities.tanım = "Turkiye";
            this.AutoScroll = true;
            this.MaximizeBox = false;

            label1.Text = "Türkiye'de En Çok Tercih Edilen Yerler:";


            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.ImageLocation = "logo1.png";


            label2.Text = "Antalya-Lara Düden Şelalesi";


            label3.Text = "Nevşehir-Kapadokya";


            label4.Text = "Trabzon-Uzungöl";


            label5.Text = "Ankara-Anıtkabir";

            comboBox1.Text = "Şehir Seçiniz";

            comboBox1.Items.Add(City.Ankara);
            comboBox1.Items.Add(City.Antalya);
            comboBox1.Items.Add(City.Mardin);
            comboBox1.Items.Add(City.Nevşehir);
            comboBox1.Items.Add(City.Trabzon);
            comboBox1.Items.Add(City.İstanbul);


            button1.Text = "Anasayfaya Dön";


            button2.Text = "Kataloğa Git";




        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            HomePage anasayfa = new HomePage();
            anasayfa.Show();
            this.Hide();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cities şehir = new Cities();
            if (comboBox1.Text == City.Ankara.ToString())
            {
                BaseClass.Name = comboBox1.Text;
                button2.Text = BaseClass.Name;

            }
            else if (comboBox1.Text == City.Antalya.ToString())
            {
                BaseClass.Name = comboBox1.Text;
                button2.Text = BaseClass.Name;
            }
            else if (comboBox1.Text == City.Mardin.ToString())
            {
                BaseClass.Name = comboBox1.Text;
                button2.Text = BaseClass.Name;
            }
            else if (comboBox1.Text == City.Nevşehir.ToString())
            {
                BaseClass.Name = comboBox1.Text;
                button2.Text = BaseClass.Name;
            }
            else if (comboBox1.Text == City.Trabzon.ToString())
            {
                BaseClass.Name = comboBox1.Text;
                button2.Text = BaseClass.Name;

            }
            else if (comboBox1.Text == City.İstanbul.ToString())
            {
                BaseClass.Name = comboBox1.Text;
                button2.Text = BaseClass.Name;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == BaseClass.Name)
            {

                Catalog katalog = new Catalog();
                katalog.Show();
                this.Hide();
            }
            else if (button2.Text == "Kataloğa Git")
            {

                Console.WriteLine("Lütfen şehir seçiniz");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
    
    
