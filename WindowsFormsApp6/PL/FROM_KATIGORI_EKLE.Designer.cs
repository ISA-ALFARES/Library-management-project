
namespace WindowsFormsApp6.PL
{
    partial class FROM_KATIGORI_EKLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FROM_KATIGORI_EKLE));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.insert_txt = new System.Windows.Forms.Label();
            this.txt_kat_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ADD_YENİ_CAT = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApp6.Properties.Resources.rejected;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(573, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 22);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // insert_txt
            // 
            this.insert_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_txt.AutoSize = true;
            this.insert_txt.BackColor = System.Drawing.Color.Transparent;
            this.insert_txt.Font = new System.Drawing.Font("Rockwell", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.insert_txt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insert_txt.Location = new System.Drawing.Point(140, 83);
            this.insert_txt.Name = "insert_txt";
            this.insert_txt.Size = new System.Drawing.Size(310, 60);
            this.insert_txt.TabIndex = 5;
            this.insert_txt.Text = "Katigori Ad";
            this.insert_txt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_kat_name
            // 
            this.txt_kat_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_kat_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_kat_name.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txt_kat_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_kat_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_kat_name.HintText = "";
            this.txt_kat_name.isPassword = false;
            this.txt_kat_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_kat_name.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.txt_kat_name.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.txt_kat_name.LineThickness = 6;
            this.txt_kat_name.Location = new System.Drawing.Point(53, 176);
            this.txt_kat_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kat_name.Name = "txt_kat_name";
            this.txt_kat_name.Size = new System.Drawing.Size(465, 43);
            this.txt_kat_name.TabIndex = 6;
            this.txt_kat_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_kat_name.OnValueChanged += new System.EventHandler(this.arama_OnValueChanged);
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
            this.ADD_YENİ_CAT.ForeColor = System.Drawing.Color.SeaGreen;
            this.ADD_YENİ_CAT.IdleBorderThickness = 1;
            this.ADD_YENİ_CAT.IdleCornerRadius = 20;
            this.ADD_YENİ_CAT.IdleFillColor = System.Drawing.Color.White;
            this.ADD_YENİ_CAT.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.ADD_YENİ_CAT.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ADD_YENİ_CAT.Location = new System.Drawing.Point(53, 358);
            this.ADD_YENİ_CAT.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.ADD_YENİ_CAT.Name = "ADD_YENİ_CAT";
            this.ADD_YENİ_CAT.Size = new System.Drawing.Size(465, 82);
            this.ADD_YENİ_CAT.TabIndex = 7;
            this.ADD_YENİ_CAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ADD_YENİ_CAT.Click += new System.EventHandler(this.ADD_YENİ_CAT_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuImageButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(459, 167);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(49, 43);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton7.TabIndex = 16;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuImageButton7.Zoom = 10;
            // 
            // FROM_KATIGORI_EKLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 454);
            this.Controls.Add(this.bunifuImageButton7);
            this.Controls.Add(this.ADD_YENİ_CAT);
            this.Controls.Add(this.txt_kat_name);
            this.Controls.Add(this.insert_txt);
            this.Controls.Add(this.bunifuImageButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FROM_KATIGORI_EKLE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADDCAT";
            this.Load += new System.EventHandler(this.FRM_ADDCAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label insert_txt;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuThinButton2 ADD_YENİ_CAT;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_kat_name;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
    }
}