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
using System.IO;
namespace WindowsFormsApp6.PL

{
    public partial class F_MAIN : Form
    {
        string state;  //Geçerli sayfanın adını saklar
        ///string ID ;

         BL.CLS_KATIGORI BLCAT = new BL.CLS_KATIGORI(); 
         BL.CLASS_KITABLAR BL_KITABLAR = new BL.CLASS_KITABLAR();
         BL.CLASS_OGRENCILER BL_OGRENCILER = new BL.CLASS_OGRENCILER();
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
            P_HOME.Visible = false;              //Ana sayfayı gizledik
            P_MAIN.Visible = true;              //Kategori sayfasını gösterdik 
            state = "F_KITAPLAR";
            Lb_Title.Text = "  Kitablar    ";  //Sayfa ismi
            //Veritabanlarında depolanan verileri getirme
            try
            {
                DataTable dt = new DataTable();
                dt = BL_KITABLAR.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Kitab ıd";
                dataGridView1.Columns[1].HeaderText = "kıtab ad";
                dataGridView1.Columns[2].HeaderText = "Yazar ad";
                dataGridView1.Columns[3].HeaderText = "Katıgore";
                dataGridView1.Columns[4].HeaderText = "kıtab Fıyatı";

            }
            catch (Exception ex) //Herhangi bir hata görünürse, görünecektir
            {
                MessageBox.Show(ex.Message);
            }
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
            if (state == "F_KITAPLAR")
            {
                DataTable dt = new DataTable();
                dt = BL_KITABLAR.LoadDuzenle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                // Veritabanından değerleri çekme
                object opj1 = dt.Rows[0]["K_AD"];         // Kitap adı
                object opj2 = dt.Rows[0]["YAZAR"];        // Yazar adı
                object opj3 = dt.Rows[0]["KATEGORI"];     // Kategori
                object opj4 = dt.Rows[0]["K_FIATI"];      // Kitap fiyatı
                object opj5 = dt.Rows[0]["TARIH"];        // Kitap tarihi
                object opj6 = dt.Rows[0]["DEGERLENDIRME"];// Kitap değerlendirmesi
                object opj7 = dt.Rows[0]["K_RESIM"];      // Kitap resmi
                FORMLAR.FRM_DETYELER dETYELER = new FORMLAR.FRM_DETYELER();
                // Değerleri form elemanlarına atama
                dETYELER.txt_kitap_ad.Text = opj1.ToString();
                dETYELER.txt_yazar_name.Text = opj2.ToString();
                dETYELER.comboBox1.Text = opj3.ToString();
                dETYELER.txt_kitap_Fiati.Text = opj4.ToString();
                dETYELER.txt_kitap_Tarih.Value = Convert.ToDateTime(opj5);
                if (opj6 != DBNull.Value)
                {
                    dETYELER.txt_kitap_Degerlendırme.Value = Convert.ToInt32(opj6);
                }
                else
                {
                    dETYELER.txt_kitap_Degerlendırme.Value = 0;
                }

                byte[] op = null;
                if (opj7 != DBNull.Value)
                {
                    op = (byte[])opj7;
                }

                if (op != null)
                {
                    MemoryStream ma = new MemoryStream(op);
                    dETYELER.txt_kitap_resım.Image = Image.FromStream(ma);
                }

                bunifuTransition1.ShowSync(dETYELER);
            }
         }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //Katigori ekleme işlemi
            if (state == "CAT") //Bu düğme kategoriler sayfasındaysa uygulanacaktır.
            {
                PL.FROM_KATIGORI_EKLE FCAT = new FROM_KATIGORI_EKLE(); 
                FCAT.ADD_YENİ_CAT.ButtonText = "EKLE";
                FCAT.ID = 0;
                bunifuTransition1.ShowSync(FCAT);
                
            }
            //KITAP ekleme işlemi
            if (state == "F_KITAPLAR") //Bu düğme kategoriler sayfasındaysa uygulanacaktır.
            {
                PL.FROM_KITABLAR_EKLE F_KITAPLAR = new FROM_KITABLAR_EKLE();
                F_KITAPLAR.ADD_YENİ_CAT.ButtonText = "EKLE";
                F_KITAPLAR.ID = 0;
                bunifuTransition1.ShowSync(F_KITAPLAR);

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
            else if(state == "F_KITAPLAR")
            {
                P_HOME.Visible = false;              //Ana sayfayı gizledik
                P_MAIN.Visible = true;              //Kategori sayfasını gösterdik 
                state = "KITABLAR";
                Lb_Title.Text = "  Kitablar    ";  //Sayfa ismi
                                                   //Veritabanlarında depolanan verileri getirme
                try
                {
                    DataTable dt = new DataTable();
                    dt = BL_KITABLAR.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "Kitab ıd";
                    dataGridView1.Columns[1].HeaderText = "kıtab ad";
                    dataGridView1.Columns[2].HeaderText = "Yazar ad";
                    dataGridView1.Columns[3].HeaderText = "Katıgore";
                    dataGridView1.Columns[4].HeaderText = "kıtab Fıyatı";

                }
                catch (Exception ex) //Herhangi bir hata görünürse, görünecektir
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(state == "OGRENCILER")
            {

                P_HOME.Visible = false;              //Ana sayfayı gizledik
                P_MAIN.Visible = true;              //OGRENCILER sayfasını gösterdik 
                state = " ";
                Lb_Title.Text = "  Öğrenciler    ";  //Sayfa ismi
                                                     //Veritabanlarında depolanan verileri getirme
                try
                {
                    DataTable dt = new DataTable();
                    dt = BL_OGRENCILER.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "Öğrenci Numarası";
                    dataGridView1.Columns[1].HeaderText = "Öğrenci ad";
                    dataGridView1.Columns[2].HeaderText = "öğrenci adresi";
                    dataGridView1.Columns[3].HeaderText = "öğrenci Telefonu";
                    dataGridView1.Columns[4].HeaderText = "öğrenci e-postası";

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
                PL.FROM_KATIGORI_EKLE FCAT = new FROM_KATIGORI_EKLE();
                FCAT.ADD_YENİ_CAT.ButtonText = "Güncelleme";
                FCAT.txt_kat_name.Text =Convert.ToString( dataGridView1.CurrentRow.Cells[1].Value);
                FCAT.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bunifuTransition1.ShowSync(FCAT);

            }
            //Güncelleme  işlemi
            else if(state == "F_KITAPLAR")
            {
                PL.FROM_KITABLAR_EKLE DUZENLE_KITAP = new FROM_KITABLAR_EKLE();
                DUZENLE_KITAP.ADD_YENİ_CAT.ButtonText = "Güncelleme";
                DUZENLE_KITAP.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                DataTable dt = new DataTable();
                dt = BL_KITABLAR.LoadDuzenle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                // Veritabanından değerleri çekme
                object opj1 = dt.Rows[0]["K_AD"];         // Kitap adı
                object opj2 = dt.Rows[0]["YAZAR"];        // Yazar adı
                object opj3 = dt.Rows[0]["KATEGORI"];     // Kategori
                object opj4 = dt.Rows[0]["K_FIATI"];      // Kitap fiyatı
                object opj5 = dt.Rows[0]["TARIH"];        // Kitap tarihi
                object opj6 = dt.Rows[0]["DEGERLENDIRME"];// Kitap değerlendirmesi
                object opj7 = dt.Rows[0]["K_RESIM"];      // Kitap resmi

                // Değerleri form elemanlarına atama
                DUZENLE_KITAP.txt_kitap_ad.Text = opj1.ToString();
                DUZENLE_KITAP.txt_yazar_name.Text = opj2.ToString();
                DUZENLE_KITAP.comboBox1.Text = opj3.ToString();
                DUZENLE_KITAP.txt_kitap_Fiati.Text = opj4.ToString();
                DUZENLE_KITAP.txt_kitap_Tarih.Value = Convert.ToDateTime(opj5);

                if (opj6 != DBNull.Value)
                {
                    DUZENLE_KITAP.txt_kitap_Degerlendırme.Value = Convert.ToInt32(opj6);
                }
                else
                {
                    DUZENLE_KITAP.txt_kitap_Degerlendırme.Value = 0;
                }

                byte[] op = null;
                if (opj7 != DBNull.Value)
                {
                    op = (byte[])opj7;
                }

                if (op != null)
                {
                    MemoryStream ma = new MemoryStream(op);
                    DUZENLE_KITAP.txt_kitap_resım.Image = Image.FromStream(ma);
                }

                bunifuTransition1.ShowSync(DUZENLE_KITAP);

            }
        }
         
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            //Silme  işlemi
            if (state == "CAT") //Bu düğme kategoriler sayfasındaysa uygulanacaktır.
            {
                BLCAT.Delet(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_SILME_MESAJ FDELET = new FRM_SILME_MESAJ();
                FDELET.Show();


            }
            else if (state == "F_KITAPLAR") //Bu düğme Kitablar sayfasındaysa uygulanacaktır.
            {
                BL_KITABLAR.Delet(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_SILME_MESAJ FDELET = new FRM_SILME_MESAJ();
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
            else if( state == "F_KITAPLAR")
            {
                DataTable dt = new DataTable();
                dt = BL_KITABLAR.Search(arama.Text);
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;              //Ana sayfayı gizledik
            P_MAIN.Visible = true;              //OGRENCILER sayfasını gösterdik 
            state = " ";
            Lb_Title.Text = "  Öğrenciler    ";  //Sayfa ismi
            //Veritabanlarında depolanan verileri getirme
            try
            {
                DataTable dt = new DataTable();
                dt = BL_OGRENCILER.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Öğrenci Numarası";
                dataGridView1.Columns[1].HeaderText = "Öğrenci ad";
                dataGridView1.Columns[2].HeaderText = "öğrenci adresi";
                dataGridView1.Columns[3].HeaderText = "öğrenci Telefonu";
                dataGridView1.Columns[4].HeaderText = "öğrenci e-postası";

            }
            catch (Exception ex) //Herhangi bir hata görünürse, görünecektir
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
