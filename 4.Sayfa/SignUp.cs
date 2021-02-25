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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void kayitsayfasi_Load(object sender, EventArgs e)
        {
            pictureBox6.ImageLocation = "add1.png";
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox7.ImageLocation = "logo1.png";
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

        }

      
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "kullanıcı adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "kullanıcı adı";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "e-posta")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "e posta";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "şifre")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                textBox3.PasswordChar = '*';
            }
        }
        char? none = null;
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "şifre";
                textBox3.ForeColor = Color.Silver;
                textBox3.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "şifre tekrar")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
                textBox4.PasswordChar = '*';
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "şifre tekrar";
                textBox4.ForeColor = Color.Silver;
                textBox4.PasswordChar = Convert.ToChar(none);
            }
        }
        

        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database5.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void button2_Click(object sender, EventArgs e)
        {

            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO kayitsayfasiveritabani (kullaniciadi,mail,sifre,telefon) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox5.Text.ToString() + "')", baglantı);
            
            komut.Connection = baglantı;
            komut.ExecuteNonQuery();
            baglantı.Close();
            
            label2.Text = "Kaydınız Başarılı! Giriş yapabilirsiniz.";
            label2.ForeColor =Color.Green;
        }

        private void katalogSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Catalog katalog = new Catalog();
            this.Hide();
            katalog.Show();
        }

        private void restoranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Restaurant reestoran = new Restaurant();
            this.Hide();
            reestoran.Show();
        }

        private void müzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Museum muze = new Museum();
            this.Hide();
            muze.Show();
        }

        private void konaklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Hotel otel = new Hotel();
            this.Hide();
            otel.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Turkey türkiye = new Turkey();
            this.Hide();
            türkiye.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            World dünya = new World();
            dünya.Show();
            this.Hide();
        }

        private void turToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tour tur = new Tour();
            this.Hide();
            tur.Show();
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage ana = new HomePage();
            this.Hide();
            ana.Show();
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "telefon numarası")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;

            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "telefon numarası";
                textBox5.ForeColor = Color.Silver;
            }
        }

        private void ulaşımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transportation ulasim = new Transportation();
            ulasim.Show();
            this.Hide();
        }

        private void ödemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment odeme = new Payment();
            this.Hide();
            odeme.Show();
        }

        private void girişYapınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignIn giris = new SignIn();
            giris.Show();
            this.Hide();
        }
    }
}
