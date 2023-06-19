using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp6.PL
{
    public partial class BAŞLA_FROM : Form
    {
        public BAŞLA_FROM()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BL.CLASS_KULLANCILAR kullanci_from = new BL.CLASS_KULLANCILAR();
            DataTable dt = new DataTable();
            dt = kullanci_from.BASLA_Load();
            if(dt.Rows.Count > 0)
            {
                    PL.F_MAIN FROM_MAIN = new F_MAIN();
                    object username = dt.Rows[0]["AD"];
                    object kim = dt.Rows[0]["YETKILER"];
                    FROM_MAIN.USER_AD.Text = username.ToString();
                    FROM_MAIN.KIM.Text = kim.ToString();
                    FROM_MAIN.Show();
                    this.Hide();
                    timer1.Enabled = false;
            }
            else
            {
                PL.FROM_GIRIS_YAP GIRIS_FROM = new FROM_GIRIS_YAP();
                GIRIS_FROM.Show();
                this.Hide();
                timer1.Enabled = false;

            }


        }
    }
}
