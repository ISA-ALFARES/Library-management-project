﻿using System;
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
        // BL.CLS_KATIGORI sınıfından bir nesne oluşturuldu ve BLCAT değişkenine atandı.
         BL.CLS_KATIGORI      BLCAT          = new BL.CLS_KATIGORI(); 
         BL.CLASS_KITABLAR    BL_KITABLAR    = new BL.CLASS_KITABLAR();
         BL.CLASS_OGRENCILER  BL_OGRENCILER  = new BL.CLASS_OGRENCILER();
         BL.CLASS_EMANET      BL_EMANET      = new BL.CLASS_EMANET();
         BL.CLASS_KULLANCILAR BL_KULLANCILAR = new BL.CLASS_KULLANCILAR();
        public F_MAIN()
        {
            InitializeComponent();
            
        }
        // Bu değişkenler formun boyutlarına özeldir.

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);//Çıkış simgesine tıkladığınızda program kapanır
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
 
        }

        private void P_TB_MouseUp(object sender, MouseEventArgs e) // P_TB sayfa Event
        {
        }

        private void P_TB_MouseMove(object sender, MouseEventArgs e)// P_TB sayfa Event
        {

        }

        //Menu Button
        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if(P_MB.Size.Width  == 175) //Basıldığında, sadece simgeler görünür 
            {
                P_MB.Width = 50;
                button1.RightToLeft = RightToLeft.Yes;
                button2.RightToLeft = RightToLeft.Yes;
                button3.RightToLeft = RightToLeft.Yes;
                button4.RightToLeft = RightToLeft.Yes;
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
                button6.RightToLeft = RightToLeft.No;
                button11.RightToLeft = RightToLeft.No;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = true;             // Bu ana sayfasıdır
            P_MAIN.Visible = false;            // Bu kategoriler sayfasıdır
            Lb_Title.Text = "Anasayfa       "; //Sayfa ismi
        }

        private void button4_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;              //Ana sayfayı gizledik
            P_MAIN.Visible = true;              //KULANCILAR sayfasını gösterdik 
            state = "KULANCILAR";
            Lb_Title.Text = "  Kullancilar    ";  //Sayfa ismi
            //Veritabanlarında depolanan verileri getirme
            try
            {
                DataTable dt = new DataTable();
                dt = BL_KULLANCILAR.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "ıd";
                dataGridView1.Columns[1].HeaderText = "Adı";
                dataGridView1.Columns[2].HeaderText = "Kullanci ad";
                dataGridView1.Columns[3].HeaderText = "Şifre";
                dataGridView1.Columns[4].HeaderText = "durum";

            }
            catch (Exception ex) //Herhangi bir hata görünürse, görünecektir
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;              //Ana sayfayı gizledik
            P_MAIN.Visible = true;              //Kategori sayfasını gösterdik 
            state = "EMANET";
            Lb_Title.Text = "  Emanet    ";  //Sayfa ismi
            //Veritabanlarında depolanan verileri getirme
            try
            {
                DataTable dt = new DataTable();
                dt =BL_EMANET.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "ıd";
                dataGridView1.Columns[1].HeaderText = "Öğrenci ad";
                dataGridView1.Columns[2].HeaderText = "Kitap adı";
                dataGridView1.Columns[3].HeaderText = "Teslim alma tarihi";
                dataGridView1.Columns[4].HeaderText = "Teslim tarihit  ";
                dataGridView1.Columns[5].HeaderText = "Toplam Fiyat";

            }
            catch (Exception ex) //Herhangi bir hata görünürse, görünecektir
            {
                MessageBox.Show(ex.Message);
            }
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
                try
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
                catch
                {

                }

            }
            else if (state == "OGRENCILER")
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = BL_OGRENCILER.LoadDuzenle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    // Veritabanından değerleri çekme
                    object opj1 = dt.Rows[0]["OGRENCI_NO"];         // Kitap adı
                    object opj2 = dt.Rows[0]["AD"];        // Yazar adı
                    object opj3 = dt.Rows[0]["ADRES"];     // Kategori
                    object opj4 = dt.Rows[0]["TELEFON"];      // Kitap fiyatı
                    object opj5 = dt.Rows[0]["EMAIL"];        // Kitap tarihi
                    object opj6 = dt.Rows[0]["BULUM"];// Kitap değerlendirmesi
                    object opj7 = dt.Rows[0]["RESIM"];      // Kitap resmi
                    FORMLAR.FRM_DETYELER_OGRENCILER dETYELER = new FORMLAR.FRM_DETYELER_OGRENCILER();
                    // Değerleri form elemanlarına atama
                    dETYELER.txt_ogrenci_NO.Text = opj1.ToString();
                    dETYELER.txt_ogrenci_ad.Text = opj2.ToString();
                    dETYELER.txt_ogrenci_adres.Text = opj3.ToString();
                    dETYELER.txt_ogrenci_Telefon.Text = opj4.ToString();
                    dETYELER.txt_ogrenci_Telefon.Text = opj4.ToString();
                    dETYELER.txt_ogrenci_EMAIL.Text = opj5.ToString();
                    dETYELER.txt_ogrenci_Bolum.Text = opj6.ToString();

                    byte[] op = null;
                    if (opj7 != DBNull.Value)
                    {
                        op = (byte[])opj7;
                    }

                    if (op != null)
                    {
                        MemoryStream ma = new MemoryStream(op);
                        dETYELER.txt_ogrenci_FOTO.Image = Image.FromStream(ma);
                    }

                    bunifuTransition1.ShowSync(dETYELER);
                }
                catch
                {

                }
                
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
            else if (state == "F_KITAPLAR") //Bu düğme kategoriler sayfasındaysa uygulanacaktır.
            {
                PL.FROM_KITABLAR_EKLE F_KITAPLAR = new FROM_KITABLAR_EKLE();
                F_KITAPLAR.ADD_YENİ_CAT.ButtonText = "EKLE";
                F_KITAPLAR.ID = 0;
                bunifuTransition1.ShowSync(F_KITAPLAR);

            }
            //OGRENCI ekleme işlemi
            else if (state == "OGRENCILER") //Bu düğme kategoriler sayfasındaysa uygulanacaktır.
            {
                PL.FROM_OGRENCILER_EKLE F_OGRANCILER = new FROM_OGRENCILER_EKLE();
                F_OGRANCILER.ADD_YENİ_OGRENCI.ButtonText = "EKLE";
                F_OGRANCILER.ID = 0;
                bunifuTransition1.ShowSync(F_OGRANCILER);

            }
            //EManet ekleme işlemi
            else if (state == "EMANET") //Bu düğme kategoriler sayfasındaysa uygulanacaktır.
            {
                PL.FRM_EMANET F_EMANET = new FRM_EMANET();
                F_EMANET.ADD_YENİ_OGRENCI.ButtonText = "EKLE";
                F_EMANET.ID = 0;
                bunifuTransition1.ShowSync(F_EMANET);

            }
            //Kullanci ekleme işlemi
            else if (state == "KULANCILAR") //Bu düğme kategoriler sayfasındaysa uygulanacaktır.
            {
                PL.FROM_KULLANCI_EKLE F_KULLANCI = new FROM_KULLANCI_EKLE();
                F_KULLANCI.ADD_YENİ_OGRENCI.ButtonText = "EKLE";
                F_KULLANCI.ID = 0;
                bunifuTransition1.ShowSync(F_KULLANCI);

            }
        }

        private void P_HOME_Paint(object sender, PaintEventArgs e)
        {

        }

        //Bu kod Yeni veriler yüklenir ve DataGridView kontrolüne bağlanır. Böylece kullanıcı, güncellenmiş verileri görüntüleyebilir.
        private void F_MAIN_Activated(object sender, EventArgs e)
        {
            //Ana sayfadaki panenlde kirap sayisi yazdiriyor
            try
            {
            DataTable dt = new DataTable();
            dt = BL_KITABLAR.Load();
            ktap_sayisi.Text = dt.Rows.Count.ToString();

            }
            catch
            {

            }
            //Ana sayfadaki panenlde ogrencı sayisi yazdiriyor
            try
            {
                DataTable dt = new DataTable();
                dt = BL_OGRENCILER.Load();
                ogrencı.Text = dt.Rows.Count.ToString();

            }
            catch
            {

            }
            //Ana sayfadaki panenlde emanet sayisi yazdiriyor
            try
            {
                DataTable dt = new DataTable();
                dt = BL_EMANET.Load();
                emanet.Text = dt.Rows.Count.ToString();

            }
            catch
            {

            }
            //Ana sayfadaki panenlde katıgori sayisi yazdiriyor
            try
            {
                DataTable dt = new DataTable();
                dt = BLCAT.Load();
                katıgores.Text = dt.Rows.Count.ToString();

            }
            catch
            {

            }
            //Ana sayfadaki panenlde emanet sayisi yazdiriyor
            try
            {
                DataTable dt = new DataTable();
                dt = BL_KITABLAR.Load();
                kullnancılar.Text = dt.Rows.Count.ToString();

            }
            catch
            {

            }
           //Kullanıcı izinler 
            if (KIM.Text == "Admin")
            {
                bunifuThinButton23.Enabled = true; //silme işlemi
                button4.Enabled = true;            //kullancilar butunu
            }
            else
            {
                bunifuThinButton23.Visible = false; //silme işlemi
                button4.Enabled = false;            //silme işlemi
            }
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
            else if (state == "OGRENCILER")
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
            else if(state == "EMANET")
            {
                P_HOME.Visible = false;              //Ana sayfayı gizledik
                P_MAIN.Visible = true;              //Kategori sayfasını gösterdik 
                state = "EMANET";
                Lb_Title.Text = "  Emanet    ";  //Sayfa ismi
                                                 //Veritabanlarında depolanan verileri getirme
                try
                {
                    DataTable dt = new DataTable();
                    dt = BL_EMANET.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "Öğrenci ıd";
                    dataGridView1.Columns[1].HeaderText = "Öğrenci ad";
                    dataGridView1.Columns[2].HeaderText = "Kitap adı";
                    dataGridView1.Columns[3].HeaderText = "Alma Tarihi";
                    dataGridView1.Columns[4].HeaderText = "Teslim Tarihi";
                    dataGridView1.Columns[5].HeaderText = "Toplam Fiyat ";

                }
                catch (Exception ex) //Herhangi bir hata görünürse, görünecektir
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(state == "KULANCILAR")
            {
                P_HOME.Visible = false;              //Ana sayfayı gizledik
                P_MAIN.Visible = true;              //Kategori sayfasını gösterdik 
                state = "KULANCILAR";
                Lb_Title.Text = "  Kullancilar    ";  //Sayfa ismi
                                                      //Veritabanlarında depolanan verileri getirme
                try
                {
                    DataTable dt = new DataTable();
                    dt = BL_KULLANCILAR.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "ıd";
                    dataGridView1.Columns[1].HeaderText = "Adı";
                    dataGridView1.Columns[2].HeaderText = "Kullanci ad";
                    dataGridView1.Columns[3].HeaderText = "Şifre";
                    dataGridView1.Columns[4].HeaderText = "Yetkiler";

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
                try{

                PL.FROM_KATIGORI_EKLE FCAT = new FROM_KATIGORI_EKLE();
                FCAT.ADD_YENİ_CAT.ButtonText = "Güncelleme";
                FCAT.txt_kat_name.Text =Convert.ToString( dataGridView1.CurrentRow.Cells[1].Value);
                FCAT.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bunifuTransition1.ShowSync(FCAT);

                }
                catch
                {

                }

            }
            //Güncelleme  işlemi
            else if(state == "F_KITAPLAR")
            {
                try
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
                catch
                {

                }

            }
            //Güncelleme  işlemi
            else if (state == "OGRENCILER")
            {

                PL.FROM_OGRENCILER_EKLE DUZENLE_OGRENCI = new FROM_OGRENCILER_EKLE();
                DUZENLE_OGRENCI.ADD_YENİ_OGRENCI.ButtonText = "Güncelleme";
                DUZENLE_OGRENCI.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                DataTable dt = new DataTable();
                dt = BL_OGRENCILER.LoadDuzenle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));


                // Veritabanından değerleri çekme
                object opj1 = dt.Rows[0]["OGRENCI_NO"];         
                object opj2 = dt.Rows[0]["AD"];        
                object opj3 = dt.Rows[0]["ADRES"];     
                object opj4 = dt.Rows[0]["TELEFON"];      
                object opj5 = dt.Rows[0]["EMAIL"];        
                object opj6 = dt.Rows[0]["BULUM"];
                object opj7 = dt.Rows[0]["RESIM"];      

                // Değerleri form elemanlarına atama
                DUZENLE_OGRENCI.txt_ogrenci_NO.Text      = opj1.ToString();
                DUZENLE_OGRENCI.txt_ogrenci_ad.Text      = opj2.ToString();
                DUZENLE_OGRENCI.txt_ogrenci_adres.Text   = opj3.ToString();
                DUZENLE_OGRENCI.txt_ogrenci_Telefon.Text = opj4.ToString();
                DUZENLE_OGRENCI.txt_ogrenci_EMAIL.Text   = opj5.ToString();
                DUZENLE_OGRENCI.txt_ogrenci_Bolum.Text   = opj6.ToString();


                byte[] op = null;
                if (opj7 != DBNull.Value)
                {
                    op = (byte[])opj7;
                }

                if (op != null)
                {
                    MemoryStream ma = new MemoryStream(op);
                    DUZENLE_OGRENCI.txt_ogrenci_FOTO.Image = Image.FromStream(ma);
                }

                bunifuTransition1.ShowSync(DUZENLE_OGRENCI);

            }
            //Güncelleme  işlemi
            else if (state == "EMANET")
            {

                PL.FRM_EMANET  F_EMANET= new FRM_EMANET();
                F_EMANET.ADD_YENİ_OGRENCI.ButtonText = "Güncelleme";
                F_EMANET.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bunifuTransition1.ShowSync(F_EMANET);

            }
            else if (state == "KULANCILAR")
            {
                try{

                    PL.FROM_KULLANCI_DUZENLE F_KULLANCILAR = new FROM_KULLANCI_DUZENLE();
                    F_KULLANCILAR.ADD_YENİ_OGRENCI.ButtonText = "Güncelleme";
                    F_KULLANCILAR.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    bunifuTransition1.ShowSync(F_KULLANCILAR);
                }
                catch
                {

                }
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
            else if (state == "OGRENCILER") //Bu düğme OGRENCILER sayfasındaysa uygulanacaktır.
            {
                BL_OGRENCILER.Delet(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_SILME_MESAJ FDELET = new FRM_SILME_MESAJ();
                FDELET.Show();


            }
            else if (state == "EMANET") //Bu düğme OGRENCILER sayfasındaysa uygulanacaktır.
            {
                BL_EMANET.Delet(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_SILME_MESAJ FDELET = new FRM_SILME_MESAJ();
                FDELET.Show();


            }
            else if (state == "KULANCILAR") //Bu düğme vKULANCILAR sayfasındaysa uygulanacaktır.
            {
                BL_KULLANCILAR.Delet(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_SILME_MESAJ FDELET = new FRM_SILME_MESAJ();
                FDELET.Show();


            }
        }

        private void arama_OnValueChanged(object sender, EventArgs e)
        {
            //Arama  işlemi
            if (state == "CAT") // Eğer durum "CAT" ise, bu kategoriler sayfasında uygulanacak
            {
                // Yeni bir DataTable nesnesi oluşturulur
                DataTable dt = new DataTable();
                // BLCAT sınıfındaki Search metodu çağrılır ve sonuç dt değişkenine atanır
                dt = BLCAT.Search(arama.Text);
                // DataGridView'in veri kaynağı dt olarak ayarlanır
                dataGridView1.DataSource = dt;
            }
            else if( state == "F_KITAPLAR")
            {
                DataTable dt = new DataTable();
                //   Search metodu çağrılır ve sonuç dt değişkenine atanır
                dt = BL_KITABLAR.Search(arama.Text);
                dataGridView1.DataSource = dt; //veriler gosteriyor
            }
            else if (state == "OGRENCILER")
            {
                DataTable dt = new DataTable();
                //   Search metodu çağrılır ve sonuç dt değişkenine atanır
                dt = BL_OGRENCILER.Search(arama.Text);
                dataGridView1.DataSource = dt;
            }
            else if (state == "EMANET")
            {
                DataTable dt = new DataTable();
                //   Search metodu çağrılır ve sonuç dt değişkenine atanır
                dt = BL_EMANET.Search(arama.Text);
                dataGridView1.DataSource = dt;
            }
            else if (state == "KULANCILAR")
            {
                DataTable dt = new DataTable();
                //   Search metodu çağrılır ve sonuç dt değişkenine atanır
                dt = BL_KULLANCILAR.Search(arama.Text);
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;              //Ana sayfayı gizledik
            P_MAIN.Visible = true;              //OGRENCILER sayfasını gösterdik 
            state = "OGRENCILER";
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
                // Giriş yapma formu oluşturulur
                PL.FROM_GIRIS_YAP login = new FROM_GIRIS_YAP();

                // Kullanıcı çıkış işlemi yapılır
                BL_KULLANCILAR.cikis_out();

                // Şu anki formu gizlenir
                this.Hide();

                // Giriş  formu gösterilir
                login.Show();

        }

        private void P_MB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
                //KITAP ekleme işlemi
                PL.FROM_KITABLAR_EKLE F_KITAPLAR = new FROM_KITABLAR_EKLE();
                F_KITAPLAR.ADD_YENİ_CAT.ButtonText = "EKLE";
                F_KITAPLAR.ID = 0;
                bunifuTransition1.ShowSync(F_KITAPLAR);

        }
        private void kat_ekle(object sender, EventArgs e)
        {
            //KITAP ekleme işlemi
            PL.FROM_KITABLAR_EKLE F_KITAPLAR = new FROM_KITABLAR_EKLE();
            F_KITAPLAR.ADD_YENİ_CAT.ButtonText = "EKLE";
            F_KITAPLAR.ID = 0;
            bunifuTransition1.ShowSync(F_KITAPLAR);

        }

        private void button8_Click(object sender, EventArgs e)
        {
                //OGRENCI ekleme işlemi
                PL.FROM_OGRENCILER_EKLE F_OGRANCILER = new FROM_OGRENCILER_EKLE();
                F_OGRANCILER.ADD_YENİ_OGRENCI.ButtonText = "EKLE";
                F_OGRANCILER.ID = 0;
                bunifuTransition1.ShowSync(F_OGRANCILER);

        }

        private void button10_Click(object sender, EventArgs e)
        {
                //EManet ekleme işlemi
                PL.FRM_EMANET F_EMANET = new FRM_EMANET();
                F_EMANET.ADD_YENİ_OGRENCI.ButtonText = "EKLE";
                F_EMANET.ID = 0;
                bunifuTransition1.ShowSync(F_EMANET);

        }

        private void P_TB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
                //Katigori ekleme işlemi
                PL.FROM_KATIGORI_EKLE FCAT = new FROM_KATIGORI_EKLE();
                FCAT.ADD_YENİ_CAT.ButtonText = "EKLE";
                FCAT.ID = 0;
                bunifuTransition1.ShowSync(FCAT);
        }
    }
}
