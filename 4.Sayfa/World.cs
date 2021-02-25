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
    public partial class World : Form
    {
        public World()
        {
            InitializeComponent();
        }

        private void dünya_Load(object sender, EventArgs e)
        {


            Cities.tanım = "Dunya";
            this.AutoScroll = true;
            this.MaximizeBox = false;

            label1.Text = "Dünya'da En Çok Tercih Edilen Yerler:";

            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox5.ImageLocation = "logo1.png";
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;


            label2.Text = "Almanya-Neuschwanstein Şatosu";

            label3.Text = "İtalya-Kolezyum";

            label4.Text = "Trolltunga-Norveç";

            label5.Text = "Tokyo İmparatorluk Sarayı-Japonya";

            comboBox1.Text = "Ülke Seçiniz";



            comboBox1.Items.Add(Country.Almanya);
            comboBox1.Items.Add(Country.Arjantin);
            comboBox1.Items.Add(Country.Japonya);
            comboBox1.Items.Add(Country.Norveç);
            comboBox1.Items.Add(Country.İtalya);



            button2.Text = "Kataloğa Git";


            button1.Text = "Anasayfaya Dön";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage anasayfa = new HomePage();
            anasayfa.Show();
            this.Hide();
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
                Console.WriteLine("Lütfen ülke seçiniz");
            }


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Cities ülke = new Cities();
            if (comboBox1.Text == Country.Almanya.ToString())
            {
                BaseClass.Name = comboBox1.Text;
                button2.Text = BaseClass.Name;

            }
            else if (comboBox1.Text == Country.Arjantin.ToString())
            {
                BaseClass.Name = comboBox1.Text;
                button2.Text = BaseClass.Name;
            }
            else if (comboBox1.Text == Country.İtalya.ToString())
            {
                BaseClass.Name = comboBox1.Text;
                button2.Text = BaseClass.Name;
            }
            else if (comboBox1.Text == Country.Japonya.ToString())
            {
                BaseClass.Name = comboBox1.Text;
                button2.Text = BaseClass.Name;
            }
            else if (comboBox1.Text == Country.Norveç.ToString())
            {
                BaseClass.Name = comboBox1.Text;
                button2.Text = BaseClass.Name;

            }

        }
    }


}
