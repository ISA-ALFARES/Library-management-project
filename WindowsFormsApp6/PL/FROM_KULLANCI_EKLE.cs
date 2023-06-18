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
    public partial class FROM_KULLANCI_EKLE : Form
    {
        public int ID;
        public FROM_KULLANCI_EKLE()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FROM_KULLANCI_EKLE_Load(object sender, EventArgs e)
        {

        }

        private void ADD_YENİ_OGRENCI_Click(object sender, EventArgs e)
        {
            if (txt_kullanci_ad.Text == "" || txt_kullanci_tum_ad.Text == "" || txt_Yetkiler.Text == "" || txt_ogrenci_sifre.Text == "")
            {
                PL.FRM_ERROR_INSERT Ferror = new FRM_ERROR_INSERT();
                Ferror.Show();
            }
            else
            {
                if (ID == 0)
                {
                    //ekleme işlemi
                    BL.CLASS_KULLANCILAR BL_KULLANCI_EKLE = new BL.CLASS_KULLANCILAR();
                    BL_KULLANCI_EKLE.Insert(txt_kullanci_tum_ad.Text,txt_kullanci_ad.Text,txt_ogrenci_sifre.Text,txt_Yetkiler.Text,"False");
                    PL.FRM_EKLE_MESAJ Fadd = new FRM_EKLE_MESAJ();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    ////OGRENCILER Güncelleme  işlemi
                    //MemoryStream ma = new MemoryStream();
                    //BL.CLASS_OGRENCILER BL_OGRENCI_EDIT = new BL.CLASS_OGRENCILER();
                    //BL_OGRENCI_EDIT.Update(txt_kullanci_ad.Text, txt_kullanci_tum_ad.Text, txt_ogrenci_sifre.Text, txt_ogrenci_Telefon.Text, txt_ogrenci_EMAIL.Text, txt_ogrenci_Bolum.Text, ma, ID);
                    //PL.FRM_DUZENLE_MESAJ Fedit = new FRM_DUZENLE_MESAJ();
                    //Fedit.Show();
                    //this.Close();
                }

            }
        }
    }
}
