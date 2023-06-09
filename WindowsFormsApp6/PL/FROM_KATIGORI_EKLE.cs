﻿using System;
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
                    BL.CLS_KATIGORI BLCAT = new BL.CLS_KATIGORI();
                    BLCAT.Insert(txt_kat_name.Text);
                    PL.FRM_EKLE_MESAJ Fadd = new FRM_EKLE_MESAJ();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    //Güncelleme  işlemi
                    BL.CLS_KATIGORI BLCAT = new BL.CLS_KATIGORI();
                    BLCAT.Update(txt_kat_name.Text,ID);
                    PL.FRM_DUZENLE_MESAJ Fedit = new FRM_DUZENLE_MESAJ();
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
