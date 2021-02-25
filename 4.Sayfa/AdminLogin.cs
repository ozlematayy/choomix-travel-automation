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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        AdminCity admin = new AdminCity();
      

        private void admingiris_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            this.MaximizeBox = false;
            BackColor = Color.Silver;
            menuStrip1.BackColor = Color.Silver;

          

            pictureBox1.ImageLocation = "adminicongirl.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.ImageLocation = "logo1.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.ImageLocation = "adminicon.png";
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox4.ImageLocation = "sifregir.png";
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

          

            label1.Text = admin.l1;
            label2.Text = admin.l2;
            label3.Text = admin.l3;
            button1.Text = admin.l4;
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            AdminLogin2 adminLogin = new AdminLogin2();

            if ((textBox1.Text == "admin") && (textBox2.Text == "123456"))
            {

                adminLogin.Show();
                this.Hide();

            }

            else
            {
               
                textBox2.Clear();
                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                textBox1.ForeColor = Color.White;
                textBox2.ForeColor = Color.White;
                MessageBox.Show("Kullanıcı Adı veya Parola hatalı!");
            }
        }
    }
}
