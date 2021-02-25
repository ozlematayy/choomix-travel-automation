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
    public partial class Museum : Form
    {
        public Museum()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        Basket basket = new Basket();

        BaseClass museum = new MuseumCity();
        MuseumCity museumCity = new MuseumCity();

        public void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.AutoScroll = true;

            BaseClass.Category = "Muze";


            label1.Text = BaseClass.Name;
            label3.Text = museumCity.txt1;
            label5.Text = museumCity.txt3;
            button1.Text = museumCity.txt4;
            button2.Text = museumCity.txt5;
            button3.Text = museumCity.txt6;
            button4.Text = museumCity.txt7;
            label46.Text = "* Seçmek zorunludur.";


            label47.Text = LoginAssign.User;
            if ((label47.Text != LoginAssign.User) || (LoginAssign.User == "0"))
            {
                label47.Text = "Giriş Yapınız.";
                label47.ForeColor = Color.Maroon;
            }
            else
            {
                label47.Text = "HOŞGELDİN " + LoginAssign.User;
                label47.ForeColor = Color.SeaGreen;
            }

            basket.Add(museumCity);


            pictureBox31.ImageLocation = "museum3.png";
            pictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox7.ImageLocation = "visitors.png";
            pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox8.ImageLocation = "museum-ticket.png";
            pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox9.ImageLocation = "museum1.png";
            pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox10.ImageLocation = "museum2.png";
            pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox12.ImageLocation = "visitors.png";
            pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox11.ImageLocation = "museum-ticket.png";
            pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox13.ImageLocation = "museum1.png";
            pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox14.ImageLocation = "museum2.png";
            pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox17.ImageLocation = "visitors.png";
            pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox18.ImageLocation = "museum-ticket.png";
            pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox16.ImageLocation = "museum1.png";
            pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox15.ImageLocation = "museum2.png";
            pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox20.ImageLocation = "visitors.png";
            pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox21.ImageLocation = "museum-ticket.png";
            pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox19.ImageLocation = "museum1.png";
            pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox6.ImageLocation = "museum2.png";
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox23.ImageLocation = "visitors.png";
            pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox24.ImageLocation = "museum-ticket.png";
            pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.ImageLocation = "museum1.png";
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.ImageLocation = "museum2.png";
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox28.ImageLocation = "visitors.png";
            pictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox29.ImageLocation = "museum-ticket.png";
            pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox27.ImageLocation = "museum1.png";
            pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox26.ImageLocation = "museum2.png";
            pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox32.ImageLocation = "logo1.png";
            pictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            label31.Text = museumCity.text1;
            label6.Text = museumCity.Day;
            label24.Text = "Açılış: 10:00" + " Kapanış: 17:00";
            label7.Text = museumCity.text2;

            label23.Text = museumCity.text1;
            label10.Text = museumCity.WeekDay;
            label28.Text = "Açılış: 10:00" + " Kapanış: 17:00";
            label27.Text = museumCity.text2;

            label12.Text = museumCity.text1;
            label29.Text = museumCity.Day;
            label14.Text = "Açılış: 08:00" + " Kapanış: 19:00";
            label13.Text = museumCity.text2;

            label20.Text = museumCity.text1;
            label33.Text = museumCity.Day;
            label22.Text = "Açılış: 08:00" + " Kapanış: 19:00";
            label21.Text = museumCity.text2;

            label2.Text = museumCity.text1;
            label18.Text = museumCity.Day;
            label16.Text = "Açılış: 10:00" + " Kapanış: 19:00";
            label15.Text = museumCity.text2;

            label35.Text = museumCity.text1;
            label39.Text = museumCity.Day;
            label37.Text = "Açılış: 10:00" + " Kapanış: 17:00";
            label36.Text = museumCity.text2;


            if (BaseClass.Name == "Nevşehir")
            {

                basket.Currency = museum.x;


                label4.Text = museumCity.x;
                label41.Text = museumCity.x;
                label42.Text = museumCity.x;
                label43.Text = museumCity.x;
                label44.Text = museumCity.x;
                label45.Text = museumCity.x;


                radioButton3.Text = MuseumName.NevsehirMuzesi.ToString();
                radioButton4.Text = MuseumName.ZelveAçıkHavaMüzesi.ToString();
                radioButton2.Text = MuseumName.GöremeAçıkHavaMüzesi.ToString();
                radioButton5.Text = MuseumName.KaymaklıYeraltıŞehri.ToString();
                radioButton6.Text = MuseumName.AçıksarayÖrenyeri.ToString();
                radioButton7.Text = MuseumName.StJeanKilisesi.ToString();

                foreach (var prd in basket.GetAtama())
                {

                    museumCity.Kayıt(MuseumName.NevsehirMuzesi);
                    label25.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label8.Text = " 350 Evler Mh., 50300 Nevşehir, Türkiye";

                    museumCity.Kayıt(MuseumName.ZelveAçıkHavaMüzesi);
                    label11.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label9.Text = "Zelve Yolu, Nevşehir Türkiye";

                    museumCity.Kayıt(MuseumName.GöremeAçıkHavaMüzesi);
                    label30.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label26.Text = "50180 Göreme,Nevşehir";

                    museumCity.Kayıt(MuseumName.KaymaklıYeraltıŞehri);
                    label34.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label32.Text = "Cami Kebir Mh. 50760 Kaymaklı/Nevşehir";

                    museumCity.Kayıt(MuseumName.AçıksarayÖrenyeri);
                    label19.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label17.Text = " Nevşehir Gülşehir";

                    museumCity.Kayıt(MuseumName.StJeanKilisesi);
                    label40.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = " Nevşehir Gülşehir";


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }

                pictureBox1.ImageLocation = "nevsehir-muzesi.jpg";
                pictureBox2.ImageLocation = "zelve-açık-hava-müzesi.jpg";
                pictureBox3.ImageLocation = "göreme-acık-hava-muzesi-1.jpg";
                pictureBox22.ImageLocation = "kapadokya-yeralti-sehirleri.jpg";
                pictureBox25.ImageLocation = "gulsehir-kapadokyaq1.jpg";
                pictureBox30.ImageLocation = "ST.Jean1.jpg";



            }

            else if (BaseClass.Name == "İstanbul")
            {

                basket.Currency = museum.x;


                label4.Text = museumCity.x;
                label41.Text = museumCity.x;
                label42.Text = museumCity.x;
                label43.Text = museumCity.x;
                label44.Text = museumCity.x;
                label45.Text = museumCity.x;


                radioButton3.Text = MuseumName.TopkapıSarayı.ToString();
                radioButton4.Text = MuseumName.İstanbulArkeolojiMüzesi.ToString();
                radioButton2.Text = MuseumName.DenizMüzesi.ToString();
                radioButton5.Text = MuseumName.YerebatanSarnıcı.ToString();
                radioButton6.Text = MuseumName.OyuncakMüzesi.ToString();
                radioButton7.Text = MuseumName.KlasikOtmobilMüzesi.ToString();

                foreach (var prd in basket.GetAtama())
                {

                    museumCity.Kayıt(MuseumName.TopkapıSarayı);
                    label25.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label8.Text = " Cankurtaran, 34122 Fatih/İstanbul, Türkiye";

                    museumCity.Kayıt(MuseumName.İstanbulArkeolojiMüzesi);
                    label11.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label9.Text = "Cankurtaran, 34122 Fatih/İstanbul Türkiye";

                    museumCity.Kayıt(MuseumName.DenizMüzesi);
                    label30.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label26.Text = "Sinanpaşa, 34353 Beşiktaş/İstanbul";

                    museumCity.Kayıt(MuseumName.YerebatanSarnıcı);
                    label34.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label32.Text = "Alemdar, 34110 Fatih/İstanbul";

                    museumCity.Kayıt(MuseumName.OyuncakMüzesi);
                    label19.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label17.Text = "Göztepe Mah. No:17, 34730 Kadıköy";

                    museumCity.Kayıt(MuseumName.KlasikOtmobilMüzesi);
                    label40.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = "Ferahevler, 34457 Sarıyer/İstanbul";


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }


                pictureBox1.ImageLocation = "Topkapi Palace.jpg";
                pictureBox2.ImageLocation = "İstanbul Arkeoloji Müzesi.jpg";
                pictureBox3.ImageLocation = "DenizMuzesi.png";
                pictureBox22.ImageLocation = "Yerebatan Sarnıcı.jpg";
                pictureBox25.ImageLocation = "Oyuncak Muzesi.jpg";
                pictureBox30.ImageLocation = "Klasik Otomobil Muzesi.jpg";



            }

            else if (BaseClass.Name == "Antalya")
            {

                basket.Currency = museum.x;


                label4.Text = museumCity.x;
                label41.Text = museumCity.x;
                label42.Text = museumCity.x;
                label43.Text = museumCity.x;
                label44.Text = museumCity.x;
                label45.Text = museumCity.x;


                radioButton3.Text = MuseumName.AntalyaMuzesi.ToString();
                radioButton4.Text = MuseumName.SunaİnanKaleiçiMüzesi.ToString();
                radioButton2.Text = MuseumName.DenizBiyolojisiMüzesi.ToString();
                radioButton5.Text = MuseumName.Sandland.ToString();
                radioButton6.Text = MuseumName.HababamSınıfıMüzesi.ToString();
                radioButton7.Text = MuseumName.EtnografyaMüzesi.ToString();

                foreach (var prd in basket.GetAtama())
                {

                    museumCity.Kayıt(MuseumName.AntalyaMuzesi);
                    label25.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label8.Text = "Bahçelievler, 07050 Muratpaşa/Antalya";

                    museumCity.Kayıt(MuseumName.SunaİnanKaleiçiMüzesi);
                    label11.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label9.Text = "Barbaros, 07100 Muratpaşa/Antalya";

                    museumCity.Kayıt(MuseumName.DenizBiyolojisiMüzesi);
                    label30.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label26.Text = "Selçuk, Selçuk Mah, 07100 Muratpaşa/Antalya";

                    museumCity.Kayıt(MuseumName.Sandland);
                    label34.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label32.Text = "Lara Halk Plajı, 07230 Muratpaşa/Antalya";

                    museumCity.Kayıt(MuseumName.HababamSınıfıMüzesi);
                    label19.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label17.Text = "Esentepe, 4980. Sk., 07020 Kepez/Antalya";

                    museumCity.Kayıt(MuseumName.EtnografyaMüzesi);
                    label40.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = "Kılınçarslan Mahallesi Muratpaşa / ANTALYA";


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }


                pictureBox1.ImageLocation = "AntalyaMuzesi .jpg";
                pictureBox2.ImageLocation = "SunaInanKaleiciMuzesi.jpg";
                pictureBox3.ImageLocation = "denizbiyolojisimuzesi.jpg";
                pictureBox22.ImageLocation = "sandland.jpg";
                pictureBox25.ImageLocation = "HababamSinifiMuzesi .jpg";
                pictureBox30.ImageLocation = "EtnografyaMuzesi .jpg";


            }

            else if (BaseClass.Name == "Mardin")
            {

                basket.Currency = museum.x;


                label4.Text = museumCity.x;
                label41.Text = museumCity.x;
                label42.Text = museumCity.x;
                label43.Text = museumCity.x;
                label44.Text = museumCity.x;
                label45.Text = museumCity.x;


                radioButton3.Text = MuseumName.MardinMüzesi.ToString();
                radioButton4.Text = MuseumName.SakıpSabancıKentMüzesi.ToString();
                radioButton2.Text = MuseumName.EğitimTarihiMüzesiArtuklu.ToString();
                radioButton5.Text = MuseumName.MidyatKonukevi.ToString();
                radioButton6.Text = MuseumName.MorBehnamKırklıKilisesi.ToString();
                radioButton7.Text = MuseumName.DaraAntikKenti.ToString();

                foreach (var prd in basket.GetAtama())
                {
                    museumCity.Kayıt(MuseumName.MardinMüzesi);
                    label25.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label8.Text = "Şar, 47100 Artuklu, Türkiye";

                    museumCity.Kayıt(MuseumName.SakıpSabancıKentMüzesi);
                    label11.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label9.Text = "Şehidiye, 47100 Mardin Merkez/Mardin";

                    museumCity.Kayıt(MuseumName.EğitimTarihiMüzesiArtuklu);
                    label30.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label26.Text = "Latifiye, 1. Cadde No:417, 47100 Artuklu/Mardin";

                    museumCity.Kayıt(MuseumName.MidyatKonukevi);
                    label34.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label32.Text = "Akçakaya, 148. Sk., 47510 Midyat/Mardin";

                    museumCity.Kayıt(MuseumName.MorBehnamKırklıKilisesi);
                    label19.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label17.Text = "Şar, 1. Cadde No:416, 47100 Merkez/Mardin";

                    museumCity.Kayıt(MuseumName.DaraAntikKenti);
                    label40.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = "Dara Köyü, Artuklu Mardin";


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }


                pictureBox1.ImageLocation = "MardinMüzesi.jpg";
                pictureBox2.ImageLocation = "SakıpSabancıKentMüzesi.jpg";
                pictureBox3.ImageLocation = "EgitimTarihiMüzesiArtuklu.jpg";
                pictureBox22.ImageLocation = "midyatkonukevi.jpg";
                pictureBox25.ImageLocation = "MorBehnamKırklıKilisesi.jpg";
                pictureBox30.ImageLocation = "DaraAntikKenti .jpg";


            }

            else if (BaseClass.Name == "Trabzon")
            {

                basket.Currency = museum.x;


                label4.Text = museumCity.x;
                label41.Text = museumCity.x;
                label42.Text = museumCity.x;
                label43.Text = museumCity.x;
                label44.Text = museumCity.x;
                label45.Text = museumCity.x;


                radioButton3.Text = MuseumName.SümelaManastırı.ToString();
                radioButton4.Text = MuseumName.TrabzonMüzesi.ToString();
                radioButton2.Text = MuseumName.AtatürkKöşkü.ToString();
                radioButton5.Text = MuseumName.OrtahisarTarihMüzesi.ToString();
                radioButton6.Text = MuseumName.EdebiyatMüzesi.ToString();
                radioButton7.Text = MuseumName.TrabzonSporMüzesi.ToString();

                foreach (var prd in basket.GetAtama())
                {

                    museumCity.Kayıt(MuseumName.SümelaManastırı);
                    label25.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label8.Text = "Altındere, 61750 Maçka/Trabzon, Türkiye";

                    museumCity.Kayıt(MuseumName.TrabzonMüzesi);
                    label11.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label9.Text = "Gazipaşa, 61030 Trabzon Merkez/Trabzon";

                    museumCity.Kayıt(MuseumName.AtatürkKöşkü);
                    label30.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label26.Text = "Soğuksu, Ata Cd. No:1, 61040 Ortahisar/Trabzon";

                    museumCity.Kayıt(MuseumName.OrtahisarTarihMüzesi);
                    label34.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label32.Text = "Ortahisar, 61030 Trabzon Merkez";

                    museumCity.Kayıt(MuseumName.EdebiyatMüzesi);
                    label19.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label17.Text = " Ortahisar, 61030 Merkez/Trabzon";

                    museumCity.Kayıt(MuseumName.TrabzonSporMüzesi);
                    label40.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = "Kemerkaya, 61200 Trabzon Merkez/Trabzon";


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }


                pictureBox1.ImageLocation = "SumelaManastırı.jpg";
                pictureBox2.ImageLocation = "TRABZON-MUZESI .jpg";
                pictureBox3.ImageLocation = "trabzonataturkkosku .jpg";
                pictureBox22.ImageLocation = "TrabzonOrtahisarTarihMüzesi.jpg";
                pictureBox25.ImageLocation = "EdebiyatMüzesi.jpg";
                pictureBox30.ImageLocation = "trabzonsporsamilekinciMüzesi.jpg";
            }

            else if (BaseClass.Name == "Ankara")
            {

                basket.Currency = museum.x;


                label4.Text = museumCity.x;
                label41.Text = museumCity.x;
                label42.Text = museumCity.x;
                label43.Text = museumCity.x;
                label44.Text = museumCity.x;
                label45.Text = museumCity.x;


                radioButton3.Text = MuseumName.AtatürkveKurtuluşSavaşıMüzesiAnıtkabir.ToString();
                radioButton4.Text = MuseumName.CumhuriyetMüzesi.ToString();
                radioButton2.Text = MuseumName.KurtuluşSavaşıMüzesi.ToString();
                radioButton5.Text = MuseumName.AnadoluMedeniyetleriMüzesi.ToString();
                radioButton6.Text = MuseumName.EtnografyaMuzesiAnkara.ToString();
                radioButton7.Text = MuseumName.ODTÜBilimveTeknolojiMüzesi.ToString();

                foreach (var prd in basket.GetAtama())
                {

                    museumCity.Kayıt(MuseumName.AtatürkveKurtuluşSavaşıMüzesiAnıtkabir);
                    label25.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label8.Text = "Maltepe, Anıt Cd., 06570 Çankaya/Ankara, Türkiye";

                    museumCity.Kayıt(MuseumName.CumhuriyetMüzesi);
                    label11.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label9.Text = " Doğanbey, 06050 Altındağ/Ankara";

                    museumCity.Kayıt(MuseumName.KurtuluşSavaşıMüzesi);
                    label30.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label26.Text = "Anafartalar, 06050 Altındağ/Ankara";

                    museumCity.Kayıt(MuseumName.AnadoluMedeniyetleriMüzesi);
                    label34.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label32.Text = "Kale, Gözcü Sk. No:2, 06240 Ulus/Altındağ";

                    museumCity.Kayıt(MuseumName.EtnografyaMuzesiAnkara);
                    label19.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label17.Text = "Opera, Sıhhiye, Ankara";

                    museumCity.Kayıt(MuseumName.ODTÜBilimveTeknolojiMüzesi);
                    label40.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = "Üniversiteler, 06800 Çankaya/Ankara";


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }


                pictureBox1.ImageLocation = "Atatürk ve Kurtuluş Savaşı MüzesiAnıtkabir.jpg";
                pictureBox2.ImageLocation = "CumhuriyetMüzesi.jpg";
                pictureBox3.ImageLocation = "KurtuluşSavaşıMüzesi.png";
                pictureBox22.ImageLocation = "AnadoluMedeniyetleriMüzesi.jpg";
                pictureBox25.ImageLocation = "EtnografyaMuzesiAnkara.jpg";
                pictureBox30.ImageLocation = "ODTÜBilimveTeknolojiMüzesi.jpg";
            }

            else if (BaseClass.Name == "Almanya")
            {

                basket.Currency = museum.y;


                label4.Text = museumCity.y;
                label41.Text = museumCity.y;
                label42.Text = museumCity.y;
                label43.Text = museumCity.y;
                label44.Text = museumCity.y;
                label45.Text = museumCity.y;


                radioButton3.Text = MuseumName.BergamaMuseum.ToString();
                radioButton4.Text = MuseumName.AlteNationalGalerie.ToString();
                radioButton2.Text = MuseumName.BodeMuseum.ToString();
                radioButton5.Text = MuseumName.AltePinakothek.ToString();
                radioButton6.Text = MuseumName.SenckenbergMuseum.ToString();
                radioButton7.Text = MuseumName.StädelMuseum.ToString();

                foreach (var prd in basket.GetAtama())
                {

                    museumCity.Kayıt(MuseumName.BergamaMuseum);
                    label25.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label8.Text = "Bodestraße 1-3, 10178 Berlin, Almanya";

                    museumCity.Kayıt(MuseumName.AlteNationalGalerie);
                    label11.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label9.Text = "Bodestraße 1-3, 10178 Berlin, Almanya";

                    museumCity.Kayıt(MuseumName.BodeMuseum);
                    label30.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label26.Text = "Am Kupfergraben, 10117 Berlin, Almanya";

                    museumCity.Kayıt(MuseumName.AltePinakothek);
                    label34.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label32.Text = "Barer Str. 27, 80333 München, Almanya";

                    museumCity.Kayıt(MuseumName.SenckenbergMuseum);
                    label19.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label17.Text = "Senckenberganlage 25, 60325 Frankfurt am Main";

                    museumCity.Kayıt(MuseumName.StädelMuseum);
                    label40.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = "Schaumainkai 63, 60596 Frankfurt am Main";


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }


                pictureBox1.ImageLocation = "BergamaMuseum.jpg";
                pictureBox2.ImageLocation = "ALTENATIONALGALERIE.jpg";
                pictureBox3.ImageLocation = "BodeMuseum .jpg";
                pictureBox22.ImageLocation = "altepinakothek.jpg";
                pictureBox25.ImageLocation = "SenckenbergMuseum.jpg";
                pictureBox30.ImageLocation = "StaedelMuseum.jpg";
            }

            else if (BaseClass.Name == "İtalya")
            {

                basket.Currency = museum.y;


                label4.Text = museumCity.y;
                label41.Text = museumCity.y;
                label42.Text = museumCity.y;
                label43.Text = museumCity.y;
                label44.Text = museumCity.y;
                label45.Text = museumCity.y;


                radioButton3.Text = MuseumName.GalleriaBorghese.ToString();
                radioButton4.Text = MuseumName.Uffizi.ToString();
                radioButton2.Text = MuseumName.PittiPalace.ToString();
                radioButton5.Text = MuseumName.CaptaliniMuseum.ToString();
                radioButton6.Text = MuseumName.Pantheon.ToString();
                radioButton7.Text = MuseumName.GalileoMuseum.ToString();

                foreach (var prd in basket.GetAtama())
                {

                    museumCity.Kayıt(MuseumName.GalleriaBorghese);
                    label25.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label8.Text = "Piazzale Scipione Borghese, 5, 00197 Roma RM, İtalya";

                    museumCity.Kayıt(MuseumName.Uffizi);
                    label11.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label9.Text = " Piazzale degli Uffizi, 6, 50122 Firenze FI, İtalya";

                    museumCity.Kayıt(MuseumName.PittiPalace);
                    label30.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label26.Text = "Piazza de' Pitti, 1, 50125 Firenze FI, İtalya";

                    museumCity.Kayıt(MuseumName.CaptaliniMuseum);
                    label34.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label32.Text = "Piazza del Campidoglio, 1, 00186 Roma RM, İtalya";

                    museumCity.Kayıt(MuseumName.Pantheon);
                    label19.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label17.Text = " Piazza della Rotonda, 00186 Roma RM, İtalya";

                    museumCity.Kayıt(MuseumName.GalileoMuseum);
                    label40.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = "Piazza dei Giudici, 1, 50122 Firenze FI, İtalya";


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }


                pictureBox1.ImageLocation = "GalleriaBorghese.jpg";
                pictureBox2.ImageLocation = "Uffizi.jpg";
                pictureBox3.ImageLocation = "PittiPalace.jpg";
                pictureBox22.ImageLocation = "CaptaliniMuseum.jpg";
                pictureBox25.ImageLocation = "Pantheon.jpg";
                pictureBox30.ImageLocation = "GalileoMuseum.jpg";
            }

            else if (BaseClass.Name == "Arjantin")
            {

                basket.Currency = museum.y;


                label4.Text = museumCity.z;
                label41.Text = museumCity.z;
                label42.Text = museumCity.z;
                label43.Text = museumCity.z;
                label44.Text = museumCity.z;
                label45.Text = museumCity.z;


                radioButton3.Text = MuseumName.MuseoNacionaldeArteDecorativo.ToString();
                radioButton4.Text = MuseumName.BenitoQuinquelaMartínMuseum.ToString();
                radioButton2.Text = MuseumName.MuseoDeLaPlata.ToString();
                radioButton5.Text = MuseumName.XulSolarMuseum.ToString();
                radioButton6.Text = MuseumName.AmaliaLacrozdeFortabatArtCollection.ToString();
                radioButton7.Text = MuseumName.MuseodeArteContemporáneodeSalta.ToString();

                foreach (var prd in basket.GetAtama())
                {

                    museumCity.Kayıt(MuseumName.MuseoNacionaldeArteDecorativo);
                    label25.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label8.Text = " Av. del Libertador 1902, C1425 CABA, Arjantin";

                    museumCity.Kayıt(MuseumName.BenitoQuinquelaMartínMuseum);
                    label11.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label9.Text = "Av. Don Pedro de Mendoza 1835, Buenos Aires";

                    museumCity.Kayıt(MuseumName.MuseoDeLaPlata);
                    label30.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label26.Text = "Paseo del Bosque s/n, B1900 La Plata Buenos Aires";

                    museumCity.Kayıt(MuseumName.XulSolarMuseum);
                    label34.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label32.Text = "Laprida 1212, C1425 EKF, Buenos Aires, Arjantin";

                    museumCity.Kayıt(MuseumName.AmaliaLacrozdeFortabatArtCollection);
                    label19.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label17.Text = "Olga Cossettini 141, C1107 CABA, Arjantin";

                    museumCity.Kayıt(MuseumName.MuseodeArteContemporáneodeSalta);
                    label40.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = "Independencia 122, X5000 Córdoba, Arjantin";


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }


                pictureBox1.ImageLocation = "Museo Nacional de Arte Decorativo.jpg";
                pictureBox2.ImageLocation = "BenitoQuinquelaMartínMuseum.jpg";
                pictureBox3.ImageLocation = "MuseoDeLaPlata.jpg";
                pictureBox22.ImageLocation = "XulSolarMuseum.jpg";
                pictureBox25.ImageLocation = "AmaliaLacrozdeFortabatArtCollection.jpg";
                pictureBox30.ImageLocation = "MuseodeArteContemporáneodeSalta.jpg";
            }

            else if (BaseClass.Name == "Japonya")
            {

                basket.Currency = museum.k;


                label4.Text = museumCity.k;
                label41.Text = museumCity.k;
                label42.Text = museumCity.k;
                label43.Text = museumCity.k;
                label44.Text = museumCity.k;
                label45.Text = museumCity.k;


                radioButton3.Text = MuseumName.TokyoNationalMuseum.ToString();
                radioButton4.Text = MuseumName.TeamLabPlanets.ToString();
                radioButton2.Text = MuseumName.OharaMuseumofArt.ToString();
                radioButton5.Text = MuseumName.MihoMuseum.ToString();
                radioButton6.Text = MuseumName.PolaMuseumofArt.ToString();
                radioButton7.Text = MuseumName.TokyoNationalMuseumHeiseikan.ToString();

                foreach (var prd in basket.GetAtama())
                {

                    museumCity.Kayıt(MuseumName.TokyoNationalMuseum);
                    label25.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label8.Text = " 13-9 Uenokoen, Taito City, Tokyo 110-8712";

                    museumCity.Kayıt(MuseumName.TeamLabPlanets);
                    label11.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label9.Text = "6 Chome-1-16 Toyosu, Koto City, Tokyo 135-0061";

                    museumCity.Kayıt(MuseumName.OharaMuseumofArt);
                    label30.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label26.Text = " 1 Chome-1-15 Central, Kurashiki, Okayama 710-0046";

                    museumCity.Kayıt(MuseumName.MihoMuseum);
                    label34.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label32.Text = "桃谷-300 Shigarakicho Tashiro, Shiga 529-1814";

                    museumCity.Kayıt(MuseumName.PolaMuseumofArt);
                    label19.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label17.Text = "〒250-0631 Kanagawa,Sengokuhara, 小塚山１２８５";

                    museumCity.Kayıt(MuseumName.TokyoNationalMuseumHeiseikan);
                    label40.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = "〒110-0007 Tokyo, Uenokoen, 13−9 東京国立博物館内";


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }


                pictureBox1.ImageLocation = "TokyoUlusalMüzesi.jpg";
                pictureBox2.ImageLocation = "TeamLabPlanets.jpg";
                pictureBox3.ImageLocation = "OharaMuseumofArt.jpg";
                pictureBox22.ImageLocation = "MihoMuseum.jpg";
                pictureBox25.ImageLocation = "PolaMuseumofArt.jpg";
                pictureBox30.ImageLocation = "TokyoNationalMuseumHeiseikan.jpg";
            }

            else if (BaseClass.Name == "Norveç")
            {

                basket.Currency = museum.t;


                label4.Text = museumCity.t;
                label41.Text = museumCity.t;
                label42.Text = museumCity.t;
                label43.Text = museumCity.t;
                label44.Text = museumCity.t;
                label45.Text = museumCity.t;


                radioButton3.Text = MuseumName.TheFramMuseum.ToString();
                radioButton4.Text = MuseumName.NorwegianMaritimeMuseum.ToString();
                radioButton2.Text = MuseumName.TheNorwegianMuseumofCulturalHistory.ToString();
                radioButton5.Text = MuseumName.NobelPeaceCenter.ToString();
                radioButton6.Text = MuseumName.OscarshallPalace.ToString();
                radioButton7.Text = MuseumName.KistefosMuseum.ToString();

                foreach (var prd in basket.GetAtama())
                {

                    museumCity.Kayıt(MuseumName.TheFramMuseum);
                    label25.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label8.Text = "Bygdøynesveien 39, 0286 Oslo, Norveç";

                    museumCity.Kayıt(MuseumName.NorwegianMaritimeMuseum);
                    label11.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label9.Text = " Bygdøynesveien 37, 0286 Oslo, Norveç";

                    museumCity.Kayıt(MuseumName.TheNorwegianMuseumofCulturalHistory);
                    label30.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label26.Text = " Museumsveien 10, 0287 Oslo, Norveç";

                    museumCity.Kayıt(MuseumName.NobelPeaceCenter);
                    label34.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label32.Text = "Brynjulf Bulls plass 1, 0250 Oslo, Norveç";

                    museumCity.Kayıt(MuseumName.OscarshallPalace);
                    label19.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label17.Text = "Oscarshallveien, 0287 Oslo, Norveç";

                    museumCity.Kayıt(MuseumName.KistefosMuseum);
                    label40.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = " Samsmoveien 41, 3520 Jevnaker, Norveç";


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }


                pictureBox1.ImageLocation = "TheFramMuseum.jpg";
                pictureBox2.ImageLocation = "NorwegianMaritimeMuseum.jpg";
                pictureBox3.ImageLocation = "TheNorwegianMuseumofCulturalHistory.jpg";
                pictureBox22.ImageLocation = "NobelPeaceCenter.jpg";
                pictureBox25.ImageLocation = "OscarshallPalace.jpg";
                pictureBox30.ImageLocation = "KistefosMuseum.png";
            }

            else
            {
                this.Close();
                MessageBox.Show("Aradiginiz Sehir Bulunamadi..");
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

       
        private void button1_Click(object sender, EventArgs e)
        {


            int c;
            int[] fyt;
            fyt = museumCity.fyt;


            for (int b = 0; b < 17; b++)
            {
                c = fyt[b];
                if (comboBox2.Text == c.ToString())
                {
                    if (label25.Text == c.ToString())
                    {
                        panel1.BackColor = Color.DarkGray;
                        label25.ForeColor = Color.White;
                        label25.BackColor = Color.Green;
                    }
                    if (label11.Text == c.ToString())
                    {
                        panel2.BackColor = Color.DarkGray;
                        label11.ForeColor = Color.White;
                        label11.BackColor = Color.Green;
                    }
                    if (label30.Text == c.ToString())
                    {
                        panel3.BackColor = Color.DarkGray;
                        label30.ForeColor = Color.White;
                        label30.BackColor = Color.Green;
                    }
                    if (label34.Text == c.ToString())
                    {
                        panel4.BackColor = Color.DarkGray;
                        label34.ForeColor = Color.White;
                        label34.BackColor = Color.Green;
                    }
                    if (label19.Text == c.ToString())
                    {
                        panel5.BackColor = Color.DarkGray;
                        label19.ForeColor = Color.White;
                        label19.BackColor = Color.Green;
                    }
                    if (label40.Text == c.ToString())
                    {
                        panel7.BackColor = Color.DarkGray;
                        label40.ForeColor = Color.White;
                        label40.BackColor = Color.Green;
                    }
                }

            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            comboBox2.Text = " ";

            panel1.BackColor = Color.Silver;
            panel2.BackColor = Color.Silver;
            panel3.BackColor = Color.Silver;
            panel4.BackColor = Color.Silver;
            panel5.BackColor = Color.Silver;
            panel7.BackColor = Color.Silver;

            label25.ForeColor = Color.Black;
            label25.BackColor = Color.Silver;

            label11.ForeColor = Color.Black;
            label11.BackColor = Color.Silver;

            label30.ForeColor = Color.Black;
            label30.BackColor = Color.Silver;

            label34.ForeColor = Color.Black;
            label34.BackColor = Color.Silver;

            label19.ForeColor = Color.Black;
            label19.BackColor = Color.Silver;

            label40.ForeColor = Color.Black;
            label40.BackColor = Color.Silver;

        }


        Payment odeme = new Payment();



        private void button3_Click(object sender, EventArgs e)
        {


            Basket.MuseumPersonTotal = textBox1.Text;
            AdminLogin2.MuseumPerson = textBox1.Text;


            if (radioButton3.Checked)
            {
                museumCity.Price = Convert.ToInt32(label25.Text);
                museumCity.Send(radioButton3.Text, museumCity.Price, Convert.ToInt32(textBox1.Text));
                Basket.MuseumDailyPrice = museumCity.Price.ToString();

            }
            else if (radioButton4.Checked)
            {
                museumCity.Price = Convert.ToInt32(label11.Text);
                museumCity.Send(radioButton4.Text, museumCity.Price, Convert.ToInt32(textBox1.Text));
                Basket.MuseumDailyPrice = museumCity.Price.ToString();

            }
            else if (radioButton2.Checked)
            {
                museumCity.Price = Convert.ToInt32(label30.Text);
                museumCity.Send(radioButton2.Text, museumCity.Price, Convert.ToInt32(textBox1.Text));
                Basket.MuseumDailyPrice = museumCity.Price.ToString();

            }
            else if (radioButton5.Checked)
            {
                museumCity.Price = Convert.ToInt32(label34.Text);
                museumCity.Send(radioButton5.Text, museumCity.Price, Convert.ToInt32(textBox1.Text));
                Basket.MuseumDailyPrice = museumCity.Price.ToString();

            }
            else if (radioButton6.Checked)
            {
                museumCity.Price = Convert.ToInt32(label19.Text);
                museumCity.Send(radioButton6.Text, museumCity.Price, Convert.ToInt32(textBox1.Text));
                Basket.MuseumDailyPrice = museumCity.Price.ToString();

            }
            else if (radioButton7.Checked)
            {
                museumCity.Price = Convert.ToInt32(label40.Text);
                museumCity.Send(radioButton2.Text, museumCity.Price, Convert.ToInt32(textBox1.Text));
                Basket.MuseumDailyPrice = museumCity.Price.ToString();
            }
            Basket.MuseumName = museumCity.MuseumName;
            museumCity.Calculation();
            Basket.MuseumTotal = museumCity.Total.ToString();

            AdminLogin2.MuseumTotal = museumCity.Total.ToString();
            museumCity.Price = museumCity.Total;

            Basket.total = basket.TotalPrice();
            MessageBox.Show("Seçiminiz Sepete Eklenmiştir");
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }


     
        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            odeme.Show();
        }

        Hotel otel = new Hotel();
        Tour tur = new Tour();
        Catalog katalog = new Catalog();


        private void katalogSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            katalog.Show();
        }

        private void restoranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restaurant reestoran = new Restaurant();
            this.Hide();
            reestoran.Show();
        }

        private void konaklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            otel.Show();
        }

        private void turToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            tur.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void müzeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kayıtOlunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp yeni = new SignUp();
            yeni.Show();
            this.Hide();
        }

        private void ödemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment ödeme = new Payment();
            this.Hide();
            ödeme.Show();
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

        private void girişYapınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignIn giris = new SignIn();
            this.Hide();
            giris.Show();
        }
    }
}

