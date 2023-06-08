using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp6.BL
{
    class CLS_CAT
    {
        //CLS_DAL sınıfının bir nesnesi olan DAL nesnesi oluşturulmuştur. Veritabanı işlemleriyle ilgilenmek için kullanılır.
        DAL.CLS_DAL DAL = new WindowsFormsApp6.DAL.CLS_DAL();
        //Verileri CLS_DAL sınıfında bulunan read işlevi kullanarak veritabanından getirir. Verileri DataTable olarak döndürür.
        public DataTable Load() 
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("Pr_LOADCAT", pr); // Pr_LOADCAT => SELECT * FROM T_CAT(katigotıler tablo) 
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
    }
}
