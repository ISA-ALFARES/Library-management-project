
namespace WindowsFormsApp6.PL
{
    partial class FROM_KULLANCI_EKLE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FROM_KULLANCI_EKLE));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ADD_YENİ_OGRENCI = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Yetkiler = new System.Windows.Forms.ComboBox();
            this.txt_ogrenci_sifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kullanci_ad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kullanci_tum_ad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.insert_txt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.ADD_YENİ_OGRENCI);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 553);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ADD_YENİ_OGRENCI
            // 
            this.ADD_YENİ_OGRENCI.ActiveBorderThickness = 1;
            this.ADD_YENİ_OGRENCI.ActiveCornerRadius = 20;
            this.ADD_YENİ_OGRENCI.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ADD_YENİ_OGRENCI.ActiveForecolor = System.Drawing.Color.White;
            this.ADD_YENİ_OGRENCI.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ADD_YENİ_OGRENCI.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ADD_YENİ_OGRENCI.BackColor = System.Drawing.SystemColors.Control;
            this.ADD_YENİ_OGRENCI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ADD_YENİ_OGRENCI.BackgroundImage")));
            this.ADD_YENİ_OGRENCI.ButtonText = "Ekle";
            this.ADD_YENİ_OGRENCI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADD_YENİ_OGRENCI.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_YENİ_OGRENCI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ADD_YENİ_OGRENCI.IdleBorderThickness = 1;
            this.ADD_YENİ_OGRENCI.IdleCornerRadius = 20;
            this.ADD_YENİ_OGRENCI.IdleFillColor = System.Drawing.Color.White;
            this.ADD_YENİ_OGRENCI.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ADD_YENİ_OGRENCI.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ADD_YENİ_OGRENCI.Location = new System.Drawing.Point(25, 471);
            this.ADD_YENİ_OGRENCI.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.ADD_YENİ_OGRENCI.Name = "ADD_YENİ_OGRENCI";
            this.ADD_YENİ_OGRENCI.Size = new System.Drawing.Size(344, 65);
            this.ADD_YENİ_OGRENCI.TabIndex = 13;
            this.ADD_YENİ_OGRENCI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ADD_YENİ_OGRENCI.Click += new System.EventHandler(this.ADD_YENİ_OGRENCI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Yetkiler);
            this.groupBox1.Controls.Add(this.txt_ogrenci_sifre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_kullanci_ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_kullanci_tum_ad);
            this.groupBox1.Controls.Add(this.insert_txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 538);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgilaeri";
            // 
            // txt_Yetkiler
            // 
            this.txt_Yetkiler.FormattingEnabled = true;
            this.txt_Yetkiler.Items.AddRange(new object[] {
            "ADMIN",
            "KUllanci"});
            this.txt_Yetkiler.Location = new System.Drawing.Point(23, 389);
            this.txt_Yetkiler.Name = "txt_Yetkiler";
            this.txt_Yetkiler.Size = new System.Drawing.Size(301, 21);
            this.txt_Yetkiler.TabIndex = 14;
            // 
            // txt_ogrenci_sifre
            // 
            this.txt_ogrenci_sifre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ogrenci_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ogrenci_sifre.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txt_ogrenci_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ogrenci_sifre.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ogrenci_sifre.HintText = "önek:  1234";
            this.txt_ogrenci_sifre.isPassword = false;
            this.txt_ogrenci_sifre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_ogrenci_sifre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ogrenci_sifre.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.txt_ogrenci_sifre.LineThickness = 6;
            this.txt_ogrenci_sifre.Location = new System.Drawing.Point(37, 271);
            this.txt_ogrenci_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ogrenci_sifre.Name = "txt_ogrenci_sifre";
            this.txt_ogrenci_sifre.Size = new System.Drawing.Size(301, 43);
            this.txt_ogrenci_sifre.TabIndex = 12;
            this.txt_ogrenci_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(8, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yetkiker :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(8, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_kullanci_ad
            // 
            this.txt_kullanci_ad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_kullanci_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_kullanci_ad.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txt_kullanci_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_kullanci_ad.HintForeColor = System.Drawing.Color.Empty;
            this.txt_kullanci_ad.HintText = "önek:  isa101";
            this.txt_kullanci_ad.isPassword = false;
            this.txt_kullanci_ad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_kullanci_ad.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_kullanci_ad.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.txt_kullanci_ad.LineThickness = 6;
            this.txt_kullanci_ad.Location = new System.Drawing.Point(37, 166);
            this.txt_kullanci_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kullanci_ad.Name = "txt_kullanci_ad";
            this.txt_kullanci_ad.Size = new System.Drawing.Size(301, 43);
            this.txt_kullanci_ad.TabIndex = 11;
            this.txt_kullanci_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(8, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanci Adi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_kullanci_tum_ad
            // 
            this.txt_kullanci_tum_ad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_kullanci_tum_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_kullanci_tum_ad.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txt_kullanci_tum_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_kullanci_tum_ad.HintForeColor = System.Drawing.Color.Empty;
            this.txt_kullanci_tum_ad.HintText = "önek:  isa";
            this.txt_kullanci_tum_ad.isPassword = false;
            this.txt_kullanci_tum_ad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_kullanci_tum_ad.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_kullanci_tum_ad.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.txt_kullanci_tum_ad.LineThickness = 6;
            this.txt_kullanci_tum_ad.Location = new System.Drawing.Point(37, 67);
            this.txt_kullanci_tum_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kullanci_tum_ad.Name = "txt_kullanci_tum_ad";
            this.txt_kullanci_tum_ad.Size = new System.Drawing.Size(301, 43);
            this.txt_kullanci_tum_ad.TabIndex = 9;
            this.txt_kullanci_tum_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insert_txt
            // 
            this.insert_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_txt.AutoSize = true;
            this.insert_txt.BackColor = System.Drawing.Color.Transparent;
            this.insert_txt.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_txt.ForeColor = System.Drawing.Color.Black;
            this.insert_txt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insert_txt.Location = new System.Drawing.Point(8, 39);
            this.insert_txt.Name = "insert_txt";
            this.insert_txt.Size = new System.Drawing.Size(54, 21);
            this.insert_txt.TabIndex = 8;
            this.insert_txt.Text = "ADI :";
            this.insert_txt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.bunifuImageButton2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(392, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 553);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(68, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 35);
            this.label4.TabIndex = 15;
            this.label4.Text = "Yeni Kullanci Ekle:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp6.Properties.Resources._236831;
            this.pictureBox2.Location = new System.Drawing.Point(55, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 354);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::WindowsFormsApp6.Properties.Resources.rejected;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(376, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(28, 32);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 10;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp6.Properties.Resources._236831;
            this.pictureBox1.Location = new System.Drawing.Point(-158, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApp6.Properties.Resources.rejected;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(537, 222);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 22);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FROM_KULLANCI_EKLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FROM_KULLANCI_EKLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FROM_KULLANCI_EKLE";
            this.Load += new System.EventHandler(this.FROM_KULLANCI_EKLE_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_ogrenci_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_kullanci_ad;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_kullanci_tum_ad;
        private System.Windows.Forms.Label insert_txt;
        public Bunifu.Framework.UI.BunifuThinButton2 ADD_YENİ_OGRENCI;
        private System.Windows.Forms.ComboBox txt_Yetkiler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}