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
    public partial class FROM_KATIGORI_EKLE : Form
    {
        public int ID;
        public FROM_KATIGORI_EKLE()
        {
            InitializeComponent();
        }

        private void arama_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ADD_YENİ_CAT_Click(object sender, EventArgs e)
        {
            if(txt_kat_name.Text == "")
            {
                PL.FRM_ERROR_INSERT Ferror =new FRM_ERROR_INSERT();
                Ferror.Show();
            }
            else
            {
                if(ID ==  0)
                {
                    //ekleme işlemi
                    BL.CLS_CAT BLCAT = new BL.CLS_CAT();
                    BLCAT.Insert(txt_kat_name.Text);
                    PL.FROM_DADD Fadd = new FROM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    //Güncelleme  işlemi
                    BL.CLS_CAT BLCAT = new BL.CLS_CAT();
                    BLCAT.Update(txt_kat_name.Text,ID);
                    PL.FRM_DEDIT Fedit = new FRM_DEDIT();
                    Fedit.Show();
                    this.Close();
                }

            }
        }

        private void FRM_ADDCAT_Load(object sender, EventArgs e)
        {

        }
    }
}
