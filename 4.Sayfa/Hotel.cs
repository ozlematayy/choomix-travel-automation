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
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
        }



        HotelCity hotelCity = new HotelCity();
        Basket basket = new Basket();
        Payment payment = new Payment();

        BaseClass hotel = new HotelCity();



        private void Otel_Load(object sender, EventArgs e)
        {

            BaseClass.Category = "Otel";

            this.AutoScroll = true;
            this.MaximizeBox = false;
            label1.Text = hotelCity.City;


            groupBox1.Text = "Seçim:";
            label2.Text = "Bütçe:";
            label3.Text = "Kişi Sayısı:";
            label4.Text = "Giriş Tarihi:";
            label5.Text = "Çıkış Tarihi:";
            button1.Text = "Sırala";
            button2.Text = "Temizle";
            button3.Text = "Sepete Ekle";
            button4.Text = "Ödeme";
            label54.Text = "* Seçmek zorunludur.";
            label55.Text = "* Seçmek zorunludur.";


            label56.Text = LoginAssign.User;
            if ((label56.Text != LoginAssign.User) || (LoginAssign.User == "0"))
            {
                label56.Text = "Giriş Yapınız.";
                label56.ForeColor = Color.Maroon;
            }
            else
            {
                label56.Text = "HOŞGELDİN " + LoginAssign.User;
                label56.ForeColor = Color.SeaGreen;
            }


            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");


            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox33.ImageLocation = "logo1.png";
            pictureBox34.ImageLocation = "bell.png";


            basket.Add(hotelCity);


            if (hotelCity.City == "İstanbul")
            {

                basket.Currency = hotel.x;

                label8.Text = hotelCity.x;
                label12.Text = hotelCity.x;
                label18.Text = hotelCity.x;
                label24.Text = hotelCity.x;
                label30.Text = hotelCity.x;
                label37.Text = hotelCity.x;
                label42.Text = hotelCity.x;
                label48.Text = hotelCity.x;

                pictureBox1.ImageLocation = "lavanta hotel.jpg";
                pictureBox2.ImageLocation = "royal inci airport hotel.jpg";
                pictureBox3.ImageLocation = "beyaz kosk hotel.jpg";
                pictureBox8.ImageLocation = "tempo hotel.png";
                pictureBox4.ImageLocation = "divan istanbul otel.jpg";
                pictureBox5.ImageLocation = "doubletree.jpg";
                pictureBox6.ImageLocation = "swissotel.jpg";
                pictureBox7.ImageLocation = "peraotel.jpg";

                radioButton1.Text = HotelName.LavantaOtel.ToString();
                radioButton2.Text = HotelName.RoyalInciAirportHotel.ToString();
                radioButton3.Text = HotelName.BeyazKöşkOtel.ToString();
                radioButton4.Text = HotelName.TempoOtel.ToString();
                radioButton5.Text = HotelName.DivanIstanbulOtel.ToString();
                radioButton6.Text = HotelName.DoubletreeByHiltonIstanbulOtel.ToString();
                radioButton7.Text = HotelName.SwissotelTheBosphorus.ToString();
                radioButton8.Text = HotelName.PeraPalaceHotel.ToString();


                foreach (var prd in basket.GetAtama())
                {

                    hotelCity.HotelName(HotelName.LavantaOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label7.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.RoyalInciAirportHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label13.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.BeyazKöşkOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label19.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.TempoOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label25.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.DivanIstanbulOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label31.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.DoubletreeByHiltonIstanbulOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.SwissotelTheBosphorus);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label43.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.PeraPalaceHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label49.Text = prd.Price.ToString();


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }


            if (hotelCity.City == "Trabzon")
            {

                basket.Currency = hotel.x;

                label8.Text = hotelCity.x;
                label12.Text = hotelCity.x;
                label18.Text = hotelCity.x;
                label24.Text = hotelCity.x;
                label30.Text = hotelCity.x;
                label37.Text = hotelCity.x;
                label42.Text = hotelCity.x;
                label48.Text = hotelCity.x;

                pictureBox1.ImageLocation = "arsen otel.jpg";
                pictureBox2.ImageLocation = "holiday otel.jpg";
                pictureBox3.ImageLocation = "grand vaves otel.jpg";
                pictureBox8.ImageLocation = "aselia hotel.jpg";
                pictureBox4.ImageLocation = "Zitas otel zigana.jpg";
                pictureBox5.ImageLocation = "park dedeman otel.jpg";
                pictureBox6.ImageLocation = "radisson blu otel.jpg";
                pictureBox7.ImageLocation = "royal comfort hotel.jpg";

                radioButton1.Text = HotelName.ArsenOtel.ToString();
                radioButton2.Text = HotelName.UzungölHolidayOtel.ToString();
                radioButton3.Text = HotelName.GrandVavesOtel.ToString();
                radioButton4.Text = HotelName.AseliaHotel.ToString();
                radioButton5.Text = HotelName.ZitasOtelZiganaYaylaTatilKöyü.ToString();
                radioButton6.Text = HotelName.ParkDedemanOtel.ToString();
                radioButton7.Text = HotelName.RadissonBluHotel.ToString();
                radioButton8.Text = HotelName.RoyalComfortHotel.ToString();


                foreach (var prd in basket.GetAtama())
                {

                    hotelCity.HotelName(HotelName.ArsenOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label7.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.UzungölHolidayOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label13.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.GrandVavesOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label19.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.AseliaHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label25.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.ZitasOtelZiganaYaylaTatilKöyü);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label31.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.ParkDedemanOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.RadissonBluHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label43.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.RoyalComfortHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label49.Text = prd.Price.ToString();


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

            if (BaseClass.Name == "Antalya")
            {

                basket.Currency = hotel.x;

                label8.Text = hotelCity.x;
                label12.Text = hotelCity.x;
                label18.Text = hotelCity.x;
                label24.Text = hotelCity.x;
                label30.Text = hotelCity.x;
                label37.Text = hotelCity.x;
                label42.Text = hotelCity.x;
                label48.Text = hotelCity.x;


                pictureBox1.ImageLocation = "niss lara hotel.jpg";
                pictureBox2.ImageLocation = "sherwood prize otel.jpg";
                pictureBox3.ImageLocation = "akra v hotel.jpg";
                pictureBox8.ImageLocation = "the corner park hotel.jpg";
                pictureBox4.ImageLocation = "melda palace.jpg";
                pictureBox5.ImageLocation = "rixos downtown.jpg";
                pictureBox6.ImageLocation = "limak lara hotel.jpg";
                pictureBox7.ImageLocation = "the marmara.jpg";


                radioButton1.Text = HotelName.NissLaraHotel.ToString();
                radioButton2.Text = HotelName.SherwoodPrizeHotel.ToString();
                radioButton3.Text = HotelName.AkraVHotel.ToString();
                radioButton4.Text = HotelName.TheCornerParkHotel.ToString();
                radioButton5.Text = HotelName.MeldaPalaceHotel.ToString();
                radioButton6.Text = HotelName.RixosDowntownAntalya.ToString();
                radioButton7.Text = HotelName.LimakLaraDeluxeHotel.ToString();
                radioButton8.Text = HotelName.TheMarmaraAntalya.ToString();


                foreach (var prd in basket.GetAtama())
                {

                    hotelCity.HotelName(HotelName.NissLaraHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label7.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.SherwoodPrizeHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label13.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.AkraVHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label19.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.TheCornerParkHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label25.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.MeldaPalaceHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label31.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.RixosDowntownAntalya);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.LimakLaraDeluxeHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label43.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.TheMarmaraAntalya);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label49.Text = prd.Price.ToString();


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

            if (BaseClass.Name == "Ankara")
            {

                basket.Currency = hotel.x;

                label8.Text = hotelCity.x;
                label12.Text = hotelCity.x;
                label18.Text = hotelCity.x;
                label24.Text = hotelCity.x;
                label30.Text = hotelCity.x;
                label37.Text = hotelCity.x;
                label42.Text = hotelCity.x;
                label48.Text = hotelCity.x;


                pictureBox1.ImageLocation = "hoteliçkale.jpeg";
                pictureBox2.ImageLocation = "thegreenpark.jpg";
                pictureBox3.ImageLocation = "bestwesternhotel.jpg";
                pictureBox8.ImageLocation = "ataköşkhotel.jpg";
                pictureBox4.ImageLocation = "warwickhotel.jpg";
                pictureBox5.ImageLocation = "ankarahilton.jpg";
                pictureBox6.ImageLocation = "Cp Ankara Hotel.jpg";
                pictureBox7.ImageLocation = "new park hotel.jpg";

                radioButton1.Text = HotelName.HotelİçKale.ToString();
                radioButton2.Text = HotelName.TheGreenParkOtel.ToString();
                radioButton3.Text = HotelName.BestWesternHotel.ToString();
                radioButton4.Text = HotelName.AtaköşkHotel.ToString();
                radioButton5.Text = HotelName.WarwickOtel.ToString();
                radioButton6.Text = HotelName.AnkaraHiltonOtel.ToString();
                radioButton7.Text = HotelName.CPAnkaraHotel.ToString();
                radioButton8.Text = HotelName.NewParkHotel.ToString();


                foreach (var prd in basket.GetAtama())
                {

                    hotelCity.HotelName(HotelName.HotelİçKale);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label7.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.TheGreenParkOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label13.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.BestWesternHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label19.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.AtaköşkHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label25.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.WarwickOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label31.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.AnkaraHiltonOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.CPAnkaraHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label43.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.NewParkHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label49.Text = prd.Price.ToString();


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

            if (BaseClass.Name == "Nevşehir")
            {

                basket.Currency = hotel.x;

                label8.Text = hotelCity.x;
                label12.Text = hotelCity.x;
                label18.Text = hotelCity.x;
                label24.Text = hotelCity.x;
                label30.Text = hotelCity.x;
                label37.Text = hotelCity.x;
                label42.Text = hotelCity.x;
                label48.Text = hotelCity.x;


                pictureBox1.ImageLocation = "Göreme Reva Hotel.jpg";
                pictureBox2.ImageLocation = "has cave konak.jpg";
                pictureBox3.ImageLocation = "elif stone house.jpg";
                pictureBox8.ImageLocation = "sofa hotel.jpg";
                pictureBox4.ImageLocation = "dedeli deluxe hotel.jpg";
                pictureBox5.ImageLocation = "the village cave hotel.jpg";
                pictureBox6.ImageLocation = "taşkonaklar otel.jpg";
                pictureBox7.ImageLocation = "dere suites.jpg";


                radioButton1.Text = HotelName.GöremeRevaHotel.ToString();
                radioButton2.Text = HotelName.HasCaveKonakÜrgüp.ToString();
                radioButton3.Text = HotelName.ElifStoneHouse.ToString();
                radioButton4.Text = HotelName.SofaHotel.ToString();
                radioButton5.Text = HotelName.DedeliDeluxeHotel.ToString();
                radioButton6.Text = HotelName.TheVillageCaveHotel.ToString();
                radioButton7.Text = HotelName.TaşkonaklarOtel.ToString();
                radioButton8.Text = HotelName.DereSuites.ToString();


                foreach (var prd in basket.GetAtama())
                {

                    hotelCity.HotelName(HotelName.GöremeRevaHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label7.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.HasCaveKonakÜrgüp);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label13.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.ElifStoneHouse);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label19.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.SofaHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label25.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.DedeliDeluxeHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label31.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.TheVillageCaveHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.TaşkonaklarOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label43.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.DereSuites);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label49.Text = prd.Price.ToString();

                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }
            if (BaseClass.Name == "Mardin")
            {

                basket.Currency = hotel.x;

                label8.Text = hotelCity.x;
                label12.Text = hotelCity.x;
                label18.Text = hotelCity.x;
                label24.Text = hotelCity.x;
                label30.Text = hotelCity.x;
                label37.Text = hotelCity.x;
                label42.Text = hotelCity.x;
                label48.Text = hotelCity.x;


                pictureBox1.ImageLocation = "tuğhan otel.jpg";
                pictureBox2.ImageLocation = "Dara Konağı.jpg";
                pictureBox3.ImageLocation = "mardin osmanlı konağı.jpg";
                pictureBox8.ImageLocation = "maristan tarihi konak.jpg";
                pictureBox4.ImageLocation = "maridin otel.jpg";
                pictureBox5.ImageLocation = "Hilton Garden Inn Mardin.jpg";
                pictureBox6.ImageLocation = "ramada plaza mardin.jpg";
                pictureBox7.ImageLocation = "mardius tarihi konak.jpg";


                radioButton1.Text = HotelName.TuğhanOtel.ToString();
                radioButton2.Text = HotelName.DaraKonağı.ToString();
                radioButton3.Text = HotelName.MardinOsmanlıKonağı.ToString();
                radioButton4.Text = HotelName.MaristanTarihiKonak.ToString();
                radioButton5.Text = HotelName.MaridinOtel.ToString();
                radioButton6.Text = HotelName.HiltonGardenInnMardin.ToString();
                radioButton7.Text = HotelName.RamadaPlazaByWyndhamMardin.ToString();
                radioButton8.Text = HotelName.MardiusTarihiKonakOtel.ToString();


                foreach (var prd in basket.GetAtama())
                {

                    hotelCity.HotelName(HotelName.TuğhanOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label7.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.DaraKonağı);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label13.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.MardinOsmanlıKonağı);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label19.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.MaristanTarihiKonak);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label25.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.MaridinOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label31.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.HiltonGardenInnMardin);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.RamadaPlazaByWyndhamMardin);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label43.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.MardiusTarihiKonakOtel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label49.Text = prd.Price.ToString();


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

            if (BaseClass.Name == "Almanya")
            {

                basket.Currency = hotel.y;

                label8.Text = hotelCity.y;
                label12.Text = hotelCity.y;
                label18.Text = hotelCity.y;
                label24.Text = hotelCity.y;
                label30.Text = hotelCity.y;
                label37.Text = hotelCity.y;
                label42.Text = hotelCity.y;
                label48.Text = hotelCity.y;


                pictureBox1.ImageLocation = "intercity hotel.jpg";
                pictureBox2.ImageLocation = "centro hotel.jpg";
                pictureBox3.ImageLocation = "leonardo hotel hannover.jpg";
                pictureBox8.ImageLocation = "maritim hotel ulm.jpg";
                pictureBox4.ImageLocation = "hotel loccumer hof.jpg";
                pictureBox5.ImageLocation = "hilton dresden.jpg";
                pictureBox6.ImageLocation = "excelsior hotel.jpg";
                pictureBox7.ImageLocation = "steigenberger hotel.jpg";


                radioButton1.Text = HotelName.İntercityHotel.ToString();
                radioButton2.Text = HotelName.CentroHotelStadtGütersloh.ToString();
                radioButton3.Text = HotelName.LeonardoHotelHannover.ToString();
                radioButton4.Text = HotelName.MaritimHotelUlm.ToString();
                radioButton5.Text = HotelName.HotelLoccumerHof.ToString();
                radioButton6.Text = HotelName.HiltonDresden.ToString();
                radioButton7.Text = HotelName.ExcelsiorHotel.ToString();
                radioButton8.Text = HotelName.SteigenbergerHotel.ToString();


                foreach (var prd in basket.GetAtama())
                {

                    hotelCity.HotelName(HotelName.İntercityHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label7.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.CentroHotelStadtGütersloh);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label13.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.LeonardoHotelHannover);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label19.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.MaritimHotelUlm);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label25.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.HotelLoccumerHof);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label31.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.HiltonDresden);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.ExcelsiorHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label43.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.SteigenbergerHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label49.Text = prd.Price.ToString();


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

            if (BaseClass.Name == "İtalya")
            {

                basket.Currency = hotel.y;

                label8.Text = hotelCity.y;
                label12.Text = hotelCity.y;
                label18.Text = hotelCity.y;
                label24.Text = hotelCity.y;
                label30.Text = hotelCity.y;
                label37.Text = hotelCity.y;
                label42.Text = hotelCity.y;
                label48.Text = hotelCity.y;


                pictureBox1.ImageLocation = "hotel vienna.jpg";
                pictureBox2.ImageLocation = "corte san mattia.jpg";
                pictureBox3.ImageLocation = "hotel fonte.jpg";
                pictureBox8.ImageLocation = "unahotels.jpg";
                pictureBox4.ImageLocation = "hotel jolie.jpg";
                pictureBox5.ImageLocation = "sheraton milan.jpg";
                pictureBox6.ImageLocation = "le ali del frassino.jpg";
                pictureBox7.ImageLocation = "hotel grand visconti.jpg";


                radioButton1.Text = HotelName.HotelViennaOstenda.ToString();
                radioButton2.Text = HotelName.CorteSanMattia.ToString();
                radioButton3.Text = HotelName.HotelFonteBoiola.ToString();
                radioButton4.Text = HotelName.UnahotelsCusaniMilano.ToString();
                radioButton5.Text = HotelName.HotelNewJolie.ToString();
                radioButton6.Text = HotelName.SheratonMilanMalpensoAirportHotel.ToString();
                radioButton7.Text = HotelName.OtelLeAliDelFrassino.ToString();
                radioButton8.Text = HotelName.HotelGrandViscontiPalace.ToString();


                foreach (var prd in basket.GetAtama())
                {

                    hotelCity.HotelName(HotelName.HotelViennaOstenda);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label7.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.CorteSanMattia);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label13.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.HotelFonteBoiola);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label19.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.UnahotelsCusaniMilano);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label25.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.HotelNewJolie);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label31.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.SheratonMilanMalpensoAirportHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.OtelLeAliDelFrassino);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label43.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.HotelGrandViscontiPalace);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label49.Text = prd.Price.ToString();


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

            if (BaseClass.Name == "Arjantin")
            {

                basket.Currency = hotel.y;

                label8.Text = hotelCity.y;
                label12.Text = hotelCity.y;
                label18.Text = hotelCity.y;
                label24.Text = hotelCity.y;
                label30.Text = hotelCity.y;
                label37.Text = hotelCity.y;
                label42.Text = hotelCity.y;
                label48.Text = hotelCity.y;

                pictureBox1.ImageLocation = "wyndham nordelta tigre.png";
                pictureBox2.ImageLocation = "ch madero.jpg";
                pictureBox3.ImageLocation = "nh bariloche.jpg";
                pictureBox8.ImageLocation = "howard.jpg";
                pictureBox4.ImageLocation = "algodon.jpg";
                pictureBox5.ImageLocation = "hotel alvear.jpg";
                pictureBox6.ImageLocation = "sheraton mar del plata.jpg";
                pictureBox7.ImageLocation = "hotel del casco.jpg";

                radioButton1.Text = HotelName.WyndhamNordeltaTigre.ToString();
                radioButton2.Text = HotelName.CHMaderoUrbanoSuites.ToString();
                radioButton3.Text = HotelName.HotelNHBarilocheEdelweiss.ToString();
                radioButton4.Text = HotelName.HotelHowardJohnsonTrenqueLauquen.ToString();
                radioButton5.Text = HotelName.AlgodanMansionHotel.ToString();
                radioButton6.Text = HotelName.HotelAlvearPalace.ToString();
                radioButton7.Text = HotelName.SheratonMarDelPlataHotel.ToString();
                radioButton8.Text = HotelName.HotelDelCasco.ToString();


                foreach (var prd in basket.GetAtama())
                {

                    hotelCity.HotelName(HotelName.WyndhamNordeltaTigre);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label7.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.CHMaderoUrbanoSuites);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label13.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.HotelNHBarilocheEdelweiss);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label19.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.HotelHowardJohnsonTrenqueLauquen);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label25.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.AlgodanMansionHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label31.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.HotelAlvearPalace);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.SheratonMarDelPlataHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label43.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.HotelDelCasco);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label49.Text = prd.Price.ToString();


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

            if (BaseClass.Name == "Japonya")
            {

                basket.Currency = hotel.k;

                label8.Text = hotelCity.k;
                label12.Text = hotelCity.k;
                label18.Text = hotelCity.k;
                label24.Text = hotelCity.k;
                label30.Text = hotelCity.k;
                label37.Text = hotelCity.k;
                label42.Text = hotelCity.k;
                label48.Text = hotelCity.k;


                pictureBox1.ImageLocation = "rihga.jpeg";
                pictureBox2.ImageLocation = "nest hotel.jpg";
                pictureBox3.ImageLocation = "ark hotel.jpg";
                pictureBox8.ImageLocation = "unizo osaka.jpg";
                pictureBox4.ImageLocation = "via Inn asakusa.jpg";
                pictureBox5.ImageLocation = "grandouce.jpg";
                pictureBox6.ImageLocation = "apa villa hotel.jpg";
                pictureBox7.ImageLocation = "mystays shin.jpg";

                radioButton1.Text = HotelName.RighaNakanoshimaInnOsakaHotel.ToString();
                radioButton2.Text = HotelName.NestHotelKumamoto.ToString();
                radioButton3.Text = HotelName.ArkHotelOsakaShinsaibashi.ToString();
                radioButton4.Text = HotelName.UnizoOsakaUmedaHotel.ToString();
                radioButton5.Text = HotelName.ViaInnAsakusaHotel.ToString();
                radioButton6.Text = HotelName.GrandouceHanazonocho.ToString();
                radioButton7.Text = HotelName.ApaVillaHotelYodoyabashi.ToString();
                radioButton8.Text = HotelName.MystaysShinOsakaHotel.ToString();

                foreach (var prd in basket.GetAtama())
                {

                    hotelCity.HotelName(HotelName.RighaNakanoshimaInnOsakaHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label7.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.NestHotelKumamoto);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label13.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.ArkHotelOsakaShinsaibashi);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label19.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.UnizoOsakaUmedaHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label25.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.ViaInnAsakusaHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label31.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.GrandouceHanazonocho);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label38.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.ApaVillaHotelYodoyabashi);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label43.Text = prd.Price.ToString();

                    hotelCity.HotelName(HotelName.MystaysShinOsakaHotel);
                    comboBox2.Items.Add(prd.Price.ToString());
                    label49.Text = prd.Price.ToString();


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }


            if (BaseClass.Name == "Norveç")
            {

                basket.Currency = hotel.t;

                label8.Text = hotelCity.t;
                label12.Text = hotelCity.t;
                label18.Text = hotelCity.t;
                label24.Text = hotelCity.t;
                label30.Text = hotelCity.t;
                label37.Text = hotelCity.t;
                label42.Text = hotelCity.t;
                label48.Text = hotelCity.t;


                pictureBox1.ImageLocation = "marken.jpg";
                pictureBox2.ImageLocation = "kjobmandsgaarden.jpg";
                pictureBox3.ImageLocation = "stavanger.jpg";
                pictureBox8.ImageLocation = "bergo otel.jpg";
                pictureBox4.ImageLocation = "geilo.jpg";
                pictureBox5.ImageLocation = "ami hotel.jpg";
                pictureBox6.ImageLocation = "comfort hotel.jpg";
                pictureBox7.ImageLocation = "nordic.jpg";


                radioButton1.Text = HotelName.MarkenGuesthouseHotel.ToString();
                radioButton2.Text = HotelName.KjobmandsgaardenHotel.ToString();
                radioButton3.Text = HotelName.StavangerLilleHotel.ToString();
                radioButton4.Text = HotelName.BergoHotel.ToString();
                radioButton5.Text = HotelName.GeiloVandrerhjem.ToString();
                radioButton6.Text = HotelName.AmiHotel.ToString();
                radioButton7.Text = HotelName.ComfortHotelRunway.ToString();
                radioButton8.Text = HotelName.NordicChoiceHotel.ToString();


                foreach (var prd in basket.GetAtama())
                {

                    hotelCity.HotelName(HotelName.MarkenGuesthouseHotel);
                    label7.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());

                    hotelCity.HotelName(HotelName.KjobmandsgaardenHotel);
                    label13.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());

                    hotelCity.HotelName(HotelName.StavangerLilleHotel);
                    label19.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());

                    hotelCity.HotelName(HotelName.BergoHotel);
                    label25.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());

                    hotelCity.HotelName(HotelName.GeiloVandrerhjem);
                    label31.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());

                    hotelCity.HotelName(HotelName.AmiHotel);
                    label38.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());

                    hotelCity.HotelName(HotelName.ComfortHotelRunway); ;
                    label43.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());

                    hotelCity.HotelName(HotelName.NordicChoiceHotel);
                    label49.Text = prd.Price.ToString();
                    comboBox2.Items.Add(prd.Price.ToString());


                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }


            label6.Text = hotelCity.Daily;
            label9.Text = hotelCity.Internet;
            label10.Text = hotelCity.AirConditioning;
            label11.Text = hotelCity.Reception;

            pictureBox9.ImageLocation = "wifi.jpg";
            pictureBox10.ImageLocation = "klima.png";
            pictureBox11.ImageLocation = "resepsiyon.png";

            label14.Text = hotelCity.Daily;
            label15.Text = hotelCity.Breakfast;
            label16.Text = hotelCity.CarPark;
            label17.Text = hotelCity.Internet;
            pictureBox12.ImageLocation = "yemek.jpg";
            pictureBox13.ImageLocation = "oto.png";
            pictureBox14.ImageLocation = "wifi.jpg";

            label20.Text = hotelCity.Daily;
            label21.Text = hotelCity.Breakfast;
            label22.Text = hotelCity.Case;
            label23.Text = hotelCity.AirConditioning;
            pictureBox15.ImageLocation = "yemek.jpg";
            pictureBox16.ImageLocation = "valiz.png";
            pictureBox17.ImageLocation = "klima.png";

            label26.Text = hotelCity.Daily;
            label27.Text = hotelCity.Internet;
            label28.Text = hotelCity.Food;
            label29.Text = hotelCity.Car;
            pictureBox19.ImageLocation = "wifi.jpg";
            pictureBox18.ImageLocation = "yemek.jpg";
            pictureBox20.ImageLocation = "oto.png";

            label32.Text = hotelCity.Daily;
            label33.Text = hotelCity.Internet;
            label34.Text = hotelCity.Sport;
            label35.Text = hotelCity.Pool;
            pictureBox21.ImageLocation = "wifi.jpg";
            pictureBox22.ImageLocation = "spor.png";
            pictureBox23.ImageLocation = "havuz.jpg";

            label39.Text = hotelCity.Daily;
            label36.Text = hotelCity.IndoorPool;
            label40.Text = hotelCity.Car;
            label41.Text = hotelCity.Breakfast;
            pictureBox24.ImageLocation = "havuz.jpg";
            pictureBox25.ImageLocation = "oto.png";
            pictureBox26.ImageLocation = "yemek.jpg";

            label44.Text = hotelCity.Daily;
            label45.Text = hotelCity.Food;
            label46.Text = hotelCity.Sport;
            label47.Text = hotelCity.Pool;
            pictureBox27.ImageLocation = "yemek.jpg";
            pictureBox28.ImageLocation = "spor.png";
            pictureBox29.ImageLocation = "havuz.jpg";

            label50.Text = hotelCity.Daily;
            label51.Text = hotelCity.Car;
            label52.Text = hotelCity.Internet;
            label53.Text = hotelCity.IndoorPool;
            pictureBox30.ImageLocation = "oto.png";
            pictureBox31.ImageLocation = "wifi.jpg";
            pictureBox32.ImageLocation = "havuz.jpg";




        }

        public int Butget, toplam;
        public int Person;
        public int w;
        public double Time;
        public String süre;
        public String otelismi;


        private void button1_Click(object sender, EventArgs e)
        {

            Butget = Convert.ToInt32(comboBox2.Text);


            Person = Convert.ToInt32(comboBox1.Text);


            TimeSpan fark = dateTimePicker2.Value - dateTimePicker1.Value;

            Time = fark.TotalDays;

            w = Convert.ToInt32(Time);


            Basket.HotelDay = w;
            Basket.HotelPersonTotal = Person.ToString();
            AdminLogin2.HotelPerson = Person.ToString();

            hotelCity.Assignment(Butget, Person, w);

            hotelCity.Calculation();


            if (comboBox2.Text == "50" || comboBox2.Text == "50000")
            {
                label6.Text = "Toplam";
                label14.Text = "Toplam";

                label7.Text = hotelCity.total.ToString();
                label13.Text = hotelCity.total.ToString();

                panel2.Enabled = false;
                panel4.Enabled = false;
                panel3.Enabled = false;
                panel5.Enabled = false;
                panel7.Enabled = false;
                panel9.Enabled = false;

                panel8.BackColor = Color.DarkGray;
                panel6.BackColor = Color.DarkGray;
                label7.BackColor = Color.Green;
                label7.ForeColor = Color.White;
                label13.BackColor = Color.Green;
                label13.ForeColor = Color.White;
            }


            if (comboBox2.Text == "100" || comboBox2.Text == "100000")
            {
                label20.Text = "Toplam";
                label26.Text = "Toplam";
                label32.Text = "Toplam";

                label19.Text = hotelCity.total.ToString();
                label25.Text = hotelCity.total.ToString();
                label31.Text = hotelCity.total.ToString();

                panel3.Enabled = false;
                panel5.Enabled = false;
                panel7.Enabled = false;
                panel6.Enabled = false;
                panel8.Enabled = false;

                panel4.BackColor = Color.DarkGray;
                panel2.BackColor = Color.DarkGray;
                panel9.BackColor = Color.DarkGray;
                label19.BackColor = Color.Green;
                label19.ForeColor = Color.White;
                label25.BackColor = Color.Green;
                label25.ForeColor = Color.White;
                label31.BackColor = Color.Green;
                label31.ForeColor = Color.White;

            }


            if (comboBox2.Text == "200" || comboBox2.Text == "200000")
            {
                label39.Text = "Toplam";
                label44.Text = "Toplam";
                label50.Text = "Toplam";

                label38.Text = hotelCity.total.ToString();
                label43.Text = hotelCity.Price.ToString();
                label49.Text = hotelCity.total.ToString();

                panel2.Enabled = false;
                panel4.Enabled = false;
                panel6.Enabled = false;
                panel8.Enabled = false;
                panel9.Enabled = false;

                panel7.BackColor = Color.DarkGray;
                panel5.BackColor = Color.DarkGray;
                panel3.BackColor = Color.DarkGray;
                label38.BackColor = Color.Green;
                label38.ForeColor = Color.White;
                label43.BackColor = Color.Green;
                label43.ForeColor = Color.White;
                label49.BackColor = Color.Green;
                label49.ForeColor = Color.White;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            panel2.Enabled = true;
            panel4.Enabled = true;
            panel3.Enabled = true;
            panel5.Enabled = true;
            panel7.Enabled = true;
            panel9.Enabled = true;
            panel6.Enabled = true;
            panel8.Enabled = true;
            panel8.BackColor = Color.Silver;
            panel6.BackColor = Color.Silver;
            label7.BackColor = Color.Silver;
            label7.ForeColor = Color.Black;
            label13.BackColor = Color.Silver;
            label13.ForeColor = Color.Black;

            panel4.BackColor = Color.Silver;
            panel2.BackColor = Color.Silver;
            panel9.BackColor = Color.Silver;
            label19.BackColor = Color.Silver;
            label19.ForeColor = Color.Black;
            label25.BackColor = Color.Silver;
            label25.ForeColor = Color.Black;
            label31.BackColor = Color.Silver;
            label31.ForeColor = Color.Black;

            panel7.BackColor = Color.Silver;
            panel5.BackColor = Color.Silver;
            panel3.BackColor = Color.Silver;
            label38.BackColor = Color.Silver;
            label38.ForeColor = Color.Black;
            label43.BackColor = Color.Silver;
            label43.ForeColor = Color.Black;
            label49.BackColor = Color.Silver;
            label49.ForeColor = Color.Black;

            label6.Text = hotelCity.Daily;
            label14.Text = hotelCity.Daily;
            label20.Text = hotelCity.Daily;
            label26.Text = hotelCity.Daily;
            label32.Text = hotelCity.Daily;
            label39.Text = hotelCity.Daily;
            label44.Text = hotelCity.Daily;
            label50.Text = hotelCity.Daily;
            label7.Text = "50";
            label13.Text = "50";
            label19.Text = "100";
            label25.Text = "100";
            label31.Text = "100";
            label38.Text = "200";
            label43.Text = "200";
            label49.Text = "200";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            payment.Show();
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

        private void restoranToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Restaurant reestoran = new Restaurant();
            this.Hide();
           reestoran.Show();
        }

        private void katalogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kayıtOlunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp kayıtol = new SignUp();
            this.Hide();
            kayıtol.Show();

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage ana = new HomePage();
            ana.Show();
            this.Hide();
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

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

        private void girişYapınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignIn giris = new SignIn();
            this.Hide();
            giris.Show();
        }

        private void konaklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (radioButton1.Checked)
            {

                hotelCity.Price = Convert.ToInt32(label7.Text);

                hotelCity.Send(radioButton1.Text);
            }
            if (radioButton2.Checked)
            {

                hotelCity.Price = Convert.ToInt32(label13.Text);

                hotelCity.Send(radioButton2.Text);
            }
            if (radioButton3.Checked)
            {

                hotelCity.Price = Convert.ToInt32(label19.Text);

                hotelCity.Send(radioButton3.Text);
            }
            if (radioButton4.Checked)
            {
                hotelCity.Price = Convert.ToInt32(label25.Text);

                hotelCity.Send(radioButton4.Text);
            }
            if (radioButton5.Checked)
            {
                hotelCity.Price = Convert.ToInt32(label31.Text);

                hotelCity.Send(radioButton5.Text);
            }
            if (radioButton6.Checked)
            {

                hotelCity.Price = Convert.ToInt32(label38.Text);

                hotelCity.Send(radioButton6.Text);
            }
            if (radioButton7.Checked)
            {

                hotelCity.Price = Convert.ToInt32(label43.Text);

                hotelCity.Send(radioButton7.Text);
            }
            if (radioButton8.Checked)
            {

                hotelCity.Price = Convert.ToInt32(label49.Text);

                hotelCity.Send(radioButton8.Text);
            }

            Basket.HotelName = hotelCity.Hotel;
            Basket.HotelDailyPrice = hotelCity.DailyPrice.ToString();
            hotelCity.Calculation();
            Basket.HotelTotal = hotelCity.total.ToString();

            hotelCity.Price = hotelCity.total;
            AdminLogin2.HotelTotal = hotelCity.total.ToString();

            Basket.total = basket.TotalPrice();
            MessageBox.Show("Seçiminiz Sepete Eklenmiştir");


        }
    }
}
