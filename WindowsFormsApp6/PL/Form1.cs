using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApp6.PL

{
    public partial class F_MAIN : Form
    {
        string state;  //Geçerli sayfanın adını saklar
        ///string ID ;

         BL.CLS_CAT BLCAT = new BL.CLS_CAT(); // Bu kodun işlevi, CLS_CAT sınıfının yeni bir örneğini(BLCAT) oluşturmaktır.
        /*
            * BLCAT nesnesini kullanarak verileri bir veritabanından yükler ve bunları DataGridView kontrolünde görüntüler.
            
        */
        public F_MAIN()
        {
            InitializeComponent();
            
        }
        // Bu değişkenler formun boyutlarına özeldir.
        int move;
        int movx;
        int movy;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);                    //Çıkış simgesine tıkladığınızda program kapanır
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //Küçült simgesine tıkladığınızda, program gizlenir

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) //Genişlet simgesine basıldığında program ekranı doldurur
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal; //tam tersi

            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void P_TB_MouseDown(object sender, MouseEventArgs e)// P_TB sayfa Event
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void P_TB_MouseUp(object sender, MouseEventArgs e) // P_TB sayfa Event
        {
            move = 0;
        }

        private void P_TB_MouseMove(object sender, MouseEventArgs e)// P_TB sayfa Event
        {
            if (move == 1) //P_TB'de fare hareketiyle sayfayı hareket ettirin
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if(P_MB.Size.Width  == 175) //Basıldığında, kelimeler kaybolur ve simgeler görünür kalır
            {
                P_MB.Width = 50;
                button1.RightToLeft = RightToLeft.Yes;
                button2.RightToLeft = RightToLeft.Yes;
                button3.RightToLeft = RightToLeft.Yes;
                button4.RightToLeft = RightToLeft.Yes;
                button5.RightToLeft = RightToLeft.Yes;
                button6.RightToLeft = RightToLeft.Yes;
                button11.RightToLeft = RightToLeft.Yes;
            }
            else // //tam tersi
            {
                P_MB.Width = 175;
                button1.RightToLeft = RightToLeft.No;
                button2.RightToLeft = RightToLeft.No;
                button3.RightToLeft = RightToLeft.No;
                button4.RightToLeft = RightToLeft.No;
                button5.RightToLeft = RightToLeft.No;
                button6.RightToLeft = RightToLeft.No;
                button11.RightToLeft = RightToLeft.No;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = true;              // Bu ana sayfasıdır
            P_MAIN.Visible = false;             // Bu kategoriler sayfasıdır
            Lb_Title.Text = "Anasayfa       "; //Sayfa ismi
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            P_HOME.Visible    = false;              //Ana sayfayı gizledik
            P_MAIN.Visible    = true;              //Kategori sayfasını gösterdik 
            state = "CAT"; 
            Lb_Title.Text = "  Kategoriler    ";  //Sayfa ismi
            //Veritabanlarında depolanan verileri getirme
            try
            {
                /*
                   * DataTable, verileri bir tablo şeklinde depolamak ve düzenlemek için kullanılan bir veri yapısıdır.
                   *"dt" adında bir DataTable türünde bir değişken oluşturuyoruz
                   *DataTable, verileri bir tablo şeklinde depolamak ve düzenlemek için kullanılan bir veri yapısıdır.
                   *dataGridView1.DataSource = dt;  DataTable "dt" yi "dataGridView1" adlı bir DataGridView kontrolüne veri kaynağı olarak atıyoruz
                   *dataGridView1.Columns[0].HeaderText = "Numarası"    => Bu satır, tablodaki ilk veri sütununu adlandırmak için kullanılır.
                   *dataGridView1.Columns[1].HeaderText = "Catigories"  =>Bu satır, tablodaki ikinci veri sütununu adlandırmak için kullanılır.
                */
                DataTable dt = new DataTable(); 
                dt = BLCAT.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Numarası";
                dataGridView1.Columns[1].HeaderText = "Catigories";
            }
            catch(Exception ex) //Herhangi bir hata görünürse, görünecektir
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void F_MAIN_Load(object sender, EventArgs e) //Bux olay(Event), programı ilk çalıştırdığımızda ana sayfa açılacaktır.
        {
            P_HOME.Visible = true  ;
            P_MAIN.Visible = false ;
            Lb_Title.Text = "Anasayfa"  ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //ekleme işlemi
            if (state == "CAT") //Bu düğme kategoriler sayfasındaysa uygulanacaktır.
            {
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT(); 
                FCAT.ADD_YENİ_CAT.ButtonText = "EKLE";
                FCAT.ID = 0;
                bunifuTransition1.ShowSync(FCAT);
                
            }
        }

        private void P_HOME_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F_MAIN_Activated(object sender, EventArgs e)
        {
            if(state == "CAT")
            {
                try
                {
                    /*
                       * DataTable, verileri bir tablo şeklinde depolamak ve düzenlemek için kullanılan bir veri yapısıdır.
                       *"dt" adında bir DataTable türünde bir değişken oluşturuyoruz
                       *DataTable, verileri bir tablo şeklinde depolamak ve düzenlemek için kullanılan bir veri yapısıdır.
                       *dataGridView1.DataSource = dt;  DataTable "dt" yi "dataGridView1" adlı bir DataGridView kontrolüne veri kaynağı olarak atıyoruz
                       *dataGridView1.Columns[0].HeaderText = "Numarası"    => Bu satır, tablodaki ilk veri sütununu adlandırmak için kullanılır.
                       *dataGridView1.Columns[1].HeaderText = "Catigories"  =>Bu satır, tablodaki ikinci veri sütununu adlandırmak için kullanılır.
                    */
                    DataTable dt = new DataTable();
                    dt = BLCAT.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "Numarası";
                    dataGridView1.Columns[1].HeaderText = "Catigories";
                }
                catch (Exception ex) //Herhangi bir hata görünürse, görünecektir
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //Güncelleme  işlemi
            if (state == "CAT") //Bu düğme kategoriler sayfasındaysa uygulanacaktır.
            {
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.ADD_YENİ_CAT.ButtonText = "Güncelleme";
                FCAT.txt_kat_name.Text =Convert.ToString( dataGridView1.CurrentRow.Cells[1].Value);
                FCAT.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bunifuTransition1.ShowSync(FCAT);

            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            //Silme  işlemi
            if (state == "CAT") //Bu düğme kategoriler sayfasındaysa uygulanacaktır.
            {
                BLCAT.Delet(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DELET FDELET = new FRM_DELET();
                FDELET.Show();


            }
        }

        private void arama_OnValueChanged(object sender, EventArgs e)
        {
            //Arama  işlemi
            if (state == "CAT") //Bu düğme kategoriler sayfasındaysa uygulanacaktır.
            {
                DataTable dt = new DataTable();
                dt = BLCAT.Search(arama.Text);
                dataGridView1.DataSource = dt;

            }
        }
    }
}
