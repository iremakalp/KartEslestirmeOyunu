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
    public partial class UCSonuc : UserControl
    {
        public UCSonuc()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl uc)
        {
            ucHomePanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            ucHomePanel.Controls.Add(uc);
        }
        private void UCSonuc_Load(object sender, EventArgs e)
        {
            adLbl.Text = "Ad:" + UCHome.isim;
            if (UCHome.seviye == "Kolay")
            {
                puanLbl.Text = "Puan:" + UCPlayKolay.toplamPuan.ToString();
                denemLbl.Text = "Deneme Sayısı:" + UCPlayKolay.denemeSayisi.ToString();
            }
            else if (UCHome.seviye == "Orta")
            {
                puanLbl.Text = "Puan:" + UCPlayOrta.toplamPuan.ToString();
                denemLbl.Text = "Deneme Sayısı:" + UCPlayOrta.denemeSayisi.ToString();
            }
            else
            {
                puanLbl.Text = "Puan:" + UCPlayZor.toplamPuan.ToString();
                denemLbl.Text = "Deneme Sayısı:" + UCPlayZor.denemeSayisi.ToString();
            }
        }

        private void yenidenBtn_Click(object sender, EventArgs e)
        {
            UCHome uCHome = new UCHome();
            addUserControl(uCHome);
        }
    }
}
