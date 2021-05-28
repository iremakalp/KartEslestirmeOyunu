
namespace KartEslestirmeOyunu
{
    partial class UCAfis
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAfis));
            this.ucHomePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.puanLbl = new System.Windows.Forms.Label();
            this.adLbl = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.zaman = new Guna.UI2.WinForms.Guna2PictureBox();
            this.yenidenBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ucHomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaman)).BeginInit();
            this.SuspendLayout();
            // 
            // ucHomePanel
            // 
            this.ucHomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucHomePanel.BackgroundImage")));
            this.ucHomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucHomePanel.Controls.Add(this.yenidenBtn);
            this.ucHomePanel.Controls.Add(this.puanLbl);
            this.ucHomePanel.Controls.Add(this.adLbl);
            this.ucHomePanel.Controls.Add(this.guna2PictureBox1);
            this.ucHomePanel.Controls.Add(this.zaman);
            this.ucHomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHomePanel.Location = new System.Drawing.Point(0, 0);
            this.ucHomePanel.Name = "ucHomePanel";
            this.ucHomePanel.ShadowDecoration.Parent = this.ucHomePanel;
            this.ucHomePanel.Size = new System.Drawing.Size(705, 540);
            this.ucHomePanel.TabIndex = 13;
            // 
            // puanLbl
            // 
            this.puanLbl.AutoSize = true;
            this.puanLbl.BackColor = System.Drawing.Color.Transparent;
            this.puanLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puanLbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.puanLbl.Location = new System.Drawing.Point(251, 329);
            this.puanLbl.Name = "puanLbl";
            this.puanLbl.Size = new System.Drawing.Size(62, 27);
            this.puanLbl.TabIndex = 14;
            this.puanLbl.Text = "Puan";
            // 
            // adLbl
            // 
            this.adLbl.AutoSize = true;
            this.adLbl.BackColor = System.Drawing.Color.Transparent;
            this.adLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adLbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.adLbl.Location = new System.Drawing.Point(251, 287);
            this.adLbl.Name = "adLbl";
            this.adLbl.Size = new System.Drawing.Size(40, 27);
            this.adLbl.TabIndex = 13;
            this.adLbl.Text = "Ad";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(175, 126);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(345, 397);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            // 
            // zaman
            // 
            this.zaman.BackColor = System.Drawing.Color.Transparent;
            this.zaman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zaman.BackgroundImage")));
            this.zaman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zaman.Location = new System.Drawing.Point(115, -156);
            this.zaman.Name = "zaman";
            this.zaman.ShadowDecoration.Parent = this.zaman;
            this.zaman.Size = new System.Drawing.Size(520, 306);
            this.zaman.TabIndex = 11;
            this.zaman.TabStop = false;
            // 
            // yenidenBtn
            // 
            this.yenidenBtn.BackColor = System.Drawing.Color.Transparent;
            this.yenidenBtn.BorderRadius = 20;
            this.yenidenBtn.CheckedState.Parent = this.yenidenBtn;
            this.yenidenBtn.CustomImages.Parent = this.yenidenBtn;
            this.yenidenBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.yenidenBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.yenidenBtn.ForeColor = System.Drawing.Color.White;
            this.yenidenBtn.HoverState.Parent = this.yenidenBtn;
            this.yenidenBtn.Location = new System.Drawing.Point(285, 381);
            this.yenidenBtn.Name = "yenidenBtn";
            this.yenidenBtn.ShadowDecoration.Parent = this.yenidenBtn;
            this.yenidenBtn.Size = new System.Drawing.Size(109, 38);
            this.yenidenBtn.TabIndex = 7;
            this.yenidenBtn.Text = "Yeniden Başlat";
            this.yenidenBtn.Click += new System.EventHandler(this.yenidenBtn_Click);
            // 
            // UCAfis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucHomePanel);
            this.Name = "UCAfis";
            this.Size = new System.Drawing.Size(705, 540);
            this.Load += new System.EventHandler(this.UCAfis_Load);
            this.ucHomePanel.ResumeLayout(false);
            this.ucHomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel ucHomePanel;
        private Guna.UI2.WinForms.Guna2PictureBox zaman;
        private System.Windows.Forms.Label puanLbl;
        private System.Windows.Forms.Label adLbl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button yenidenBtn;
    }
}
