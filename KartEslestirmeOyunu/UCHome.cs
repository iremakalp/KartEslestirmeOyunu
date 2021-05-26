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
    public partial class UCHome : UserControl
    {
        public static string isim;
        public static string seviye;
        public UCHome()
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
        private void adTxt_TextChanged(object sender, EventArgs e)
        {
            if (adTxt.Text == " ")
            {
                playBtn.Enabled = false;
            }
            else
            {
                playBtn.Enabled = true;
                isim = adTxt.Text;
            }
        }
        private void UCHome_Load(object sender, EventArgs e)
        {
            playBtn.Enabled = false;
            Home.menuPanel.Enabled = true;
        }
        private void playBtn_Click(object sender, EventArgs e)
        {
            if(seviyeCmb.Text=="Kolay")
            {
                UCPlayKolay ucPlay_ = new UCPlayKolay();
                addUserControl(ucPlay_);
                seviye = "Kolay";
            }
            else if(seviyeCmb.Text=="Orta")
            {
                UCPlayOrta ucPlay_ = new UCPlayOrta();
                addUserControl(ucPlay_);
                seviye = "Orta";
            }
            else 
            {
                UCPlayZor ucPlay_ = new UCPlayZor();
                addUserControl(ucPlay_);
                seviye = "Zor";

            }

        }
    }
}
