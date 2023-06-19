
namespace WindowsFormsApp6.PL
{
    partial class FROM_OGRENCILER_EKLE 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FROM_OGRENCILER_EKLE));
            this.txt_ogrenci_ad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.insert_txt = new System.Windows.Forms.Label();
            this.ADD_YENİ_OGRENCI = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ogrenci_adres = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_ogrenci_Telefon = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ogrenci_NO = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ogrenci_Bolum = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ogrenci_EMAIL = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txt_ogrenci_FOTO = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ogrenci_FOTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ogrenci_ad
            // 
            this.txt_ogrenci_ad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ogrenci_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ogrenci_ad.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txt_ogrenci_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ogrenci_ad.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ogrenci_ad.HintText = "";
            this.txt_ogrenci_ad.isPassword = false;
            this.txt_ogrenci_ad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_ogrenci_ad.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.txt_ogrenci_ad.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.txt_ogrenci_ad.LineThickness = 6;
            this.txt_ogrenci_ad.Location = new System.Drawing.Point(9, 67);
            this.txt_ogrenci_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ogrenci_ad.Name = "txt_ogrenci_ad";
            this.txt_ogrenci_ad.Size = new System.Drawing.Size(301, 43);
            this.txt_ogrenci_ad.TabIndex = 9;
            this.txt_ogrenci_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ogrenci_ad.OnValueChanged += new System.EventHandler(this.txt_kat_name_OnValueChanged);
            // 
            // insert_txt
            // 
            this.insert_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_txt.AutoSize = true;
            this.insert_txt.BackColor = System.Drawing.Color.Transparent;
            this.insert_txt.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.insert_txt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insert_txt.Location = new System.Drawing.Point(11, 39);
            this.insert_txt.Name = "insert_txt";
            this.insert_txt.Size = new System.Drawing.Size(126, 21);
            this.insert_txt.TabIndex = 8;
            this.insert_txt.Text = "Öğrenci Adı :";
            this.insert_txt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insert_txt.Click += new System.EventHandler(this.insert_txt_Click);
            // 
            // ADD_YENİ_OGRENCI
            // 
            this.ADD_YENİ_OGRENCI.ActiveBorderThickness = 1;
            this.ADD_YENİ_OGRENCI.ActiveCornerRadius = 20;
            this.ADD_YENİ_OGRENCI.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ADD_YENİ_OGRENCI.ActiveForecolor = System.Drawing.Color.White;
            this.ADD_YENİ_OGRENCI.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ADD_YENİ_OGRENCI.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ADD_YENİ_OGRENCI.BackColor = System.Drawing.Color.White;
            this.ADD_YENİ_OGRENCI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ADD_YENİ_OGRENCI.BackgroundImage")));
            this.ADD_YENİ_OGRENCI.ButtonText = "Ekle";
            this.ADD_YENİ_OGRENCI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADD_YENİ_OGRENCI.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_YENİ_OGRENCI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ADD_YENİ_OGRENCI.IdleBorderThickness = 1;
            this.ADD_YENİ_OGRENCI.IdleCornerRadius = 20;
            this.ADD_YENİ_OGRENCI.IdleFillColor = System.Drawing.Color.White;
            this.ADD_YENİ_OGRENCI.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ADD_YENİ_OGRENCI.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ADD_YENİ_OGRENCI.Location = new System.Drawing.Point(63, 471);
            this.ADD_YENİ_OGRENCI.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.ADD_YENİ_OGRENCI.Name = "ADD_YENİ_OGRENCI";
            this.ADD_YENİ_OGRENCI.Size = new System.Drawing.Size(575, 66);
            this.ADD_YENİ_OGRENCI.TabIndex = 10;
            this.ADD_YENİ_OGRENCI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ADD_YENİ_OGRENCI.Click += new System.EventHandler(this.ADD_YENİ_CAT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ogrenci_adres);
            this.groupBox1.Controls.Add(this.txt_ogrenci_Telefon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ogrenci_NO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_ogrenci_ad);
            this.groupBox1.Controls.Add(this.insert_txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 437);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgilaeri";
            // 
            // txt_ogrenci_adres
            // 
            this.txt_ogrenci_adres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ogrenci_adres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ogrenci_adres.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txt_ogrenci_adres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ogrenci_adres.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ogrenci_adres.HintText = "";
            this.txt_ogrenci_adres.isPassword = false;
            this.txt_ogrenci_adres.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_ogrenci_adres.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.txt_ogrenci_adres.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.txt_ogrenci_adres.LineThickness = 6;
            this.txt_ogrenci_adres.Location = new System.Drawing.Point(9, 271);
            this.txt_ogrenci_adres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ogrenci_adres.Name = "txt_ogrenci_adres";
            this.txt_ogrenci_adres.Size = new System.Drawing.Size(301, 43);
            this.txt_ogrenci_adres.TabIndex = 12;
            this.txt_ogrenci_adres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ogrenci_Telefon
            // 
            this.txt_ogrenci_Telefon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ogrenci_Telefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ogrenci_Telefon.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txt_ogrenci_Telefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ogrenci_Telefon.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ogrenci_Telefon.HintText = "";
            this.txt_ogrenci_Telefon.isPassword = false;
            this.txt_ogrenci_Telefon.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_ogrenci_Telefon.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.txt_ogrenci_Telefon.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.txt_ogrenci_Telefon.LineThickness = 6;
            this.txt_ogrenci_Telefon.Location = new System.Drawing.Point(9, 355);
            this.txt_ogrenci_Telefon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ogrenci_Telefon.Name = "txt_ogrenci_Telefon";
            this.txt_ogrenci_Telefon.Size = new System.Drawing.Size(301, 43);
            this.txt_ogrenci_Telefon.TabIndex = 11;
            this.txt_ogrenci_Telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(11, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "öğrenci telefeonu :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(11, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "öğrenci addresi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_ogrenci_NO
            // 
            this.txt_ogrenci_NO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ogrenci_NO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ogrenci_NO.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txt_ogrenci_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ogrenci_NO.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ogrenci_NO.HintText = "";
            this.txt_ogrenci_NO.isPassword = false;
            this.txt_ogrenci_NO.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_ogrenci_NO.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.txt_ogrenci_NO.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.txt_ogrenci_NO.LineThickness = 6;
            this.txt_ogrenci_NO.Location = new System.Drawing.Point(9, 166);
            this.txt_ogrenci_NO.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ogrenci_NO.Name = "txt_ogrenci_NO";
            this.txt_ogrenci_NO.Size = new System.Drawing.Size(301, 43);
            this.txt_ogrenci_NO.TabIndex = 11;
            this.txt_ogrenci_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(11, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "öğrenci numarası :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ogrenci_Bolum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_ogrenci_EMAIL);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.txt_ogrenci_FOTO);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(378, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 437);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diğer kitap bilgileri";
            // 
            // txt_ogrenci_Bolum
            // 
            this.txt_ogrenci_Bolum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ogrenci_Bolum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ogrenci_Bolum.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txt_ogrenci_Bolum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ogrenci_Bolum.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ogrenci_Bolum.HintText = "";
            this.txt_ogrenci_Bolum.isPassword = false;
            this.txt_ogrenci_Bolum.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_ogrenci_Bolum.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.txt_ogrenci_Bolum.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.txt_ogrenci_Bolum.LineThickness = 6;
            this.txt_ogrenci_Bolum.Location = new System.Drawing.Point(9, 166);
            this.txt_ogrenci_Bolum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ogrenci_Bolum.Name = "txt_ogrenci_Bolum";
            this.txt_ogrenci_Bolum.Size = new System.Drawing.Size(301, 43);
            this.txt_ogrenci_Bolum.TabIndex = 18;
            this.txt_ogrenci_Bolum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(8, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "öğrenci bülümü :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_ogrenci_EMAIL
            // 
            this.txt_ogrenci_EMAIL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ogrenci_EMAIL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ogrenci_EMAIL.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txt_ogrenci_EMAIL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ogrenci_EMAIL.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ogrenci_EMAIL.HintText = "";
            this.txt_ogrenci_EMAIL.isPassword = false;
            this.txt_ogrenci_EMAIL.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_ogrenci_EMAIL.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.txt_ogrenci_EMAIL.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.txt_ogrenci_EMAIL.LineThickness = 6;
            this.txt_ogrenci_EMAIL.Location = new System.Drawing.Point(9, 67);
            this.txt_ogrenci_EMAIL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ogrenci_EMAIL.Name = "txt_ogrenci_EMAIL";
            this.txt_ogrenci_EMAIL.Size = new System.Drawing.Size(301, 43);
            this.txt_ogrenci_EMAIL.TabIndex = 15;
            this.txt_ogrenci_EMAIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(8, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "öğrenci  email :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.linkLabel1.Location = new System.Drawing.Point(105, 407);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 20);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Resim Ekle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txt_ogrenci_FOTO
            // 
            this.txt_ogrenci_FOTO.ErrorImage = global::WindowsFormsApp6.Properties.Resources.books_40px;
            this.txt_ogrenci_FOTO.Image = global::WindowsFormsApp6.Properties.Resources.borrow_book_40px;
            this.txt_ogrenci_FOTO.InitialImage = global::WindowsFormsApp6.Properties.Resources.books_40px;
            this.txt_ogrenci_FOTO.Location = new System.Drawing.Point(79, 269);
            this.txt_ogrenci_FOTO.Name = "txt_ogrenci_FOTO";
            this.txt_ogrenci_FOTO.Size = new System.Drawing.Size(144, 129);
            this.txt_ogrenci_FOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txt_ogrenci_FOTO.TabIndex = 13;
            this.txt_ogrenci_FOTO.TabStop = false;
            this.txt_ogrenci_FOTO.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(6, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "öğrenci fotoğrafı :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = " ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApp6.Properties.Resources.rejected;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(714, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 22);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 13;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // FROM_OGRENCILER_EKLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 546);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ADD_YENİ_OGRENCI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FROM_OGRENCILER_EKLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FROM_KITABLAR_EKLE";
            this.Load += new System.EventHandler(this.FROM_KITABLAR_EKLE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ogrenci_FOTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuThinButton2 ADD_YENİ_OGRENCI;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_ogrenci_ad;
        private System.Windows.Forms.Label insert_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_ogrenci_Telefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.PictureBox txt_ogrenci_FOTO;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_ogrenci_adres;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_ogrenci_Bolum;
        private System.Windows.Forms.Label label7;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_ogrenci_EMAIL;
        private System.Windows.Forms.Label label8;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_ogrenci_NO;
        private System.Windows.Forms.Label label1;
    }
}