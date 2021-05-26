
namespace KartEslestirmeOyunu
{
    partial class UCSonuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSonuc));
            this.ucHomePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.yenidenBtn = new Guna.UI2.WinForms.Guna2Button();
            this.denemLbl = new System.Windows.Forms.Label();
            this.puanLbl = new System.Windows.Forms.Label();
            this.adLbl = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.sonuc = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ucHomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // ucHomePanel
            // 
            this.ucHomePanel.Controls.Add(this.sonuc);
            this.ucHomePanel.Controls.Add(this.yenidenBtn);
            this.ucHomePanel.Controls.Add(this.denemLbl);
            this.ucHomePanel.Controls.Add(this.puanLbl);
            this.ucHomePanel.Controls.Add(this.adLbl);
            this.ucHomePanel.Controls.Add(this.guna2PictureBox1);
            this.ucHomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHomePanel.Location = new System.Drawing.Point(0, 0);
            this.ucHomePanel.Name = "ucHomePanel";
            this.ucHomePanel.ShadowDecoration.Parent = this.ucHomePanel;
            this.ucHomePanel.Size = new System.Drawing.Size(705, 540);
            this.ucHomePanel.TabIndex = 0;
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
            this.yenidenBtn.Location = new System.Drawing.Point(260, 409);
            this.yenidenBtn.Name = "yenidenBtn";
            this.yenidenBtn.ShadowDecoration.Parent = this.yenidenBtn;
            this.yenidenBtn.Size = new System.Drawing.Size(126, 38);
            this.yenidenBtn.TabIndex = 22;
            this.yenidenBtn.Text = "Anasayfa\'ya Dön";
            this.yenidenBtn.Click += new System.EventHandler(this.yenidenBtn_Click);
            // 
            // denemLbl
            // 
            this.denemLbl.AutoSize = true;
            this.denemLbl.BackColor = System.Drawing.Color.Transparent;
            this.denemLbl.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denemLbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.denemLbl.Location = new System.Drawing.Point(225, 315);
            this.denemLbl.Name = "denemLbl";
            this.denemLbl.Size = new System.Drawing.Size(139, 25);
            this.denemLbl.TabIndex = 21;
            this.denemLbl.Text = "Deneme Sayısı";
            // 
            // puanLbl
            // 
            this.puanLbl.AutoSize = true;
            this.puanLbl.BackColor = System.Drawing.Color.Transparent;
            this.puanLbl.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puanLbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.puanLbl.Location = new System.Drawing.Point(226, 355);
            this.puanLbl.Name = "puanLbl";
            this.puanLbl.Size = new System.Drawing.Size(58, 25);
            this.puanLbl.TabIndex = 19;
            this.puanLbl.Text = "Puan";
            // 
            // adLbl
            // 
            this.adLbl.AutoSize = true;
            this.adLbl.BackColor = System.Drawing.Color.Transparent;
            this.adLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adLbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.adLbl.Location = new System.Drawing.Point(226, 277);
            this.adLbl.Name = "adLbl";
            this.adLbl.Size = new System.Drawing.Size(35, 23);
            this.adLbl.TabIndex = 18;
            this.adLbl.Text = "Ad";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(155, 125);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(345, 397);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 17;
            this.guna2PictureBox1.TabStop = false;
            // 
            // sonuc
            // 
            this.sonuc.BackColor = System.Drawing.Color.Transparent;
            this.sonuc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sonuc.BackgroundImage")));
            this.sonuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sonuc.Location = new System.Drawing.Point(88, -146);
            this.sonuc.Name = "sonuc";
            this.sonuc.ShadowDecoration.Parent = this.sonuc;
            this.sonuc.Size = new System.Drawing.Size(492, 295);
            this.sonuc.TabIndex = 17;
            this.sonuc.TabStop = false;
            // 
            // UCSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ucHomePanel);
            this.Name = "UCSonuc";
            this.Size = new System.Drawing.Size(705, 540);
            this.Load += new System.EventHandler(this.UCSonuc_Load);
            this.ucHomePanel.ResumeLayout(false);
            this.ucHomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ucHomePanel;
        private Guna.UI2.WinForms.Guna2PictureBox sonuc;
        private System.Windows.Forms.Label denemLbl;
        private System.Windows.Forms.Label puanLbl;
        private System.Windows.Forms.Label adLbl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button yenidenBtn;
    }
}
