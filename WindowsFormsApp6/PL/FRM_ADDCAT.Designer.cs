
namespace WindowsFormsApp6.PL
{
    partial class FRM_ADDCAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADDCAT));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.insert_txt = new System.Windows.Forms.Label();
            this.add_cat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ADD_YENİ_CAT = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApp6.Properties.Resources.rejected;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(579, -1);
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
            this.insert_txt.ForeColor = System.Drawing.Color.Black;
            this.insert_txt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insert_txt.Location = new System.Drawing.Point(140, 83);
            this.insert_txt.Name = "insert_txt";
            this.insert_txt.Size = new System.Drawing.Size(317, 60);
            this.insert_txt.TabIndex = 5;
            this.insert_txt.Text = "Catigori Ad";
            this.insert_txt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // add_cat
            // 
            this.add_cat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.add_cat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.add_cat.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.add_cat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_cat.HintForeColor = System.Drawing.Color.Empty;
            this.add_cat.HintText = "";
            this.add_cat.isPassword = false;
            this.add_cat.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.add_cat.LineIdleColor = System.Drawing.Color.Gray;
            this.add_cat.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.add_cat.LineThickness = 6;
            this.add_cat.Location = new System.Drawing.Point(53, 176);
            this.add_cat.Margin = new System.Windows.Forms.Padding(4);
            this.add_cat.Name = "add_cat";
            this.add_cat.Size = new System.Drawing.Size(465, 43);
            this.add_cat.TabIndex = 6;
            this.add_cat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.add_cat.OnValueChanged += new System.EventHandler(this.arama_OnValueChanged);
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
            this.ADD_YENİ_CAT.IdleForecolor = System.Drawing.Color.SeaGreen;
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
            // FRM_ADDCAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 454);
            this.Controls.Add(this.ADD_YENİ_CAT);
            this.Controls.Add(this.add_cat);
            this.Controls.Add(this.insert_txt);
            this.Controls.Add(this.bunifuImageButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRM_ADDCAT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADDCAT";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label insert_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox add_cat;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuThinButton2 ADD_YENİ_CAT;
    }
}