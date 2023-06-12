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
    public partial class FROM_KITABLAR_EKLE : Form
    {
        public int ID;
        public FROM_KITABLAR_EKLE()
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
                txt_kitap_resım.Image = Image.FromFile(AC_FILE_D.FileName);
            }
        }

        private void FROM_KITABLAR_EKLE_Load(object sender, EventArgs e)
        {

            try
            {
                BL.CLASS_KITABLAR BL_kitaplar = new BL.CLASS_KITABLAR();
                DataTable dt = new DataTable();
                dt = BL_kitaplar.katigori_load();
                //Verileri bir diziye koyuyoruz

                object[] opj = new object[dt.Rows.Count];
                int sayi;
                for (sayi = 0; sayi < dt.Rows.Count; sayi++)
                {
                    
                    opj[sayi] = dt.Rows[sayi]["CAT_NAME"];

                    
                }
                comboBox1.Items.AddRange(opj);



            }
            catch
            {

            }
        }

        private void ADD_YENİ_CAT_Click(object sender, EventArgs e)
        {
            if (txt_kitap_ad.Text=="" ||txt_yazar_name.Text == ""  || comboBox1.Text == "" || txt_kitap_Fiati.Text == ""  )
            {
                PL.FRM_ERROR_INSERT Ferror = new FRM_ERROR_INSERT();
                Ferror.Show();
            }
            else
            {
                if (ID == 0)
                {
                    MemoryStream ma = new MemoryStream();
                    txt_kitap_resım.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //ekleme işlemi
                    BL.CLASS_KITABLAR BL_KITAP_EKLE = new BL.CLASS_KITABLAR();
                    BL_KITAP_EKLE.Insert(txt_kitap_ad.Text, txt_yazar_name.Text, comboBox1.Text, txt_kitap_Fiati.Text, txt_kitap_Tarih.Value.ToString(), txt_kitap_Degerlendırme.Value, ma);
                    PL.FROM_DADD Fadd = new FROM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    //Güncelleme  işlemi
                    MemoryStream ma = new MemoryStream();
                    BL.CLASS_KITABLAR BLCAT = new BL.CLASS_KITABLAR();
                    BLCAT.Update(txt_kitap_ad.Text, txt_yazar_name.Text, comboBox1.Text, txt_kitap_Fiati.Text, txt_kitap_Tarih.Value.ToString(), txt_kitap_Degerlendırme.Value, ma ,ID);
                    PL.FRM_DEDIT Fedit = new FRM_DEDIT();
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
    }
}
