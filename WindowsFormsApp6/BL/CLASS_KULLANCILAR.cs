using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp6.BL
{
    class CLASS_KULLANCILAR
    {
        DAL.CLS_SQL_IBAGLANTI DAL = new WindowsFormsApp6.DAL.CLS_SQL_IBAGLANTI();
        //select işlevi:
        // Bu, veritabanından dataGridView1'ye veri yükleme işlemidir.
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("Pr_LOAD_KULLANI", pr);
            return dt;
        }
        //insert işlevi:
        public void Insert(string AD, string KULLANCI_ADI, string SIFRE, string YETKILER, string durum)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("AD", AD);
            pr[1] = new SqlParameter("KULLANCI_ADI", KULLANCI_ADI);
            pr[2] = new SqlParameter("SIFRE", SIFRE);
            pr[3] = new SqlParameter("YETKILER", YETKILER);
            pr[4] = new SqlParameter("durum", durum);
            DAL.open();
            DAL.execute("INSERT_KULLANCILAR", pr); 
        }
        ////select işlevi :
        //public DataTable LoadDuzenle(int ID)
        //{
        //    SqlParameter[] pr = new SqlParameter[1];
        //    pr[0] = new SqlParameter("ID", ID);
        //    DataTable dt = new DataTable();
        //    dt = DAL.read("SELECT_KULLANCILAR", pr);  
        //    return dt;
        //}
        //update işlevi:
        public void update(string AD, string KULLANCI_ADI, string SIFRE, string YETKILER, int ID)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("AD", AD);
            pr[1] = new SqlParameter("KULLANCI_ADI", KULLANCI_ADI);
            pr[2] = new SqlParameter("SIFRE", SIFRE);
            pr[3] = new SqlParameter("YETKILER", YETKILER);
            pr[4] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("Pr_Load_Kullancilar", pr);
        }
        //Silme işlevi:
        public void Delet(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("DELTE_KULLANCILAR", pr);
            DAL.close();
        }
        //Arama işlevi:
        public DataTable Search(string Search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", Search);
            DataTable dt = new DataTable();
            dt = DAL.read("KULLANCILAR_SEARCH", pr); // Pr_LOADCAT => select * from  T_CAT where  CAT_NAME like '%'+ @SEARCH +'%' 
            return dt;
        }
        //Çıkış işlevi:
        public void cikis_out()
        {
            SqlParameter[] pr = null ;
            DAL.open();
            DAL.execute("Pr_PROGRAM_CIKIS", pr);
            DAL.close();
        }
        //GIRIŞ işlevi:
        public DataTable GIRIS(string KULLANCI_ADI , string SIFRE)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("KULLANCI_ADI", KULLANCI_ADI);
            pr[1] = new SqlParameter("SIFRE", SIFRE);
            DataTable dt = new DataTable();
            dt = DAL.read("Pr_GIRIS_YAP", pr);
            return dt;
        }
        //Update giriş işlevi:
        public void UPDATE_GIRIS(string KULLANCI_ADI, string SIFRE)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("KULLANCI_ADI", KULLANCI_ADI);
            pr[1] = new SqlParameter("SIFRE", SIFRE);
            DAL.open();
            DAL.execute("Pr_GIRIS_YAP_UPDATE", pr);
        }

    }
}
