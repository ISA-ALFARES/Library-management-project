using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp6.BL
{
    class CLASS_EMANET
    {
        DAL.CLS_SQL_IBAGLANTI DAL = new WindowsFormsApp6.DAL.CLS_SQL_IBAGLANTI();
        //select işlevi:
        // Bu, veritabanından dataGridView1'ye veri yükleme işlemidir.
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("Pr_LOAD_EMANET", pr);
            return dt;
        }
        // Bu, veritabanından dataGridView1'ye veri yükleme işlemidir.
        public DataTable Load_KITAPLAR()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("Pr_LOAD_KITAPLAR_EMANET", pr);
            return dt;
        }
        // Bu, veritabanından dataGridView1'ye veri yükleme işlemidir.
        public DataTable Load_OGRENCILER()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("Pr_LOAD_OGRENCILER_EMANET", pr);
            return dt;
        }
        //insert işlevi:
        public void Insert(string OGRENCI_ADI, string KITAP_ADI, string ALMA_TARIH, string GETIRME_TARIH, string FIAT)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("OGRENCI_ADI", OGRENCI_ADI);
            pr[1] = new SqlParameter("KITAP_ADI", KITAP_ADI);
            pr[2] = new SqlParameter("ALMA_TARIH", ALMA_TARIH);
            pr[3] = new SqlParameter("GETIRME_TARIH", GETIRME_TARIH);
            pr[4] = new SqlParameter("FIAT", FIAT);
            DAL.open();
            DAL.execute("INSERT_EMANET", pr); 
            DAL.close();
        }
        //update işlevi:
        public void update(string OGRENCI_ADI, string KITAP_ADI, string ALMA_TARIH, string GETIRME_TARIH, string FIAT , int ID)
        {
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter("OGRENCI_ADI", OGRENCI_ADI);
            pr[1] = new SqlParameter("KITAP_ADI", KITAP_ADI);
            pr[2] = new SqlParameter("ALMA_TARIH", ALMA_TARIH);
            pr[3] = new SqlParameter("GETIRME_TARIH", GETIRME_TARIH);
            pr[4] = new SqlParameter("FIAT", FIAT);
            pr[5] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("UPDATE_EMANET", pr);
            DAL.close();
        }
    }
}
