using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp6.BL
{
    class CLASS_KITABLAR
    {
        //CLS_DAL sınıfının bir nesnesi olan DAL nesnesi oluşturulmuştur. Veritabanı işlemleriyle ilgilenmek için kullanılır.
        DAL.CLS_SQL_IBAGLANTI DAL = new WindowsFormsApp6.DAL.CLS_SQL_IBAGLANTI();
        //Verileri CLS_DAL sınıfında bulunan read işlevi kullanarak veritabanından getirir. Verileri DataTable olarak döndürür.
        // Bu, veritabanından dataGridView1'ye veri yükleme işlemidir.
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("Pr_LoadKitablar", pr); // Pr_LOADCAT =>  SELECT id, K_AD, YAZAR, KATEGORI, K_FIATIFROM KITABLAR
            return dt;
        }
        //Combo_box select işlevi:
        public DataTable katigori_load()
        {
            SqlParameter[] pr = null ;
            DataTable dt = new DataTable();
            dt = DAL.read("EKLE_COMBO_BOX", pr); 
            return dt;
        }

        //insert işlevi:
        public void Insert( string K_AD , string YAZAR , string KATIGORI, string  K_FIATI , string K_TARIH, int DEGERLENDIRME, MemoryStream K_RESIM)
        {
            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("K_AD"         , K_AD);
            pr[1] = new SqlParameter("YAZAR"        , YAZAR);
            pr[2] = new SqlParameter("KATIGORI",    KATIGORI);
            pr[3] = new SqlParameter("K_FIATI"      , K_FIATI);
            pr[4] = new SqlParameter("K_TARIH", K_TARIH);
            pr[5] = new SqlParameter("DEGERLENDIRME", DEGERLENDIRME);
            pr[6] = new SqlParameter("K_RESIM"      ,  K_RESIM.ToArray());
            DAL.open();
            DAL.execute("INSERT_COMBOBOX",pr); // INSERT_COMBOBOX => 	insert into KITABLAR (K_AD ,YAZAR ,KATEGORI, K_FIATI , TARIH , DEGERLENDIRME, K_RESIM) values(@K_AD, @YAZAR, @KATIGORI, @K_FIATI, @K_TARIH, @DEGERLENDIRME, @K_RESIM)
            DAL.close();
        }
        //select işlevi :
        public DataTable LoadDuzenle(int ID)
        {
            SqlParameter[] pr =  new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("SELECT_KITAPLAR", pr); // KITAPLAR => SELECT * FROM KITAPLAR(KITAPLAR tablo) 
            return dt;
        }
        //Update işlevi: 
        public void Update(string K_AD, string YAZAR, string KATIGORI, string K_FIATI, string K_TARIH, int DEGERLENDIRME, MemoryStream K_RESIM , int ID)
        {
            SqlParameter[] pr = new SqlParameter[8];
            pr[0] = new SqlParameter("K_AD", K_AD);
            pr[1] = new SqlParameter("YAZAR", YAZAR);
            pr[2] = new SqlParameter("KATIGORI", KATIGORI);
            pr[3] = new SqlParameter("K_FIATI", K_FIATI);
            pr[4] = new SqlParameter("K_TARIH", K_TARIH);
            pr[5] = new SqlParameter("DEGERLENDIRME", DEGERLENDIRME);
            pr[6] = new SqlParameter("K_RESIM", K_RESIM.ToArray());
            pr[7] = new SqlParameter("ID",ID);
            DAL.open();
            DAL.execute("UPDATE_KITAPLAR", pr); 
            DAL.close();
        }
        //Silme işlevi:
        public void Delet(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("DELTE_KITAPLAR", pr); //	Delete KITABLAR  where id = @ID   
            DAL.close();
        }
        //Arama işlevi:
        public DataTable Search(string Search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", Search);
            DataTable dt = new DataTable();
            dt = DAL.read("KITAPLAR_SEARCH", pr); // KITAPLAR_SEARCH => 	select K_AD ,YAZAR ,KATEGORI, K_FIATI , TARIH , DEGERLENDIRME  from  KITABLAR where  CONCAT(K_AD ,YAZAR ,KATEGORI, K_FIATI , TARIH , DEGERLENDIRME) like '%'+ @SEARCH +'%'

            return dt;
        }
    }
}
