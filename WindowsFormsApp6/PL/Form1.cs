using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.PL
{
    public partial class F_MAIN : Form
    {
        public F_MAIN()
        {
            InitializeComponent();
        }
        // form yer değişterme değerler 
        int move;
        int movx;
        int movy;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void P_TB_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void P_TB_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void P_TB_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if(P_MB.Size.Width  == 175)
            {
                P_MB.Width = 50;
                button1.RightToLeft = RightToLeft.Yes;
                button2.RightToLeft = RightToLeft.Yes;
                button3.RightToLeft = RightToLeft.Yes;
                button4.RightToLeft = RightToLeft.Yes;
                button5.RightToLeft = RightToLeft.Yes;
                button6.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                P_MB.Width = 175;
                button1.RightToLeft = RightToLeft.No;
                button2.RightToLeft = RightToLeft.No;
                button3.RightToLeft = RightToLeft.No;
                button4.RightToLeft = RightToLeft.No;
                button5.RightToLeft = RightToLeft.No;
                button6.RightToLeft = RightToLeft.No;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
