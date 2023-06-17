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
    public partial class FRM_EMANET : Form
    {
        public int ID ;
        public FRM_EMANET()
        {
            InitializeComponent();
        }

        private void FRM_EMANET_Load(object sender, EventArgs e)
        {
            BL.CLASS_EMANET BL_EMANET = new BL.CLASS_EMANET();
            DataTable dt1 = new DataTable();
            dt1 = BL_EMANET.Load_KITAPLAR();
            dataGridView2.DataSource = dt1;
            DataTable dt2 = new DataTable();
            dt2 = BL_EMANET.Load_OGRENCILER();
            dataGridView3.DataSource = dt2;
        }

        private void ADD_YENİ_OGRENCI_Click(object sender, EventArgs e)
        {
            if(txt_ogrenci_ad.Text == "")
            {
                PL.FRM_ERROR_INSERT F_ERROR = new FRM_ERROR_INSERT();
                F_ERROR.ShowDialog();
            }
            else
            {
                if (ID == 0)
                {
                    //ekleme işlemi
                    BL.CLASS_EMANET BL_EMANET_EKLE = new BL.CLASS_EMANET();
                    BL_EMANET_EKLE.Insert(Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView3.CurrentRow.Cells[1].Value), Convert.ToString(txt_ogrenci_ad.Text), Convert.ToString(txt_kitap_Tarih1.Value), Convert.ToString(txt_kitap_Tarih2.Value));
                    PL.FRM_EKLE_MESAJ Fadd = new FRM_EKLE_MESAJ();
                    Fadd.Show();
                    this.Close();
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
