using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp6.PL
{
    public partial class FROM_OGRENCILER_EKLE : Form
    {
        public int ID;
        public FROM_OGRENCILER_EKLE ()
        {
            InitializeComponent();
        }

        private void insert_txt_Click(object sender, EventArgs e)
        {

        }

        private void txt_kat_name_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Resmi indirin ve görüntüleyin
            OpenFileDialog AC_FILE_D = new OpenFileDialog();
            var result = AC_FILE_D.ShowDialog();
            if ( result == DialogResult.OK)
            {
                txt_ogrenci_FOTO.Image = Image.FromFile(AC_FILE_D.FileName);
            }
        }

        private void FROM_KITABLAR_EKLE_Load(object sender, EventArgs e)
        {


        }

        private void ADD_YENİ_CAT_Click(object sender, EventArgs e)
        {
            if (txt_ogrenci_NO.Text == "" || txt_ogrenci_ad.Text == ""  || txt_ogrenci_adres.Text == "" || txt_ogrenci_Telefon.Text == ""  )
            {
                PL.FRM_ERROR_INSERT Ferror = new FRM_ERROR_INSERT();
                Ferror.Show();
            }
            else
            {
                if (ID == 0)
                {
                    MemoryStream ma = new MemoryStream();
                    txt_ogrenci_FOTO.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //ekleme işlemi
                    BL.CLASS_OGRENCILER BL_OGRENCI_EKLE = new BL.CLASS_OGRENCILER();
                    BL_OGRENCI_EKLE.Insert(txt_ogrenci_NO.Text, txt_ogrenci_ad.Text,txt_ogrenci_adres.Text,txt_ogrenci_Telefon.Text,txt_ogrenci_EMAIL.Text, txt_ogrenci_Bolum.Text, ma);
                    PL.FRM_EKLE_MESAJ Fadd = new FRM_EKLE_MESAJ();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    //OGRENCILER Güncelleme  işlemi
                    MemoryStream ma = new MemoryStream();
                    BL.CLASS_OGRENCILER BL_OGRENCI_EDIT = new BL.CLASS_OGRENCILER();
                    BL_OGRENCI_EDIT.Update(txt_ogrenci_NO.Text,txt_ogrenci_ad.Text, txt_ogrenci_adres.Text, txt_ogrenci_Telefon.Text, txt_ogrenci_EMAIL.Text, txt_ogrenci_Bolum.Text,ma, ID);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Katigori ekleme işlemi
            
                PL.FROM_KATIGORI_EKLE FCAT = new FROM_KATIGORI_EKLE();
                FCAT.ADD_YENİ_CAT.ButtonText = "EKLE";
                FCAT.ID = 0;
                FCAT.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
