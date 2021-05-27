using BunifuAnimatorNS;
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
    public partial class UCPlayKolay : UserControl
    {
        MySqlConnection bag;
        MySqlCommand komut;
        MySqlDataReader dr;

        PictureBox ilkKutu;
        int ilkIndex;
        int bulunan;
        public static int denemeSayisi;
        Resimler resimler = new Resimler();
        int[] indeksler = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
        public static int toplamPuan;
        public static byte kalanSure = 80;
        public UCPlayKolay()
        {
            InitializeComponent();
        }               
        public void resimleriKaristir() //indeksleri karistirir
        {              
            Random rand = new Random();
            for (int i = 0; i < 12; i++)
            {
                int sayi = rand.Next(12);
                int gecici = indeksler[i];
                indeksler[i] = indeksler[sayi];
                indeksler[sayi] = gecici;
            }
        }
        private void addUserControl(UserControl uc)
        {
            ucHomePanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            ucHomePanel.Controls.Add(uc);
        }
        public void isaret(int bulunan)
        {
            if(bulunan==1)
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
                string eklemekomut = "insert into tbl_oyuncular(İsim,Seviye,Puan,DenemeSayisi,KalanSure) values ('" + UCHome.isim + "','" +UCHome.seviye+"','"+ toplamPuan.ToString() + "','" + denemeSayisi + "','" + kalanSure + "')";
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
            trueGif.Visible = false;
            uyariLbl.Text = "";        
            PictureBox box = (PictureBox)sender; //hangi kutuya tiklandigi
            bunifuTransition1.HideSync(box);
            int boxNo = Convert.ToInt32(box.Name.Substring(10)); //kutunun numarasi 
            int indexNo = indeksler[boxNo - 1];
            box.Image = resimler.meslekler[indexNo];
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
                System.Threading.Thread.Sleep(1000);
                ilkKutu.Image = null;
                box.Image = null;
                if (ilkIndex == indexNo)
                {                 
                    trueGif.Visible = true;
                    uyariLbl.Text = "Bir çift buldun";
                    //referans: https://docs.microsoft.com/tr-tr/dotnet/desktop/winforms/controls/how-to-play-a-sound-from-a-windows-form?view=netframeworkdesktop-4.8
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Desktop-Irem\Source\Repos\KartEslestirmeOyunu\KartEslestirmeOyunu\bin\Debug\dogru.wav");
                    simpleSound.Play();
                    bulunan++;
                    isaret(bulunan);
                    bunifuTransition2.HideSync(box);
                    bunifuTransition2.HideSync(ilkKutu);
                    toplamPuan += 50;
                    puanLbl.Text = toplamPuan.ToString();
                    ilkKutu.Visible = false;
                    box.Visible = false;             
                    if (bulunan == 6)
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
        private void UCPlayKolay_Load(object sender, EventArgs e)
        {
            Home.menuPanel.Enabled = false;
            resimleriKaristir();
            falseGif.Visible = false;
            trueGif.Visible = false;
            toplamPuan = 0;
            timerLbl.Text = "80";
            timer1.Enabled = true;
            timer1.Interval = 1000;
            kalanSure = 80;
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
