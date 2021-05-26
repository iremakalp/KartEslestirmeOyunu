
namespace KartEslestirmeOyunu
{
    partial class UCHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHome));
            this.adTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ucHomePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.seviyeCmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.playBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ucHomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adTxt
            // 
            this.adTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.adTxt.BorderRadius = 20;
            this.adTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adTxt.DefaultText = "";
            this.adTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adTxt.DisabledState.Parent = this.adTxt;
            this.adTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.adTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adTxt.FocusedState.Parent = this.adTxt;
            this.adTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.adTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adTxt.HoverState.Parent = this.adTxt;
            this.adTxt.Location = new System.Drawing.Point(472, 157);
            this.adTxt.Name = "adTxt";
            this.adTxt.PasswordChar = '\0';
            this.adTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.adTxt.PlaceholderText = "Kullanıcı Adı";
            this.adTxt.SelectedText = "";
            this.adTxt.ShadowDecoration.Parent = this.adTxt;
            this.adTxt.Size = new System.Drawing.Size(185, 40);
            this.adTxt.TabIndex = 11;
            this.adTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adTxt.TextChanged += new System.EventHandler(this.adTxt_TextChanged);
            // 
            // ucHomePanel
            // 
            this.ucHomePanel.BackColor = System.Drawing.Color.Transparent;
            this.ucHomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucHomePanel.BackgroundImage")));
            this.ucHomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucHomePanel.Controls.Add(this.seviyeCmb);
            this.ucHomePanel.Controls.Add(this.adTxt);
            this.ucHomePanel.Controls.Add(this.playBtn);
            this.ucHomePanel.Controls.Add(this.guna2PictureBox1);
            this.ucHomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHomePanel.Location = new System.Drawing.Point(0, 0);
            this.ucHomePanel.Name = "ucHomePanel";
            this.ucHomePanel.ShadowDecoration.Parent = this.ucHomePanel;
            this.ucHomePanel.Size = new System.Drawing.Size(705, 500);
            this.ucHomePanel.TabIndex = 14;
            // 
            // seviyeCmb
            // 
            this.seviyeCmb.BackColor = System.Drawing.Color.Transparent;
            this.seviyeCmb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.seviyeCmb.BorderRadius = 20;
            this.seviyeCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.seviyeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seviyeCmb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.seviyeCmb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.seviyeCmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.seviyeCmb.FocusedState.Parent = this.seviyeCmb;
            this.seviyeCmb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.seviyeCmb.ForeColor = System.Drawing.SystemColors.Control;
            this.seviyeCmb.HoverState.Parent = this.seviyeCmb;
            this.seviyeCmb.ItemHeight = 30;
            this.seviyeCmb.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.seviyeCmb.ItemsAppearance.Parent = this.seviyeCmb;
            this.seviyeCmb.Location = new System.Drawing.Point(496, 215);
            this.seviyeCmb.Name = "seviyeCmb";
            this.seviyeCmb.ShadowDecoration.Parent = this.seviyeCmb;
            this.seviyeCmb.Size = new System.Drawing.Size(140, 36);
            this.seviyeCmb.TabIndex = 14;
            this.seviyeCmb.Tag = "";
            this.seviyeCmb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playBtn
            // 
            this.playBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.playBtn.CheckedState.Parent = this.playBtn;
            this.playBtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.playBtn.HoverState.Parent = this.playBtn;
            this.playBtn.Image = ((System.Drawing.Image)(resources.GetObject("playBtn.Image")));
            this.playBtn.ImageRotate = 0F;
            this.playBtn.Location = new System.Drawing.Point(541, 270);
            this.playBtn.Name = "playBtn";
            this.playBtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.playBtn.PressedState.Parent = this.playBtn;
            this.playBtn.Size = new System.Drawing.Size(62, 50);
            this.playBtn.TabIndex = 13;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, -40);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(455, 473);
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ucHomePanel);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(705, 500);
            this.Load += new System.EventHandler(this.UCHome_Load);
            this.ucHomePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox adTxt;
        private Guna.UI2.WinForms.Guna2ImageButton playBtn;
        private Guna.UI2.WinForms.Guna2Panel ucHomePanel;
        private Guna.UI2.WinForms.Guna2ComboBox seviyeCmb;
    }
}
