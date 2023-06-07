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
        DAL.CLS_DAL DAL = new WindowsFormsApp6.DAL.CLS_DAL(); 
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("Pr_LOADCAT", pr);
            return dt;
        }
    }
}
