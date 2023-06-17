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
            dataGridView1.DataSource = dt1;
            DataTable dt2 = new DataTable();
            dt2 = BL_EMANET.Load_OGRENCILER();
            dataGridView2.DataSource = dt2;
        }

        private void ADD_YENİ_OGRENCI_Click(object sender, EventArgs e)
        {
            if(txt_ogrenci_FIAT.Text == "")
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
                    BL_EMANET_EKLE.Insert(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToString(txt_ogrenci_FIAT.Text), Convert.ToString(txt_kitap_Tarih1.Value), Convert.ToString(txt_kitap_Tarih2.Value));
                    PL.FRM_EKLE_MESAJ Fadd = new FRM_EKLE_MESAJ();
                    Fadd.Show();
                    this.Close();

                }
                else
                {
                    //Güncelleme  işlemi
                    BL.CLASS_EMANET BL_EMANET_DUZENLE= new BL.CLASS_EMANET();
                    BL_EMANET_DUZENLE.update(Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(txt_ogrenci_FIAT.Text), Convert.ToString(txt_kitap_Tarih1.Value), Convert.ToString(txt_kitap_Tarih2.Value),ID);
                    PL.FRM_DUZENLE_MESAJ Fedit = new FRM_DUZENLE_MESAJ();
                    Fedit.Show();
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
