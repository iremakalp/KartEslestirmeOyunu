
namespace KartEslestirmeOyunu
{
    partial class UCPlayKolay
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPlayKolay));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.ucHomePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.backBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.puanLbl = new System.Windows.Forms.Label();
            this.timerLbl = new System.Windows.Forms.Label();
            this.uyariLbl = new System.Windows.Forms.Label();
            this.trueGif = new Guna.UI2.WinForms.Guna2PictureBox();
            this.falseGif = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bulunan1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bulunan2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bulunan3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bulunan4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bulunan5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bulunan6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ucHomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trueGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falseGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulunan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulunan2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulunan3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulunan4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulunan5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulunan6)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition2.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.bunifuTransition2.DefaultAnimation = animation4;
            // 
            // ucHomePanel
            // 
            this.ucHomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucHomePanel.BackgroundImage")));
            this.ucHomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucHomePanel.Controls.Add(this.bulunan1);
            this.ucHomePanel.Controls.Add(this.bulunan2);
            this.ucHomePanel.Controls.Add(this.bulunan3);
            this.ucHomePanel.Controls.Add(this.bulunan4);
            this.ucHomePanel.Controls.Add(this.bulunan5);
            this.ucHomePanel.Controls.Add(this.bulunan6);
            this.ucHomePanel.Controls.Add(this.backBtn);
            this.ucHomePanel.Controls.Add(this.guna2Panel1);
            this.ucHomePanel.Controls.Add(this.uyariLbl);
            this.ucHomePanel.Controls.Add(this.trueGif);
            this.ucHomePanel.Controls.Add(this.falseGif);
            this.ucHomePanel.Controls.Add(this.pictureBox10);
            this.ucHomePanel.Controls.Add(this.pictureBox11);
            this.ucHomePanel.Controls.Add(this.pictureBox12);
            this.ucHomePanel.Controls.Add(this.pictureBox7);
            this.ucHomePanel.Controls.Add(this.pictureBox8);
            this.ucHomePanel.Controls.Add(this.pictureBox9);
            this.ucHomePanel.Controls.Add(this.pictureBox6);
            this.ucHomePanel.Controls.Add(this.pictureBox5);
            this.ucHomePanel.Controls.Add(this.pictureBox4);
            this.ucHomePanel.Controls.Add(this.pictureBox3);
            this.ucHomePanel.Controls.Add(this.pictureBox2);
            this.ucHomePanel.Controls.Add(this.pictureBox1);
            this.bunifuTransition2.SetDecoration(this.ucHomePanel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.ucHomePanel, BunifuAnimatorNS.DecorationType.None);
            this.ucHomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHomePanel.Location = new System.Drawing.Point(0, 0);
            this.ucHomePanel.Name = "ucHomePanel";
            this.ucHomePanel.ShadowDecoration.Parent = this.ucHomePanel;
            this.ucHomePanel.Size = new System.Drawing.Size(705, 540);
            this.ucHomePanel.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.backBtn, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.backBtn, BunifuAnimatorNS.DecorationType.None);
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(17, 20);
            this.backBtn.Name = "backBtn";
            this.backBtn.ShadowDecoration.Parent = this.backBtn;
            this.backBtn.Size = new System.Drawing.Size(48, 57);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 87;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.puanLbl);
            this.guna2Panel1.Controls.Add(this.timerLbl);
            this.bunifuTransition2.SetDecoration(this.guna2Panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.guna2Panel1, BunifuAnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(489, 58);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(197, 92);
            this.guna2Panel1.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(-4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "PUAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(131, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 85;
            this.label4.Text = "SÜRE";
            // 
            // puanLbl
            // 
            this.puanLbl.AutoSize = true;
            this.puanLbl.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.puanLbl, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.puanLbl, BunifuAnimatorNS.DecorationType.None);
            this.puanLbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanLbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.puanLbl.Location = new System.Drawing.Point(126, 8);
            this.puanLbl.Name = "puanLbl";
            this.puanLbl.Size = new System.Drawing.Size(24, 23);
            this.puanLbl.TabIndex = 39;
            this.puanLbl.Text = "0";
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.timerLbl, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.timerLbl, BunifuAnimatorNS.DecorationType.None);
            this.timerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timerLbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.timerLbl.Location = new System.Drawing.Point(22, 55);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(32, 24);
            this.timerLbl.TabIndex = 40;
            this.timerLbl.Text = "60";
            // 
            // uyariLbl
            // 
            this.uyariLbl.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.uyariLbl, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.uyariLbl, BunifuAnimatorNS.DecorationType.None);
            this.uyariLbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyariLbl.ForeColor = System.Drawing.Color.SlateBlue;
            this.uyariLbl.Location = new System.Drawing.Point(268, 37);
            this.uyariLbl.Name = "uyariLbl";
            this.uyariLbl.Size = new System.Drawing.Size(0, 18);
            this.uyariLbl.TabIndex = 38;
            // 
            // trueGif
            // 
            this.bunifuTransition1.SetDecoration(this.trueGif, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.trueGif, BunifuAnimatorNS.DecorationType.None);
            this.trueGif.Image = ((System.Drawing.Image)(resources.GetObject("trueGif.Image")));
            this.trueGif.Location = new System.Drawing.Point(299, 68);
            this.trueGif.Name = "trueGif";
            this.trueGif.ShadowDecoration.Parent = this.trueGif;
            this.trueGif.Size = new System.Drawing.Size(58, 60);
            this.trueGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trueGif.TabIndex = 37;
            this.trueGif.TabStop = false;
            // 
            // falseGif
            // 
            this.bunifuTransition1.SetDecoration(this.falseGif, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.falseGif, BunifuAnimatorNS.DecorationType.None);
            this.falseGif.Image = ((System.Drawing.Image)(resources.GetObject("falseGif.Image")));
            this.falseGif.Location = new System.Drawing.Point(299, 68);
            this.falseGif.Name = "falseGif";
            this.falseGif.ShadowDecoration.Parent = this.falseGif;
            this.falseGif.Size = new System.Drawing.Size(58, 60);
            this.falseGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.falseGif.TabIndex = 36;
            this.falseGif.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.pictureBox10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox10, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox10.Location = new System.Drawing.Point(174, 349);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(98, 86);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 35;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.tikla);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.pictureBox11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox11, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox11.Location = new System.Drawing.Point(278, 349);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(98, 86);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 34;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.tikla);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.BackgroundImage")));
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.pictureBox12, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox12, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox12.Location = new System.Drawing.Point(382, 349);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(98, 86);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 33;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.tikla);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.pictureBox7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox7, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox7.Location = new System.Drawing.Point(278, 257);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(98, 86);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 32;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.tikla);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.pictureBox8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox8, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox8.Location = new System.Drawing.Point(382, 257);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(98, 86);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.tikla);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.pictureBox9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox9, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox9.Location = new System.Drawing.Point(70, 349);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(98, 86);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 30;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.tikla);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.pictureBox6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox6, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox6.Location = new System.Drawing.Point(174, 257);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(98, 86);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.tikla);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox5.Location = new System.Drawing.Point(70, 257);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(98, 86);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.tikla);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Location = new System.Drawing.Point(382, 165);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(98, 86);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.tikla);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Location = new System.Drawing.Point(278, 165);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.tikla);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(174, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.tikla);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(70, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.tikla);
            // 
            // bulunan1
            // 
            this.bulunan1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bulunan1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bulunan1, BunifuAnimatorNS.DecorationType.None);
            this.bulunan1.Image = ((System.Drawing.Image)(resources.GetObject("bulunan1.Image")));
            this.bulunan1.Location = new System.Drawing.Point(489, 20);
            this.bulunan1.Name = "bulunan1";
            this.bulunan1.ShadowDecoration.Parent = this.bulunan1;
            this.bulunan1.Size = new System.Drawing.Size(30, 24);
            this.bulunan1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bulunan1.TabIndex = 132;
            this.bulunan1.TabStop = false;
            // 
            // bulunan2
            // 
            this.bulunan2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bulunan2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bulunan2, BunifuAnimatorNS.DecorationType.None);
            this.bulunan2.Image = ((System.Drawing.Image)(resources.GetObject("bulunan2.Image")));
            this.bulunan2.Location = new System.Drawing.Point(517, 20);
            this.bulunan2.Name = "bulunan2";
            this.bulunan2.ShadowDecoration.Parent = this.bulunan2;
            this.bulunan2.Size = new System.Drawing.Size(30, 24);
            this.bulunan2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bulunan2.TabIndex = 128;
            this.bulunan2.TabStop = false;
            // 
            // bulunan3
            // 
            this.bulunan3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bulunan3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bulunan3, BunifuAnimatorNS.DecorationType.None);
            this.bulunan3.Image = ((System.Drawing.Image)(resources.GetObject("bulunan3.Image")));
            this.bulunan3.Location = new System.Drawing.Point(544, 20);
            this.bulunan3.Name = "bulunan3";
            this.bulunan3.ShadowDecoration.Parent = this.bulunan3;
            this.bulunan3.Size = new System.Drawing.Size(30, 24);
            this.bulunan3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bulunan3.TabIndex = 127;
            this.bulunan3.TabStop = false;
            // 
            // bulunan4
            // 
            this.bulunan4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bulunan4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bulunan4, BunifuAnimatorNS.DecorationType.None);
            this.bulunan4.Image = ((System.Drawing.Image)(resources.GetObject("bulunan4.Image")));
            this.bulunan4.Location = new System.Drawing.Point(571, 20);
            this.bulunan4.Name = "bulunan4";
            this.bulunan4.ShadowDecoration.Parent = this.bulunan4;
            this.bulunan4.Size = new System.Drawing.Size(30, 24);
            this.bulunan4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bulunan4.TabIndex = 126;
            this.bulunan4.TabStop = false;
            // 
            // bulunan5
            // 
            this.bulunan5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bulunan5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bulunan5, BunifuAnimatorNS.DecorationType.None);
            this.bulunan5.Image = ((System.Drawing.Image)(resources.GetObject("bulunan5.Image")));
            this.bulunan5.Location = new System.Drawing.Point(598, 20);
            this.bulunan5.Name = "bulunan5";
            this.bulunan5.ShadowDecoration.Parent = this.bulunan5;
            this.bulunan5.Size = new System.Drawing.Size(30, 24);
            this.bulunan5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bulunan5.TabIndex = 125;
            this.bulunan5.TabStop = false;
            // 
            // bulunan6
            // 
            this.bulunan6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bulunan6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bulunan6, BunifuAnimatorNS.DecorationType.None);
            this.bulunan6.Image = ((System.Drawing.Image)(resources.GetObject("bulunan6.Image")));
            this.bulunan6.Location = new System.Drawing.Point(625, 20);
            this.bulunan6.Name = "bulunan6";
            this.bulunan6.ShadowDecoration.Parent = this.bulunan6;
            this.bulunan6.Size = new System.Drawing.Size(30, 24);
            this.bulunan6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bulunan6.TabIndex = 124;
            this.bulunan6.TabStop = false;
            // 
            // UCPlayKolay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.ucHomePanel);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "UCPlayKolay";
            this.Size = new System.Drawing.Size(705, 540);
            this.Load += new System.EventHandler(this.UCPlayKolay_Load);
            this.ucHomePanel.ResumeLayout(false);
            this.ucHomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trueGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falseGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulunan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulunan2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulunan3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulunan4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulunan5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulunan6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ucHomePanel;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox falseGif;
        private Guna.UI2.WinForms.Guna2PictureBox trueGif;
        private System.Windows.Forms.Label uyariLbl;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label puanLbl;
        private System.Windows.Forms.Label timerLbl;
        private Guna.UI2.WinForms.Guna2PictureBox backBtn;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private Guna.UI2.WinForms.Guna2PictureBox bulunan1;
        private Guna.UI2.WinForms.Guna2PictureBox bulunan2;
        private Guna.UI2.WinForms.Guna2PictureBox bulunan3;
        private Guna.UI2.WinForms.Guna2PictureBox bulunan4;
        private Guna.UI2.WinForms.Guna2PictureBox bulunan5;
        private Guna.UI2.WinForms.Guna2PictureBox bulunan6;
    }
}
