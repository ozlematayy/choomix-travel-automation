using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _4.Sayfa
{
    public partial class SignIn : Form
    {
       
        
        public SignIn()
        {
            InitializeComponent();
        }
       
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            pictureBox1.BackgroundImage = Properties.Resources.user_icon;
            panel1.ForeColor = Color.FromArgb(23, 32, 42);
            textBox1.ForeColor = Color.FromArgb(23, 32, 42);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            pictureBox2.BackgroundImage = Properties.Resources.lock_icon;
            panel2.ForeColor = Color.FromArgb(23, 32, 42);
            textBox2.ForeColor = Color.FromArgb(23, 32, 42);
        }


        public string mail;
        public string tel;

        
        OleDbConnection baglan= new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database5.mdb");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();

              
                OleDbCommand kaydetcmd = new OleDbCommand("SELECT * From kayitsayfasiveritabani WHERE kullaniciadi = '" + textBox1.Text + "' AND sifre = '" + textBox2.Text + "'", baglan);
               
                OleDbDataReader oku = kaydetcmd.ExecuteReader();

                if (oku.Read())
                {
                   
                    mail = oku[1].ToString();
                    tel = oku[3].ToString();
                    LoginAssign gırıs = new LoginAssign(textBox1.Text, mail, tel);
                    MessageBox.Show("Giriş başarılıdır.");
                    
                }
               
            }
            catch
            {
               
                MessageBox.Show("Kullanıcı Adı veya Parola Yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglan.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = "checkin.png";
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label1.Text = "Tekrar Hoşgeldiniz!";

            pictureBox4.ImageLocation = "logo1.png";
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BaseClass.Category == "Muze")
            {
                this.Hide();
                Museum muze = new Museum();
                muze.Show();
            }

            if (BaseClass.Category == "Tur")
            {
                this.Hide();
                Tour tur = new Tour();
                tur.Show();

            }

            if (BaseClass.Category == "Otel")
            {
                this.Hide();
                Hotel otel = new Hotel();
                otel.Show();

            }

            if (BaseClass.Category == "Restoran")
            {
                this.Hide();
                Restaurant rest = new Restaurant();
                rest.Show();

            }

            if (BaseClass.Category == "Odeme")
            {
                this.Hide();
                Payment odeme = new Payment();
                odeme.Show();

            }

            if (BaseClass.Category == "Anasayfa")
            {
                this.Hide();
                HomePage ana = new HomePage();
                ana.Show();
            }
        }
    }
}

