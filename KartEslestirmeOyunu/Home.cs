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
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
            UCHome uC_ = new UCHome();
            addUserControl(uC_);
        }
        private void addUserControl(UserControl uc)
        {
            ucHomePanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            ucHomePanel.Controls.Add(uc);
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Uygulama Kapatılsın mı?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            UCHome uC_ = new UCHome();
            addUserControl(uC_);
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(homeBtn, "Anasayfa");
            Aciklama.SetToolTip(rulesBtn, "Oyun Kuralları");
            Aciklama.SetToolTip(bestBtn, "Oyun Skorları");         
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            UCHome uC_ = new UCHome();
            addUserControl(uC_);
        }

        private void bestBtn_Click(object sender, EventArgs e)
        {
            UCScore uC_ = new UCScore();
            addUserControl(uC_);
        }
        private void rulesBtn_Click(object sender, EventArgs e)
        {
            UCRules uC_ = new UCRules();
            addUserControl(uC_);
        }
    }
}
