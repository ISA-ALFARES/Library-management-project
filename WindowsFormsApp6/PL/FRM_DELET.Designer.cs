
namespace WindowsFormsApp6.PL
{
    partial class FRM_DELET
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lb_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lb_Title
            // 
            this.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Title.Font = new System.Drawing.Font("Rockwell", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.ForeColor = System.Drawing.Color.White;
            this.Lb_Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lb_Title.Location = new System.Drawing.Point(55, 211);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(520, 38);
            this.Lb_Title.TabIndex = 7;
            this.Lb_Title.Text = "Başarıyla Bir şekilde Silinmiştir !";
            this.Lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lb_Title.Click += new System.EventHandler(this.Lb_Title_Click);
            // 
            // FRM_DELET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(630, 461);
            this.Controls.Add(this.Lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FRM_DELET";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.Text = "FRM_DELET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_DELET_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lb_Title;
    }
}