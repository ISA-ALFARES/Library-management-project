
namespace WindowsFormsApp6.PL
{
    partial class FROM_KITABLAR_EKLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FROM_KITABLAR_EKLE));
            this.txt_kitap_ad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.insert_txt = new System.Windows.Forms.Label();
            this.ADD_YENİ_CAT = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.txt_kitap_Fiati = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_yazar_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txt_kitap_resım = new System.Windows.Forms.PictureBox();
            this.txt_kitap_Degerlendırme = new Bunifu.Framework.UI.BunifuRating();
            this.txt_kitap_Tarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kitap_resım)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_kitap_ad
            // 
            this.txt_kitap_ad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_kitap_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_kitap_ad.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txt_kitap_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_kitap_ad.HintForeColor = System.Drawing.Color.Empty;
            this.txt_kitap_ad.HintText = "";
            this.txt_kitap_ad.isPassword = false;
            this.txt_kitap_ad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_kitap_ad.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.txt_kitap_ad.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.txt_kitap_ad.LineThickness = 6;
            this.txt_kitap_ad.Location = new System.Drawing.Point(9, 67);
            this.txt_kitap_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kitap_ad.Name = "txt_kitap_ad";
            this.txt_kitap_ad.Size = new System.Drawing.Size(301, 43);
            this.txt_kitap_ad.TabIndex = 9;
            this.txt_kitap_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_kitap_ad.OnValueChanged += new System.EventHandler(this.txt_kat_name_OnValueChanged);
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
            this.insert_txt.Location = new System.Drawing.Point(8, 39);
            this.insert_txt.Name = "insert_txt";
            this.insert_txt.Size = new System.Drawing.Size(99, 21);
            this.insert_txt.TabIndex = 8;
            this.insert_txt.Text = "Kitap AD :";
            this.insert_txt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insert_txt.Click += new System.EventHandler(this.insert_txt_Click);
            // 
            // ADD_YENİ_CAT
            // 
            this.ADD_YENİ_CAT.ActiveBorderThickness = 1;
            this.ADD_YENİ_CAT.ActiveCornerRadius = 20;
            this.ADD_YENİ_CAT.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ADD_YENİ_CAT.ActiveForecolor = System.Drawing.Color.White;
            this.ADD_YENİ_CAT.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ADD_YENİ_CAT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ADD_YENİ_CAT.BackColor = System.Drawing.Color.White;
            this.ADD_YENİ_CAT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ADD_YENİ_CAT.BackgroundImage")));
            this.ADD_YENİ_CAT.ButtonText = "Ekle";
            this.ADD_YENİ_CAT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADD_YENİ_CAT.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_YENİ_CAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ADD_YENİ_CAT.IdleBorderThickness = 1;
            this.ADD_YENİ_CAT.IdleCornerRadius = 20;
            this.ADD_YENİ_CAT.IdleFillColor = System.Drawing.Color.White;
            this.ADD_YENİ_CAT.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.ADD_YENİ_CAT.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ADD_YENİ_CAT.Location = new System.Drawing.Point(63, 471);
            this.ADD_YENİ_CAT.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.ADD_YENİ_CAT.Name = "ADD_YENİ_CAT";
            this.ADD_YENİ_CAT.Size = new System.Drawing.Size(575, 66);
            this.ADD_YENİ_CAT.TabIndex = 10;
            this.ADD_YENİ_CAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ADD_YENİ_CAT.Click += new System.EventHandler(this.ADD_YENİ_CAT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuImageButton3);
            this.groupBox1.Controls.Add(this.bunifuImageButton2);
            this.groupBox1.Controls.Add(this.bunifuImageButton7);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.txt_kitap_Fiati);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_yazar_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_kitap_ad);
            this.groupBox1.Controls.Add(this.insert_txt);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 437);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgilaeri";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.linkLabel2.Location = new System.Drawing.Point(21, 278);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(40, 20);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ekle";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // txt_kitap_Fiati
            // 
            this.txt_kitap_Fiati.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_kitap_Fiati.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_kitap_Fiati.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txt_kitap_Fiati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_kitap_Fiati.HintForeColor = System.Drawing.Color.Empty;
            this.txt_kitap_Fiati.HintText = "";
            this.txt_kitap_Fiati.isPassword = false;
            this.txt_kitap_Fiati.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_kitap_Fiati.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.txt_kitap_Fiati.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.txt_kitap_Fiati.LineThickness = 6;
            this.txt_kitap_Fiati.Location = new System.Drawing.Point(9, 355);
            this.txt_kitap_Fiati.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kitap_Fiati.Name = "txt_kitap_Fiati";
            this.txt_kitap_Fiati.Size = new System.Drawing.Size(301, 43);
            this.txt_kitap_Fiati.TabIndex = 11;
            this.txt_kitap_Fiati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label3.Location = new System.Drawing.Point(8, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kitap fiyatı :";
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
            this.label2.Location = new System.Drawing.Point(8, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "kitap kategorisi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_yazar_name
            // 
            this.txt_yazar_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_yazar_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_yazar_name.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txt_yazar_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_yazar_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_yazar_name.HintText = "";
            this.txt_yazar_name.isPassword = false;
            this.txt_yazar_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_yazar_name.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.txt_yazar_name.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.txt_yazar_name.LineThickness = 6;
            this.txt_yazar_name.Location = new System.Drawing.Point(9, 166);
            this.txt_yazar_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yazar_name.Name = "txt_yazar_name";
            this.txt_yazar_name.Size = new System.Drawing.Size(301, 43);
            this.txt_yazar_name.TabIndex = 11;
            this.txt_yazar_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label1.Location = new System.Drawing.Point(8, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Yazar Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.txt_kitap_resım);
            this.groupBox2.Controls.Add(this.txt_kitap_Degerlendırme);
            this.groupBox2.Controls.Add(this.txt_kitap_Tarih);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.groupBox2.Location = new System.Drawing.Point(378, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 437);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diğer kitap bilgileri";
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
            // txt_kitap_resım
            // 
            this.txt_kitap_resım.ErrorImage = global::WindowsFormsApp6.Properties.Resources.books_40px;
            this.txt_kitap_resım.Image = global::WindowsFormsApp6.Properties.Resources.borrow_book_40px;
            this.txt_kitap_resım.InitialImage = global::WindowsFormsApp6.Properties.Resources.books_40px;
            this.txt_kitap_resım.Location = new System.Drawing.Point(79, 269);
            this.txt_kitap_resım.Name = "txt_kitap_resım";
            this.txt_kitap_resım.Size = new System.Drawing.Size(144, 129);
            this.txt_kitap_resım.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txt_kitap_resım.TabIndex = 13;
            this.txt_kitap_resım.TabStop = false;
            this.txt_kitap_resım.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_kitap_Degerlendırme
            // 
            this.txt_kitap_Degerlendırme.BackColor = System.Drawing.Color.Transparent;
            this.txt_kitap_Degerlendırme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.txt_kitap_Degerlendırme.Location = new System.Drawing.Point(10, 163);
            this.txt_kitap_Degerlendırme.Name = "txt_kitap_Degerlendırme";
            this.txt_kitap_Degerlendırme.Size = new System.Drawing.Size(308, 50);
            this.txt_kitap_Degerlendırme.TabIndex = 12;
            this.txt_kitap_Degerlendırme.Value = 0;
            // 
            // txt_kitap_Tarih
            // 
            this.txt_kitap_Tarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.txt_kitap_Tarih.BorderRadius = 0;
            this.txt_kitap_Tarih.ForeColor = System.Drawing.Color.White;
            this.txt_kitap_Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_kitap_Tarih.FormatCustom = null;
            this.txt_kitap_Tarih.Location = new System.Drawing.Point(8, 73);
            this.txt_kitap_Tarih.Name = "txt_kitap_Tarih";
            this.txt_kitap_Tarih.Size = new System.Drawing.Size(303, 36);
            this.txt_kitap_Tarih.TabIndex = 11;
            this.txt_kitap_Tarih.Value = new System.DateTime(2023, 6, 10, 14, 46, 12, 796);
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
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "kitap kapağı :";
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
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Basım tarihi :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuImageButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(279, 363);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(21, 27);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton7.TabIndex = 16;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuImageButton7.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(279, 73);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(21, 27);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 16;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(279, 175);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(21, 27);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 16;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // FROM_KITABLAR_EKLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 546);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ADD_YENİ_CAT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FROM_KITABLAR_EKLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FROM_KITABLAR_EKLE";
            this.Load += new System.EventHandler(this.FROM_KITABLAR_EKLE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kitap_resım)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuThinButton2 ADD_YENİ_CAT;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_kitap_ad;
        private System.Windows.Forms.Label insert_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_kitap_Fiati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_yazar_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        public System.Windows.Forms.PictureBox txt_kitap_resım;
        public Bunifu.Framework.UI.BunifuRating txt_kitap_Degerlendırme;
        public Bunifu.Framework.UI.BunifuDatepicker txt_kitap_Tarih;
        public System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
    }
}