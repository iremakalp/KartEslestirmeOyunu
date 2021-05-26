using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartEslestirmeOyunu
{
    public partial class UCScore : UserControl
    {
        MySqlConnection bag;
        MySqlCommand komut;
        MySqlDataReader dr;
        string seviye;
        public UCScore()
        {
            InitializeComponent();
        }
        public void baglanti()
        {
            bag = new MySqlConnection("Server=127.0.0.1;Database=kartesleme;user=root;Pwd=1562;SslMode=Required");
            bag.Open();
        }
        public void oyuncuListele()
        {
            baglanti();
            string komut = "SELECT İsim,Seviye,Puan,DenemeSayisi,KalanSure FROM tbl_oyuncular ORDER BY Puan DESC ";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            oyuncularData.DataSource = dt;
        }
        private void UCScore_Load(object sender, EventArgs e)
        {         
            oyuncuListele();
            oyuncularData.AllowUserToAddRows = false; //dosyaya kaydederken sorun cikarmamasi icin bos satiri gizledik
        }
        private void seviyeCmb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (seviyeCmb.SelectedItem.ToString() == "Tümü")
            {
                oyuncuListele();
            }
            else
            {
                baglanti();
                string komut = "SELECT İsim,Seviye,Puan,DenemeSayisi,KalanSure FROM tbl_oyuncular where Seviye='" + seviyeCmb.SelectedItem.ToString() + "' order by Puan desc";
                MySqlDataAdapter da = new MySqlDataAdapter(komut, bag);
                DataTable dt = new DataTable();
                da.Fill(dt);
                oyuncularData.DataSource = dt;
            }
        }
    }
}
