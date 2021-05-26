using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartEslestirmeOyunu
{
    public partial class UCPlayZor : UserControl
    {
        MySqlConnection bag;
        MySqlCommand komut;
        MySqlDataReader dr;

        PictureBox ilkKutu;
        int ilkIndex;
        int bulunan;
        public static int denemeSayisi;
        public static int toplamPuan;
        public static byte kalanSure = 180;
        Resimler resimler = new Resimler();
        int[] indeksler = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9 };
        public UCPlayZor()
        {
            InitializeComponent();
        }
        public void resimKaristir()
        {
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                int sayi = rand.Next(20);
                int gecici = indeksler[i];
                indeksler[i] = indeksler[sayi];
                indeksler[sayi] = gecici;
            }
        }
        public void isaret(int bulunan)
        {
            if (bulunan == 1)
                bulunan1.Image = Properties.Resources.check;
            if (bulunan == 2)
                bulunan2.Image = Properties.Resources.check;
            if (bulunan == 3)
                bulunan3.Image = Properties.Resources.check;
            if (bulunan == 4)
                bulunan4.Image = Properties.Resources.check;
            if (bulunan == 5)
                bulunan5.Image = Properties.Resources.check;
            if (bulunan == 6)
                bulunan6.Image = Properties.Resources.check;
            if (bulunan == 7)
                bulunan7.Image = Properties.Resources.check;
            if (bulunan == 8)
                bulunan8.Image = Properties.Resources.check;
            if (bulunan == 9)
                bulunan9.Image = Properties.Resources.check;
            if (bulunan == 10)
                bulunan10.Image = Properties.Resources.check;
        }
        private void addUserControl(UserControl uc)
        {
            ucHomePanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            ucHomePanel.Controls.Add(uc);
        }
        public void baglanti()
        {
            bag = new MySqlConnection("Server=127.0.0.1;Database=kartesleme;user=root;Pwd=1562;SslMode=Required");
            bag.Open();
        }
        public void kisiEkle() //oyunculari veritabanina ekler
        {
            try
            {
                baglanti();
                string eklemekomut = "insert into tbl_oyuncular(İsim,Seviye,Puan,DenemeSayisi,KalanSure) values ('" + UCHome.isim + "','" + UCHome.seviye + "','" + toplamPuan.ToString() + "','" + denemeSayisi + "','" + kalanSure + "')";
                komut = new MySqlCommand(eklemekomut, bag);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                }
                bag.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tikla(object sender, EventArgs e)
        {

            falseGif.Visible = false;
            uyariLbl.Text = "";
            trueGif.Visible = false;
            PictureBox box = (PictureBox)sender; //hangi kutuya tiklandigi
            bunifuTransition1.HideSync(box);
            int boxNo = Convert.ToInt32(box.Name.Substring(10)); //kutunun numarasi 
            int indexNo = indeksler[boxNo - 1];
            box.Image = resimler.cicekler[indexNo];
            box.Refresh();
            bunifuTransition1.ShowSync(box);

            if (ilkKutu == null)
            {
                ilkKutu = box;
                ilkIndex = indexNo;
                denemeSayisi++;
            }
            else
            {
                System.Threading.Thread.Sleep(1200);
                ilkKutu.Image = null;
                box.Image = null;

                if (ilkIndex == indexNo)
                {
                    trueGif.Visible = true;
                    uyariLbl.Text = "Bir çift buldun";
                    //referans: https://docs.microsoft.com/tr-tr/dotnet/desktop/winforms/controls/how-to-play-a-sound-from-a-windows-form?view=netframeworkdesktop-4.8
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Desktop-Irem\Source\Repos\KartEslestirmeOyunu\KartEslestirmeOyunu\bin\Debug\dogru_cevap.wav");
                    simpleSound.Play();
                    bulunan++;
                    isaret(bulunan);
                    bunifuTransition2.HideSync(box);
                    bunifuTransition2.HideSync(ilkKutu);
                    toplamPuan += 50;
                    puanLbl.Text = toplamPuan.ToString();
                    ilkKutu.Visible = false;
                    box.Visible = false;
                    if (bulunan == 10)
                    {
                        falseGif.Visible = false;
                        trueGif.Visible = false;
                        uyariLbl.Text = "";
                        toplamPuan -= 5;
                        puanLbl.Text = "0";
                        timer1.Enabled = false;
                        kisiEkle();
                        UCSonuc uCSonuc = new UCSonuc();
                        addUserControl(uCSonuc);
                    }
                }
                else
                {
                    falseGif.Visible = true;
                    uyariLbl.Text = "Bir çift değil";
                    toplamPuan -= 5;
                    puanLbl.Text = toplamPuan.ToString();
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Desktop-Irem\Source\Repos\KartEslestirmeOyunu\KartEslestirmeOyunu\bin\Debug\yanlis_cevap.wav");
                    simpleSound.Play();
                }             
                ilkKutu = null;
            }
        }
        private void UCPlayOrta_Load(object sender, EventArgs e)
        {
            Home.menuPanel.Enabled = false;
            resimKaristir();
            falseGif.Visible = false;
            trueGif.Visible = false;
            toplamPuan = 0;
            timerLbl.Text = "180";
            timer1.Enabled = true;
            timer1.Interval = 1000;
            kalanSure = 180;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kalanSure == 0)
            {
                timer1.Enabled = false;
                kisiEkle();
                UCAfis uCAfis = new UCAfis();
                addUserControl(uCAfis);
            }
            else
            {
                kalanSure -= 1;
                timerLbl.Text = kalanSure.ToString();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Giriş Sayfasına Dönülsün mü?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                kisiEkle();
                UCHome uCHome = new UCHome(); //oyun bittiginde baslangic sayfasina geri doner
                addUserControl(uCHome);
                Home.menuPanel.Enabled = true;
            }
            else
            {

            }
        }
    }
}
