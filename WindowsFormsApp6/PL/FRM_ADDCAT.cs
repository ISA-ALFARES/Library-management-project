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
    public partial class FRM_ADDCAT : Form
    {
        public FRM_ADDCAT()
        {
            InitializeComponent();
        }

        private void arama_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void ADD_YENİ_CAT_Click(object sender, EventArgs e)
        {
            if(add_cat.Text == "")
            {
                PL.FRM_ERROR_INSERT Ferror =new FRM_ERROR_INSERT();
                Ferror.Show();
            }
            else
            {
                BL.CLS_CAT BLCAT = new BL.CLS_CAT();
                BLCAT.Insert(add_cat.Text);
                PL.FROM_DADD Fadd = new FROM_DADD();
                Fadd.Show();
                this.Close();
            }
        }
    }
}
