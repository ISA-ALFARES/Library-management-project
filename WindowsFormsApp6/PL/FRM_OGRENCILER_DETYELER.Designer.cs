
namespace WindowsFormsApp6.FORMLAR
{
    partial class FRM_OGRENCI_DETYELER 
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_kitap_resım = new System.Windows.Forms.PictureBox();
            this.txt_kitap_Degerlendırme = new Bunifu.Framework.UI.BunifuRating();
            this.txt_kitap_Tarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.Label();
            this.txt_kitap_ad = new System.Windows.Forms.Label();
            this.txt_yazar_name = new System.Windows.Forms.Label();
            this.txt_kitap_Fiati = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insert_txt = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kitap_resım)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txt_kitap_resım);
            this.groupBox2.Controls.Add(this.txt_kitap_Degerlendırme);
            this.groupBox2.Controls.Add(this.txt_kitap_Tarih);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(411, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 457);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diğer kitap bilgileri";
            // 
            // txt_kitap_resım
            // 
            this.txt_kitap_resım.ErrorImage = global::WindowsFormsApp6.Properties.Resources.books_40px;
            this.txt_kitap_resım.Image = global::WindowsFormsApp6.Properties.Resources.borrow_book_40px;
            this.txt_kitap_resım.InitialImage = global::WindowsFormsApp6.Properties.Resources.books_40px;
            this.txt_kitap_resım.Location = new System.Drawing.Point(119, 276);
            this.txt_kitap_resım.Name = "txt_kitap_resım";
            this.txt_kitap_resım.Size = new System.Drawing.Size(186, 175);
            this.txt_kitap_resım.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txt_kitap_resım.TabIndex = 13;
            this.txt_kitap_resım.TabStop = false;
            this.txt_kitap_resım.Click += new System.EventHandler(this.txt_kitap_resım_Click);
            // 
            // txt_kitap_Degerlendırme
            // 
            this.txt_kitap_Degerlendırme.BackColor = System.Drawing.Color.Transparent;
            this.txt_kitap_Degerlendırme.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_kitap_Degerlendırme.Location = new System.Drawing.Point(10, 163);
            this.txt_kitap_Degerlendırme.Name = "txt_kitap_Degerlendırme";
            this.txt_kitap_Degerlendırme.Size = new System.Drawing.Size(406, 50);
            this.txt_kitap_Degerlendırme.TabIndex = 12;
            this.txt_kitap_Degerlendırme.Value = 0;
            this.txt_kitap_Degerlendırme.onValueChanged += new System.EventHandler(this.txt_kitap_Degerlendırme_onValueChanged);
            // 
            // txt_kitap_Tarih
            // 
            this.txt_kitap_Tarih.BackColor = System.Drawing.Color.SeaGreen;
            this.txt_kitap_Tarih.BorderRadius = 0;
            this.txt_kitap_Tarih.ForeColor = System.Drawing.Color.White;
            this.txt_kitap_Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_kitap_Tarih.FormatCustom = null;
            this.txt_kitap_Tarih.Location = new System.Drawing.Point(8, 73);
            this.txt_kitap_Tarih.Name = "txt_kitap_Tarih";
            this.txt_kitap_Tarih.Size = new System.Drawing.Size(408, 36);
            this.txt_kitap_Tarih.TabIndex = 11;
            this.txt_kitap_Tarih.Value = new System.DateTime(2023, 6, 10, 14, 46, 12, 796);
            this.txt_kitap_Tarih.onValueChanged += new System.EventHandler(this.txt_kitap_Tarih_onValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
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
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Basım tarihi :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txt_kitap_ad);
            this.groupBox1.Controls.Add(this.txt_yazar_name);
            this.groupBox1.Controls.Add(this.txt_kitap_Fiati);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.insert_txt);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 457);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgilaeri";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.AutoSize = true;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.comboBox1.Location = new System.Drawing.Point(115, 292);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(0, 25);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // txt_kitap_ad
            // 
            this.txt_kitap_ad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kitap_ad.AutoSize = true;
            this.txt_kitap_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_kitap_ad.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kitap_ad.ForeColor = System.Drawing.Color.White;
            this.txt_kitap_ad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txt_kitap_ad.Location = new System.Drawing.Point(138, 73);
            this.txt_kitap_ad.Name = "txt_kitap_ad";
            this.txt_kitap_ad.Size = new System.Drawing.Size(0, 25);
            this.txt_kitap_ad.TabIndex = 14;
            this.txt_kitap_ad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txt_kitap_ad.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_yazar_name
            // 
            this.txt_yazar_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_yazar_name.AutoSize = true;
            this.txt_yazar_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_yazar_name.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_yazar_name.ForeColor = System.Drawing.Color.White;
            this.txt_yazar_name.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txt_yazar_name.Location = new System.Drawing.Point(138, 178);
            this.txt_yazar_name.Name = "txt_yazar_name";
            this.txt_yazar_name.Size = new System.Drawing.Size(0, 25);
            this.txt_yazar_name.TabIndex = 13;
            this.txt_yazar_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txt_yazar_name.Click += new System.EventHandler(this.txt_yazar_name_Click);
            // 
            // txt_kitap_Fiati
            // 
            this.txt_kitap_Fiati.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kitap_Fiati.AutoSize = true;
            this.txt_kitap_Fiati.BackColor = System.Drawing.Color.Transparent;
            this.txt_kitap_Fiati.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kitap_Fiati.ForeColor = System.Drawing.Color.White;
            this.txt_kitap_Fiati.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txt_kitap_Fiati.Location = new System.Drawing.Point(138, 395);
            this.txt_kitap_Fiati.Name = "txt_kitap_Fiati";
            this.txt_kitap_Fiati.Size = new System.Drawing.Size(0, 21);
            this.txt_kitap_Fiati.TabIndex = 12;
            this.txt_kitap_Fiati.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txt_kitap_Fiati.Click += new System.EventHandler(this.txt_kitap_Fiati_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(138, 353);
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
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(113, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "kitap kategorisi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(138, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Yazar Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // insert_txt
            // 
            this.insert_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_txt.AutoSize = true;
            this.insert_txt.BackColor = System.Drawing.Color.Transparent;
            this.insert_txt.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_txt.ForeColor = System.Drawing.Color.White;
            this.insert_txt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insert_txt.Location = new System.Drawing.Point(138, 16);
            this.insert_txt.Name = "insert_txt";
            this.insert_txt.Size = new System.Drawing.Size(99, 21);
            this.insert_txt.TabIndex = 8;
            this.insert_txt.Text = "Kitap AD :";
            this.insert_txt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApp6.Properties.Resources.rejected;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(884, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 22);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 15;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // FRM_DETYELER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(910, 517);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_DETYELER";
            this.Opacity = 0.6D;
            this.Text = "Form_DETYELER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kitap_resım)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.PictureBox txt_kitap_resım;
        public Bunifu.Framework.UI.BunifuRating txt_kitap_Degerlendırme;
        public Bunifu.Framework.UI.BunifuDatepicker txt_kitap_Tarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label insert_txt;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.Label txt_kitap_ad;
        public System.Windows.Forms.Label txt_yazar_name;
        public System.Windows.Forms.Label comboBox1;
        public System.Windows.Forms.Label txt_kitap_Fiati;
    }
}