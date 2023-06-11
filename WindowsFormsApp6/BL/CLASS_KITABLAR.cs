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
        DAL.CLS_DAL DAL = new WindowsFormsApp6.DAL.CLS_DAL();
        //Verileri CLS_DAL sınıfında bulunan read işlevi kullanarak veritabanından getirir. Verileri DataTable olarak döndürür.
        //select işlevi:
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("Pr_LoadKitablar", pr); // Pr_LOADCAT => SELECT * FROM T_CAT(katigotıler tablo) 
            return dt;
        }
        //Combo_box select işlevi:
        public DataTable katigori_load()
        {
            SqlParameter[] pr = null ;
            DataTable dt = new DataTable();
            dt = DAL.read("EKLE_COMBO_BOX", pr); // EKLE_COMBO_BOX => select * from  T_CAT where  CAT_NAME like '%'+ @SEARCH +'%' 
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
            DAL.execute("INSERT_COMBOBOX",pr); // P_ADDCAT => INSERRT NTO T_CAT VALUES(CAT_NAME);
            DAL.close();
        }

    }
}
