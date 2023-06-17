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
    class CLASS_OGRENCILER
    {
        //CLS_DAL sınıfının bir nesnesi olan DAL nesnesi oluşturulmuştur. Veritabanı işlemleriyle ilgilenmek için kullanılır.
        DAL.CLS_SQL_IBAGLANTI DAL = new WindowsFormsApp6.DAL.CLS_SQL_IBAGLANTI();
        //Verileri CLS_DAL sınıfında bulunan read işlevi kullanarak veritabanından getirir. Verileri DataTable olarak döndürür.
        //select işlevi:
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("Pr_LoadOGRENCILER", pr); // Pr_LOADCAT => SELECT * FROM T_CAT(katigotıler tablo) 
            return dt;
        }
        //insert işlevi:
        public void Insert(string OGRENCI_NO, string AD, string ADRES, string TELEFON, string EMAIL, string BULUM, MemoryStream RESIM)
        {
            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("OGRENCI_NO", OGRENCI_NO);
            pr[1] = new SqlParameter("AD",AD);
            pr[2] = new SqlParameter("ADRES", ADRES);
            pr[3] = new SqlParameter("TELEFON", TELEFON);
            pr[4] = new SqlParameter("EMAIL", EMAIL);
            pr[5] = new SqlParameter("BULUM", BULUM);
            pr[6] = new SqlParameter("RESIM", RESIM.ToArray());
            DAL.open();
            DAL.execute("INSERT_OGRENCI_YENI", pr); // INSERT_OGRENCILER => INSERRT NTO KITABLAR .....;
            DAL.close();
        }
        //select işlevi :
        public DataTable LoadDuzenle(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("SELECT_OGRENCI_YENI", pr); // OGRENCILER => SELECT * FROM OGRENCILER(OGRENCILER tablo) 
            return dt;
        }
        //Update işlevi: 
        public void Update(string OGRENCI_NO , string AD, string ADRES, string TELEFON, string EMAIL, string BULUM,  MemoryStream RESIM , int ID)
        {
            SqlParameter[] pr = new SqlParameter[8];
            pr[0] = new SqlParameter("OGRENCI_NO", OGRENCI_NO);
            pr[1] = new SqlParameter("AD", AD);
            pr[2] = new SqlParameter("ADRES", ADRES);
            pr[3] = new SqlParameter("TELEFON", TELEFON);
            pr[4] = new SqlParameter("EMAIL", EMAIL);
            pr[5] = new SqlParameter("BULUM", BULUM);
            pr[6] = new SqlParameter("RESIM", RESIM.ToArray());
            pr[7] = new SqlParameter("ID", ID);


            DAL.open();
            DAL.execute("UPDATE_OGRENCILER", pr);
            DAL.close();
        }
        //Silme işlevi:
        public void Delet(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("DELTE_OGREMCILER", pr);
            DAL.close();
        }
        //Arama işlevi:
        public DataTable Search(string Search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", Search);
            DataTable dt = new DataTable();
            dt = DAL.read("OGRENCILER_SEARCH", pr); //select  OGRENCI_NO,AD ,ADRES, TELEFON , EMAIL , BULUM   from  OGRENCILER where  CONCAT(OGRENCI_NO,AD ,ADRES, TELEFON , EMAIL , BULUM) like '%'+ @SEARCH +'%' 
            return dt;
        }
    }

}
