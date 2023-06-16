using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp6.BL
{
    class CLS_KATIGORI
    {
        //CLS_DAL sınıfının bir nesnesi olan DAL nesnesi oluşturulmuştur. Veritabanı işlemleriyle ilgilenmek için kullanılır.
        DAL.CLS_SQL_IBAGLANTI DAL = new WindowsFormsApp6.DAL.CLS_SQL_IBAGLANTI();
        //Verileri CLS_DAL sınıfında bulunan read işlevi kullanarak veritabanından getirir. Verileri DataTable olarak döndürür.
        //select işlevi:
        public DataTable Load() 
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("Pr_LOADCATSS",pr); // Pr_LOADCAT => SELECT * FROM T_CAT(katigotıler tablo) 
            return dt;
        }

        //Arama işlevi:
        public DataTable Search(string Search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", Search);
            DataTable dt = new DataTable();
            dt = DAL.read("CAT_SEARCH", pr); // Pr_LOADCAT => select * from  T_CAT where  CAT_NAME like '%'+ @SEARCH +'%' 
            return dt;
        }


        //insert işlevi: CLS_DAL sınıfında bulunan execute işlevini kullanarak yeni verileri veritabanına ekler. CAT_NAME parametresini giriş değeri olarak kullanır.
        public void Insert(string CAT_NAME)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("CAT_NAME",CAT_NAME);
            DAL.open();
            DAL.execute("CAT_ADDss", pr); // P_ADDCAT => INSERRT NTO T_CAT VALUES(CAT_NAME);
            DAL.close();
        }

        //Update işlevi: CLS_DAL sınıfında bulunan execute işlevini kullanarak yeni verileri veritabanına G]nceller.
        public void Update(string CAT_NAME , int ID)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CAT_NAME", CAT_NAME);
            pr[1] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("CAT_EDIT", pr); // CAT_EDIT => update  T_CAT set @CAT_NAME =@CAT_NAME
            DAL.close(); 
        }
        //Silme işlevi: CLS_DAL sınıfında bulunan execute işlevini kullanarak yeni verileri veritabanına G]nceller.
        public void Delet( int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("CAT_DELET", pr); // CAT_EDIT => update  T_CAT set @CAT_NAME =@CAT_NAME
            DAL.close();
        }

    }
}
