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
    public partial class UCAfis : UserControl
    {
        public UCAfis()
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
        private void yenidenBtn_Click(object sender, EventArgs e)
        {
            if (UCHome.seviye == "Kolay")
            {
                UCPlayKolay ucPlay_ = new UCPlayKolay();
                addUserControl(ucPlay_);
            }
            else if (UCHome.seviye == "Orta")
            {
                UCPlayOrta ucPlay_ = new UCPlayOrta();
                addUserControl(ucPlay_);
            }
            else
            {
                UCPlayZor ucPlay_ = new UCPlayZor();
                addUserControl(ucPlay_);
            }
        }

        private void UCAfis_Load(object sender, EventArgs e)
        {
            adLbl.Text ="Ad:"+ UCHome.isim;
            if(UCHome.seviye=="Kolay")
            {
                puanLbl.Text = "Puan:" + UCPlayKolay.toplamPuan.ToString();

            }
            else if(UCHome.seviye == "Orta")
            {
                puanLbl.Text = "Puan:" + UCPlayOrta.toplamPuan.ToString();

            }
            else
            {
                puanLbl.Text = "Puan:" + UCPlayZor.toplamPuan.ToString();

            }
        }
    }
}
