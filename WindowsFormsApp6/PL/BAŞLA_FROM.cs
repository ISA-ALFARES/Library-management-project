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
            // KULLANCILAR sınıfından bir nesne oluşturuyoruz
            BL.CLASS_KULLANCILAR kullanci_from = new BL.CLASS_KULLANCILAR();
            DataTable dt = new DataTable();
            // BASLA_Load fonksiyonunu çağırarak verileri getiriyoruz
            dt = kullanci_from.BASLA_Load();
            if (dt.Rows.Count > 0)
            {
                // F_MAIN formunu oluşturuyoruz
                PL.F_MAIN FROM_MAIN = new F_MAIN();
                // İlk satırdaki kullanıcı adını ve yetkilerini alıyoruz
                object username = dt.Rows[0]["AD"];
                object kim = dt.Rows[0]["YETKILER"];
                FROM_MAIN.USER_AD.Text = username.ToString();
                FROM_MAIN.KIM.Text = kim.ToString();
                // F_MAIN formunu gösteriyoruz
                FROM_MAIN.Show();
                this.Hide();
                timer1.Enabled = false;//başlatma foto
            }
            else
            {
                // FROM_GIRIS_YAP formunu tanımiyoruz
                PL.FROM_GIRIS_YAP GIRIS_FROM = new FROM_GIRIS_YAP();
                // FROM_GIRIS_YAP formunu gösteriyoruz, mevcut formu gizliyoruz
                GIRIS_FROM.Show();
                this.Hide();
                timer1.Enabled = false;//başlatma foto
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

