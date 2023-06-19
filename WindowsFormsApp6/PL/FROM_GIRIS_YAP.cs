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
    public partial class FROM_GIRIS_YAP : Form
    {
        public FROM_GIRIS_YAP()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ADD_YENİ_CAT_Click(object sender, EventArgs e)
        {
            try
            {
                BL.CLASS_KULLANCILAR CALSS_KULLANCI = new BL.CLASS_KULLANCILAR();
                DataTable dt = new DataTable();
                dt = CALSS_KULLANCI.GIRIS(txt_kullanci_ad.Text, txt_ogrenci_sifre.Text);
                if (dt.Rows.Count > 0)
                {
                    CALSS_KULLANCI.UPDATE_GIRIS(txt_kullanci_ad.Text, txt_ogrenci_sifre.Text);
                    PL.F_MAIN FROM_MAIN = new F_MAIN();
                    object username = dt.Rows[0]["AD"];
                    object kim = dt.Rows[0]["YETKILER"];
                    FROM_MAIN.USER_AD.Text = username.ToString();
                    FROM_MAIN.KIM.Text = kim.ToString();
                    FROM_MAIN.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("giriş bilgilarinde bir yalınş vardır..!!!");
                MessageBox.Show(ex.Message);
            }

        }
    }
}
