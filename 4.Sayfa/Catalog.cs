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
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Text = "Anasayfaya Dön";

            pictureBox1.ImageLocation = "logo2.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            this.AutoScroll = true;
            this.MaximizeBox = false;
        }

       
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Museum yeni = new Museum();
            yeni.Show();
            this.Hide();

        }

        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hotel yeni = new Hotel();
            yeni.Show();
            this.Hide();
        }

        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Tour yeni = new Tour();
            yeni.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Restaurant yeni = new Restaurant();
            yeni.Show();
            this.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Transportation yeni = new Transportation();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage ana = new HomePage();
            ana.Show();
            this.Hide();

        }
    }
}
