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
            dt = DAL.read("Pr_LOAD_KULLANCLAR", pr);
            return dt;
        }
    }
}
